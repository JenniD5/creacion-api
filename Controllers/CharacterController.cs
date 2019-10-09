using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using simpsons_net_web_api.Modules;
using simpsons_net_web_api.Dependencies;

namespace simpsons_net_web_api.Controllers
{
    [Route("simpsons/[controller]")]
    [ApiController]
    public class CharacterController : Character
    {
        List<Character> listOfCharacter => new List<Character>
        {
            new Character
            {
                FirstName = "Homero",
                SecondName = "Jay",
                LastName = "Simpsons",
                Age = 34,
            },

            new Character
            {
                FirstName = "Bartolomeo",
                SecondName = "",
                LastName = "Simpsons",
                Age = 10,
            },

             new Character
            {
                FirstName = "Marjorie",
                SecondName = "Bouvier",
                LastName = "Simpsons",
                Age = 14,
                Job="Ama de casa",
                Description="Es la esposa de Homero Simpson, y madre de 3 hijos llamados: Bart Simpson de 10 años, Lisa Simpson de 8 y Maggie Simpson", 

            },
        };

        [HttpGet("{id}")]
        public Character GetCharacter(int id)
        {
            return listOfCharacter[id];
        }

        [HttpGet]

        public List<Character> GetCharacterList(int id)
        {
            return listOfCharacter;
        }
    }
}