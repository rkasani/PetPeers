using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPeers.Domain.DTO
{
    public class UserDTO
    {
        public UserDTO()
        {
            PetsOwned = new List<PetDTO>();
        }
        public long? UserId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<PetDTO> PetsOwned { get; set; }
    }
}
