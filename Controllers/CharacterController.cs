using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using simpson_net_web_api.Dependencies;
using simpson_net_web_api.Models;

namespace simpson_net_web_api.Controllers
{
    [Route("[controller]")
    [Controller]
    
    public class CharacterController : ICharacter
    {

        List<Character> listOfCharacters => new List<Character>
        {
            new Character{
                Name = "Homero J. Simpson", 
                Gender = "Masculino", 
                Age = 36, 
                Description = "Esposo de Marge y padre de Bart, Lisa y Maggie Simpson.",
                Photo = "http://static.t13.cl/images/sizes/1200x675/1455720735-19-homer.jpg"         
            },
            new Character{
                Name = "Margory Simpson", 
                Gender = "Femenino", 
                Age = 36, 
                Description = "Esposa de Homero, Madre de la familia Simpson.",
                Photo = "http://pluspng.com/img-png/marge-simpson-hd-png-marge-simpson-2-png-1220.png"         
            },
            new Character{
                Name = "Bart Simpson", 
                Gender = "Masculino", 
                Age = 10, 
                Description = "Hermano de Lisa y Maggie Simpson.",
                Photo = "https://upload.wikimedia.org/wikipedia/en/a/aa/Bart_Simpson_200px.png"         
            },
            new Character{
                Name = "Lisa Simpson", 
                Gender = "Femenino", 
                Age = 9, 
                Description = "Hermana de Bart y Maggie Simpsons.",
                Photo = "https://upload.wikimedia.org/wikipedia/en/thumb/e/ec/Lisa_Simpson.png/220px-Lisa_Simpson.png"         
            },
            new Character{
                Name = "Maggie Simpson", 
                Gender = "Femenino", 
                Age = 2, 
                Description = "Hermana de Bart y Lisa Simpson.",
                Photo = "https://upload.wikimedia.org/wikipedia/en/thumb/9/9d/Maggie_Simpson.png/220px-Maggie_Simpson.png"         
            },
        };



        [HttpGet("{id}")]
        public Character GetCharacter(int id) 
        {
             return listOfCharacters[id];

        }

        [HttpGet]
        public List<Character> GetCharacterList() 
        {
           return listOfCharacters;
        }
    }
}