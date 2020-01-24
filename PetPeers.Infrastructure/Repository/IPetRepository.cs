/// <summary>
/// General purpose development Infrastructure class for pets
/// </summary>
namespace PetPeers.Infrastructure.Repository
{
    using System.Collections.Generic;
    using DM = Domain.Models;
    /// <summary>
    /// Pet interface
    /// </summary>
    public interface IPetRepository
    {
        /// <summary>
        /// Adds new pet to pets collection
        /// </summary>
        /// <param name="newPet">typeof(Pet)</param>
        void AddPets(DM.Pet newPet);

        /// <summary>
        /// Updates the pet related details
        /// </summary>
        /// <param name="updatePet">params of type typeOf(Pet)</param>
        /// <returns>typeOf(Pet)</returns>
        DM.Pet UpdatePetDetails(DM.Pet updatePet);

        /// <summary>
        /// fetches all the pets that are in the collective.
        /// </summary>
        /// <returns>Collection of type typeOf(Pet)</returns>
        IEnumerable<DM.Pet> GetAll();

        /// <summary>
        /// Fetches pet details by Pet Id
        /// </summary>
        /// <param name="petId">long petId</param>
        /// <returns>typeOf(Pet)</returns>
        DM.Pet GetPetDetailsById(long petId);

        /// <summary>
        /// Get the user's pets
        /// </summary>
        /// <param name="userId">userId<LoggedInUserId></param>
        /// <returns>typeOf(List<Pet>)</Pet></returns>
        IEnumerable<DM.Pet> GetUserPets(long userId);
    }
}
