using PetPeers.Business.Pets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PetPeers.API.Controllers
{
    [RoutePrefix("api/Pet")]
    public class PetController : ApiController
    {
        private readonly PetOperation petOps;
        public PetController()
        {
            petOps = new PetOperation();
        }

        [HttpGet]
        [Route("MyPets")]
        
        public IHttpActionResult GetAllUsersPets()
        {
            long loggedInUserId = 1;
            if (loggedInUserId > 0)
            {
                return Ok(this.petOps.GetAllPets(loggedInUserId));
            }
            return Unauthorized();
        }
    }
}
