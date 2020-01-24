namespace PetPeers.Implementation.PetUser
{
    using System;
    using Domain.Models;
    using DataAccess;
    using Infrastructure.Repository;

    public class PetUserMapRepository : IPetUserRepository
    {
        private readonly PetPeersEntities dbContext;
        public PetUserMapRepository()
        {
            dbContext = new PetPeersEntities();
        }

        public void AddPetUserMap(BuyPet newMapValue)
        {
            
        }
    }
}
