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
                Age = 34
            },

            new Character
            {
                FirstName = "Bartolomeo",
                SecondName = "",
                LastName = "Simpsons",
                Age = 10
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