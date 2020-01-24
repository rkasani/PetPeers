
/// <summary>
/// GPL
/// </summary>
namespace PetPeers.Infrastructure.Repository
{
    using System.Collections.Generic;
    using Domain.Models;

    /// <summary>
    /// Interface that works with user information
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// Method to add new users to Collective
        /// </summary>
        /// <param name="newUser"></param>
        void AddUser(User newUser);

        /// <summary>
        /// Method to get all users in the collective
        /// </summary>
        /// <returns></returns>
        IEnumerable<User> GetAll();

        /// <summary>
        /// Method to get user details by Id
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        User GetUserById(long userId);

        /// <summary>
        /// Method to fetch newuserdetails
        /// </summary>
        /// <param name="newUserDetails"></param>
        /// <returns></returns>
        User UpdateUserDetails(User newUserDetails);
    }
}
