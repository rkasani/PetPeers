/// <summary>
/// GPL - added
/// </summary>
namespace PetPeers.Infrastructure.Repository
{
    using Domain.Models;
    /// <summary>
    /// PetUser transaction interface
    /// </summary>
    public interface IPetUserRepository
    {
        /// <summary>
        /// Method to add data to BuyPet table
        /// </summary>
        /// <param name="newMapValue"></param>
        void AddPetUserMap(BuyPet newMapValue);
    }
}
