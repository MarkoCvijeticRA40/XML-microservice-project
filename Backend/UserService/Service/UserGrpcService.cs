using Grpc.Core;
using MongoDB.Driver;
using ProtoService1;
using UserService.Model;
using UserService.Repository;

namespace UserService.Service
{
    public class UserGrpcService : UserGrpc.UserGrpcBase
    {

        IUserRepository userRepository = new UserRepository(); // replace with your implementation of IAccommodationRepository

        public UserGrpcService()
        {

        }

        public UserGrpcService(IUserRepository repository)
        {
            userRepository = repository;
        }

        public override Task<UserResponse> GetUserInfo(UserRequest request, ServerCallContext context)
        {
            // Retrieve the accommodation from the database using the ID
            User user = new User();
            user = userRepository.GetById(request.Id);

            // If the accommodation is not found, return an error
            if (user == null)
            {
                throw new RpcException(new Status(StatusCode.NotFound, $"Accommodation with ID '{request.Id}' not found."));
            }

            // Map the Accommodation entity to AccommodationResponse proto
            UserResponse response = new UserResponse
            {
                Username = user.Username,
                Name = user.Name,
                LastName = user.LastName,
                Role = (Role)user.Role,
                Password = user.Password,
                Email = user.Email,
                PlaceOfLiving = user.PlaceOfLiving
            };

            return Task.FromResult(response);
        }
    }
}
