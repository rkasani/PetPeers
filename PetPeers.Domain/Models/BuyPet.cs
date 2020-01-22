/// <summary>
/// Property of PetPeers project under GPL 
/// can use and update from this
/// </summary>
namespace PetPeers.Domain.Models
{
    /// <summary>
    /// To handle buyPet basic transaction data
    /// </summary>
    public class BuyPet
    {
        /// <summary>
        /// gets or sets user pet sale relationship Id
        /// </summary>
        public long PerUserSaleMappingId { get; set; }

        /// <summary>
        /// gets or sets pet identifier
        /// </summary>
        public long PetId { get; set; }

        /// <summary>
        /// gets or sets the user identifer who bought the pet
        /// </summary>
        public long BroughtBy { get; set; }


    }
}
