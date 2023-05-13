using Grpc.Core;
using Grpc.Net.Client;
using ProtoService;
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

        /*Ovako se dobavlja accommodation iz Accommodation mikroservisa
        string id = "12";
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
    }
}