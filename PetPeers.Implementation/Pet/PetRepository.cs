namespace PetPeers.Implementation.Pet
{
    using System;
    using System.Collections.Generic;
    using DM = Domain.Models;
    using DataAccess;
    using Infrastructure.Repository;
    using System.Linq;

    public class PetRepository : IPetRepository
    {
        private readonly PetPeersEntities petEnt;
        public PetRepository()
        {
            petEnt = new PetPeersEntities();
        }
        public void AddPets(DM.Pet newPet)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DM.Pet> GetAll()
        {
            throw new NotImplementedException();
        }

        public DM.Pet GetPetDetailsById(long petId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DM.Pet> GetUserPets(long userId)
        {
            var outResult = AutoMapper.Mapper.Map<IEnumerable<Pet>, IEnumerable<DM.Pet>>(petEnt.Pets);
            return outResult;
        }

        public DM.Pet UpdatePetDetails(DM.Pet updatePet)
        {
            throw new NotImplementedException();
        }
    }
}
