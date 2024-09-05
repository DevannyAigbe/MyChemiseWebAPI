using Microsoft.AspNetCore.Mvc;

namespace MyChemiseWebAPI.Controller
{
    [ApiController]
    public class ShirtsController: ControllerBase
    {
        [HttpGet]
        [Route("/Shirts")]
        public string GetShirts()
        {
            return "Reading all the shirts";
        }
        [HttpGet]
        [Route("/shirts/{id}")]
     public IActionResult GetShirtByid(int id)
        {
            if (id <= 0) 
                return BadRequest();
            var shirt = shirts.FirstOrDefault(x=>x.ShirtId == id);
            if(shirt == null)
                return NotFound();
            return Ok (shirt);
        }
        [HttpPost]
        [Route("/Shirts")]
        public string Createshirts()
        {
            return $"Creating a shirt";
        }
        [HttpPut]
        [Route("/shirts/{id}")]
        public string UpdateShirt(int id)
        {
            return $"Updating shirt:{id}";
        }
        [HttpDelete]
        [Route("/shirts {id}")]
        public string DeleteShirt(int id)
        {
            return $"Deleting shirt:{id}";
        }

    }


}
