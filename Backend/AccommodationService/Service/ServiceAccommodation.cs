using System.Text.RegularExpressions;
using AccommodationService.Model;
using AccommodationService.Repository;
using Grpc.Core;
using Grpc.Net.Client;
using ProtoService1;

namespace AccommodationService.Service
{
    public class ServiceAccommodation : IAccommodationService
    {
        private readonly IAccommodationRepository _accommodationRepository;

        /* Ovako se poziva mikroservis kada zelite da dobavite usera
        string id = "string";
        var channel = new Channel("localhost", 4111, ChannelCredentials.Insecure);
        var client = new UserGrpc.UserGrpcClient(channel);
        var user = client.GetUserInfo(new UserRequest { Id = id });   
        */

        public ServiceAccommodation(IAccommodationRepository repository)
        {
            _accommodationRepository = repository;
        }
        public void Create(Accommodation accommodation)
        {
            _accommodationRepository.Create(accommodation);
        }

        public IEnumerable<Accommodation> GetAll()
        {
            //Ovako se poziva mikroservis,obrisite slobodono kad b
            string id = "6426ea62c3414f9576ca5a43";
            var channel = new Channel("localhost", 4112, ChannelCredentials.Insecure);
            var client = new UserGrpc.UserGrpcClient(channel);
            var user = client.GetUserInfo(new UserRequest { Id = id });
            //
            return _accommodationRepository.GetAll();
        }

        public Accommodation GetById(string id)
        {
            return _accommodationRepository.GetById(id);
        }
    }
}
