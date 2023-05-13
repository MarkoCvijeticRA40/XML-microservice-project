using ProtoService1;

namespace AccommodationService.Service
{
    public interface IUserService
    {
        public Task<UserResponse> GetUserById(string id);
    }
}

