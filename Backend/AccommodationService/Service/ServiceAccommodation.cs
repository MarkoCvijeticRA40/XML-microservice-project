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

        public List<Accommodation> GetAllAccommodationsBySearch(string location, int guests, DateTime startDate, DateTime endDate)
        {
            List<Accommodation> accommodations = new List<Accommodation>();
            foreach (Accommodation accommodation in GetAll())
            {

                DateTime sSearch = new DateTime(startDate.Year, startDate.Month, startDate.Day, 1, 1, 1);
                DateTime sAcc = new DateTime(accommodation.StartDate.Year, accommodation.StartDate.Month, accommodation.StartDate.Day, 1, 1, 1);

                DateTime eSearch = new DateTime(endDate.Year, endDate.Month, endDate.Day, 1, 1, 1);
                DateTime eAcc = new DateTime(accommodation.EndDate.Year, accommodation.EndDate.Month, accommodation.EndDate.Day, 1, 1, 1);

                int pocetak = DateTime.Compare(sSearch, sAcc);
                int kraj = DateTime.Compare(eSearch, eAcc);


                if (pocetak >= 0 && kraj <= 0 && accommodation.Location.Equals(location) && accommodation.MinCapacity <= guests && guests <= accommodation.MaxCapacity)
                {
                    accommodations.Add(accommodation);
                }
            }
            return accommodations;
        }
    }
}
