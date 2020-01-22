/// <summary>
/// Model class generated as part of Domain build 
/// </summary>
namespace PetPeers.Domain.Models
{
    using System;

    /// <summary>
    /// user details Class
    /// </summary>
    public class User
    {
        /// <summary>
        /// gets or sets the user identifier
        /// </summary>
        public long UserId { get; set; }

        /// <summary>
        /// gets or sets the user unique identifier
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// gets or sets the user First Name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// gets or sets user last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// gets or sets user password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// gets or sets the date of birth 
        /// </summary>
        public DateTime? DateofBirth { get; set; }

        /// <summary>
        /// gets or sets when user was added to collection
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// gets or sets when the user was lastupdated on
        /// </summary>
        public DateTime? LastUpdatedOn { get; set; }

        /// <summary>
        /// gets or sets if user account is active.
        /// </summary>
        public bool? IsActive { get; set; }

    }
}
