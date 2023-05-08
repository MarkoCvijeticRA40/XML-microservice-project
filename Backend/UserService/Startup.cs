using Grpc.Core;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Hosting.Internal;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.DTO;
using UserService.Mappers;
using UserService.Model;
using UserService.Repository;
using UserService.Service;

namespace UserService
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            //dodato
            services.AddCors();

            services.AddGrpc();

            // Add Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });

            var channel = new Channel("localhost", 4111, ChannelCredentials.Insecure);
            var client = new AccommodationGrpc.AccommodationGrpcClient(channel);
            services.AddSingleton(client);

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, ServiceUser>();
            services.AddScoped<IGenericMapper<User, UserDTO>, UserMapper>();
            services.AddScoped<IAccommodationService, AccommodationService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,IHostApplicationLifetime applicationLifetime)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //dodato
            app.UseCors(builder => builder
        .   AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());

            // Use Swagger
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
            app.UseHttpsRedirection();

            applicationLifetime.ApplicationStopping.Register(() =>
            {
                // Shutdown gRPC channel
                app.ApplicationServices.GetService<Channel>().ShutdownAsync().Wait();
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                
            });
        }
    }
}
