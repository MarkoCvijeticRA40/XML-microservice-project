﻿using UserService.Model;

namespace UserService.Repository
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        void Create(User user);
        public User GetById(string id);
        public Boolean IsUsernameExist(String username);
        public User GetByUsername(String username);
        public Boolean IsEmailExist(String email);
        public User Login(string username, string password);
        public User GetByEmail(String email);
        public User WhoIAm(string token);
        void Update(User user);

        void Delete(string id);

        void Delete(User user);

    }
}

