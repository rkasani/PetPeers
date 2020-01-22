namespace PetPeers.Domain.Models
{
    using System;
    
    /// <summary>
    /// Domain Model For Pet
    /// </summary>
    public class Pet
    {
        /// <summary>
        /// Pet Id of type long
        /// </summary>
        public long PetId { get; set; }

        /// <summary>
        /// Name of the pet
        /// </summary>
        public string PetName { get; set; }

        /// <summary>
        /// Place where the pet resides
        /// </summary>
        public string Place { get; set; }

        /// <summary>
        /// Age of the pet
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// User who owns the pet
        /// </summary>
        public long UserId { get; set; }

        /// <summary>
        /// date on which the pet was added to Db
        /// </summary>
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// is the pet available for sale 
        /// </summary>
        public bool? IsAvailable { get; set; }
    }
}
