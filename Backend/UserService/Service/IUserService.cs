using UserService.Model;

namespace UserService.Service
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();
        public void Create(User user);
        public User GetById(string id);
        public AuthenticationToken Login(string username, string password);
        public User GetByEmail(String email);
        public User WhoIAm(string token);
    }
}
