using PetPeers.Domain.DTO;
using PetPeers.Implementation.Pet;
using PetPeers.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPeers.Business.Pets
{
    public class PetOperation
    {
        private readonly IPetRepository petRepo;

        public PetOperation()
        {
            petRepo = new PetRepository();
        }

        public IEnumerable<PetDTO> GetAllPets(long loggedInUserId)
        {
            var result = this.petRepo.GetUserPets(loggedInUserId);
            var endResult = (from p in result
                             where p.UserId == loggedInUserId
                             select new PetDTO
                             {
                                 PetId = p.PetId,
                                 PetName = p.PetName,
                                 Place = p.Place,
                                 Age = p.Age,
                                 IsSold = p.IsAvailable.Value
                             }).ToList();
            return endResult;
        }

    }
}
