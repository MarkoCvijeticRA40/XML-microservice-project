using AccommodationService.Model;
using AccommodationService.Repository;
using Grpc.Core;
using ProtoService2;

namespace AccommodationService.Service
{
    public class ServiceAccommodation : IAccommodationService
    {
        private readonly IAccommodationRepository _accommodationRepository;

        /*
            Ovako se dobavlja rezervacija
            string id1 = "645f76ba5b45418b5fddca84";
            var channel1 = new Channel("localhost", 4113, ChannelCredentials.Insecure);
            var client1 = new ReservationGrpc.ReservationGrpcClient(channel1);
            var reservation = client1.GetReservationInfo(new ReservationRequest { Id = id1 });

            Ovako se dobavlja user
            string id = "645f76ba5b45418b5fddca8f";
            var channel = new Channel("localhost", 4112, ChannelCredentials.Insecure);
            var client = new UserGrpc.UserGrpcClient(channel);
            var user = client.GetUserInfo(new UserRequest { Id = id });
        */

        public ServiceAccommodation(IAccommodationRepository repository)
        {
            _accommodationRepository = repository;
        }

        public void Update(Accommodation accommodation)
        {
            DateTime start = accommodation.StartDate;
            DateTime end = accommodation.EndDate;

            DateTime newstart = new DateTime(start.Year, start.Month, start.Day + 1, 13, start.Minute, start.Second);
            DateTime newend = new DateTime(end.Year, end.Month, end.Day + 1, 14, end.Minute, end.Second);

            accommodation.StartDate = newstart;
            accommodation.EndDate = newend;

            _accommodationRepository.Update(accommodation);
        }

        public void Create(Accommodation accommodation)
        {
            _accommodationRepository.Create(accommodation);
        }

        public IEnumerable<Accommodation> GetAll()
        {
            return _accommodationRepository.GetAll();
        }

        public Accommodation GetById(string id)
        {
            return _accommodationRepository.GetById(id);
        }

        public void Delete(string id)
        {
            _accommodationRepository.Delete(id);
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


            if (pocetak >= 0 && kraj <= 0 && accommodation.Location.Equals(location))
            {
                accommodations.Add(accommodation);
            }
        }
        return accommodations;
    }

        public void Delete(Accommodation accommodation)
        {
            _accommodationRepository.Delete(accommodation);
        }
    }
}
