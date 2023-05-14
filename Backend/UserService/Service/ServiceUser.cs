using Grpc.Core;
using Grpc.Net.Client;
using ProtoService;
using ProtoService2;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using UserService.Model;
using UserService.Repository;

namespace UserService.Service
{
    public class ServiceUser : IUserService
    {

        private readonly IUserRepository _userRepository;
        private readonly JwtGenerator _jwtGenerator;
        private readonly IAccommodationService _accommodationService;

        /*
            Ovako se dobavlja rezervacija
            string id1 = "645f76ba5b45418b5fddca84";
            var channel1 = new Channel("localhost", 4113, ChannelCredentials.Insecure);
            var client1 = new ReservationGrpc.ReservationGrpcClient(channel1);
            var reservation = client1.GetReservationInfo(new ReservationRequest { Id = id1 });

            Ovako se dobavlja smestaj
            string id = "123456789123456789123456";
            var channel = new Channel("localhost", 4111, ChannelCredentials.Insecure);
            var client = new AccommodationGrpc.AccommodationGrpcClient(channel);
            var accommodation = client.GetAccommodationInfo(new AccommodationRequest { Id = id });
        
        */

        public ServiceUser(IUserRepository repository,IAccommodationService accommodationService)
        {
            _userRepository = repository;
            _jwtGenerator = new JwtGenerator();
            _accommodationService = accommodationService;
        }

        public IEnumerable<User> GetAll()
        {
            /*
            string id1 = "645f76ba5b45418b5fddca84";
            var channel1 = new Channel("localhost", 4113, ChannelCredentials.Insecure);
            var client1 = new ReservationGrpc.ReservationGrpcClient(channel1);
            var reservation = client1.GetReservationInfo(new ReservationRequest { Id = id1 });

            string id = "123456789123456789123456";
            var channel = new Channel("localhost", 4112, ChannelCredentials.Insecure);
            var client = new AccommodationGrpc.AccommodationGrpcClient(channel);
            var accommodation = client.GetAccommodationInfo(new AccommodationRequest { Id = id });

            */
            return _userRepository.GetAll();
        }

        public void Create(User user)
        {
            user.Password = CreateHashPassword(user.Password);
            _userRepository.Create(user);
        }
        public User GetById(string id)
        {
            return _userRepository.GetById(id);
        }

        public User GetByEmail(String email)
        {
            return _userRepository.GetByEmail(email);
        }

        public AuthenticationToken Login(string username, string password)
        {
            var user = _userRepository.Login(username, password);

            if (user == null) return null;

            return _jwtGenerator.GenerateAccessToken(user.Id, user.Role.ToString());
        }

        public String CreateHashPassword(string password)
        {
            byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);

            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Compute the hash value of the password byte array
                byte[] hashBytes = sha256Hash.ComputeHash(passwordBytes);

                // Convert the hash byte array to a string representation
                string hashString = Convert.ToBase64String(hashBytes);

                return hashString;
            }
        }

        public User WhoIAm(string token)
        {
            return _userRepository.WhoIAm(token);
        }

        public void Update(User user)
        {
            _userRepository.Update(user);
        }

        public void Delete(string id)
        {
            _userRepository.Delete(id);
        }

        public void Delete(User user)
        {
            _userRepository.Delete(user);
        }
    }
}