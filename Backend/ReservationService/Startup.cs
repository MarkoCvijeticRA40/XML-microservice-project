using ReservationService.DTO;
using ReservationService.Mappers;
using ReservationService.Model;
using ReservationService.Repository;
using ReservationService.Service;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.Extensions.Configuration;
using Microsoft.OpenApi.Models;
using System.Threading.Channels;
using Grpc.Core;
using ProtoService2;

namespace ReservationService
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
            services.AddGrpc();
            services.AddScoped<IReservationRepository, ReservationRepository>();
            services.AddScoped<IReservationService, ServiceReservation>();
            services.AddScoped<IGenericMapper<Reservation, ReservationDTO>, ReservationMapper>();

            // Add Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });


          

            //
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder =>
                {
                    builder.WithOrigins("http://localhost:4200")
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });
            });
            
        }

        private Server server;

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IHostApplicationLifetime applicationLifetime)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            

            // Use Swagger
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseHttpsRedirection();

            app.UseCors();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapGrpcService<ReservationGrpcService>();
            });
            
            
            server = new Server
            {
                Services = { ReservationGrpc.BindService(new ReservationGrpcService()) },
                Ports = { new ServerPort("localhost", 4113, ServerCredentials.Insecure) }
            };
            server.Start();

            applicationLifetime.ApplicationStopping.Register(OnShutdown);
            
        }
        
        private void OnShutdown()
        {
            
            if (server != null)
            {
                server.ShutdownAsync().Wait();
            }
        }
    }
}
