namespace PetPeers.Implementation.User
{
    using System;
    using System.Collections.Generic;
    using Domain.Models;
    using Infrastructure.Repository;

    public class UserRepository : IUserRepository
    {
        public void AddUser(User newUser)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetUserById(long userId)
        {
            throw new NotImplementedException();
        }

        public User UpdateUserDetails(User newUserDetails)
        {
            throw new NotImplementedException();
        }
    }
}
