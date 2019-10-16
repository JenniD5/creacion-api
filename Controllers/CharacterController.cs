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
                Description="Papa de Bart, Lisa y Maggie Simpson",
                Job="trabajo",
                BirthDate="9/11",
            },

            new Character
            {
                FirstName = "Bartolomeo",
                SecondName = "",
                LastName = "Simpsons",
                Age = 10,
                Description="hermano de Lisa y Maggie Simpson",
                BirthDate="23/2",
                 Job="",
               
            },

        
              new Character
            {
                FirstName = "Margaret",
                SecondName = "Abigail",
                LastName = "Simpsons",
                Age = 1,
                Description="hermana de Bart y Lisa Simpson",
                Job="",
                BirthDate="16/6",
            },

             new Character
            {
                FirstName = "Marjorie",
                SecondName = "",
                LastName = "Simpsons",
                Age = 34,
                Job="Ama de casa",
                Description="Es la esposa de Homero Simpson, madre de 3 hijos",
                BirthDate=" 1 de octubre",
                
            },
        };



 //crear usuario en sql express y contraseña, con los detalles de la sig linea 
      /*string de coneccion */  
      string connectionString=@"data source=LAPTOP-ENL6O117\SQLEXPRESS; initial catalog=db_simpsons; user id=2sim; password=1234";
          


    

        [HttpGet("{id}")]
        public Character GetCharacter(int id)
        {
            return characterList[id];
        }

        [HttpGet]

        public List<Character> GetCharacterList ()
        {
            List<Character> characters=new List<Character>();
            SqlConnection conn=new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select*from tbl_caracter", conn);
            conn.Open();
            SqlDataReader reader= cmd.ExecuteReader();
            while (reader.Read())
            {
             Character character = new Character
             {
               Id= reader.GetInt64(reader.GetOrdinal("id")),
               FirstName =reader.GetString(reader.GetOrdinal("firstname")),
               SecondName =reader.GetString(reader.GetOrdinal("secondname")),
               LastName=reader.GetString(reader.GetOrdinal("lastname")),
               Age = reader.GetInt32(reader.GetOrdinal("age")),
               Description = reader.GetString(reader.GetOrdinal("descp")),
               Job=reader.GetString(reader.GetOrdinal("job")),
               BirthDate=reader.GetString(reader.GetOrdinal("birthDate")),
             };
             characters.Add(character);
            }
           
            conn.Close();
            return characters;
        }
    }
}



