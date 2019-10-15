using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using simpsons_net_web_api.Modules;
using simpsons_net_web_api.Dependencies;
using System.Data.SqlClient; 


namespace simpsons_net_web_api.Controllers
{
    [Route("simpsons/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]

    public class CharacterController : ICharacter
    {
        List<Character> characterList => new List<Character>
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
                SecondName = "",
                LastName = "Simpsons",
                Age = 34,
                Job="Ama de casa",
                Description="Es la esposa de Homero Simpson, y madre de 3 hijos llamados: Bart Simpson de 10 años, Lisa Simpson de 8 y Maggie Simpson", 

            },
        };



 //crear usuario en sql express y contraseña, con los detalles de la sig linea 
      /*string de coneccion */  
      string connectionString=@"data source=LAPTOP-ENL6O117\SQLEXPRESS; initial catalog=db_simpsons; user id=1sim; password=1111";
          


    

        [HttpGet("{id}")]
        public Character GetCharacter(int id)
        {
            return characterList[id];
        }

        [HttpGet]

        public List<Character> GetCharacterList ()
        {
            list<Character> characters=new list<Character>();
            SqlConnection conn=new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select*from tbl_caracter", conn);
            conn.Open();
            SqlDataReader reader= cmd.ExecuteReader();
            while (reader.Read())
            {
             Character character = new Character
             {
               Id= reader.GetInt64(reader.GetOrdinal("id")),
               FirstName =reader.GetString(reader.GetOrdinal("firstname"))
             };
             characters.Add(character);
            }
           
            conn.Close();
            return characters;
        }
    }
}



