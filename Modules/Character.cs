using System;

namespace simpsons_net_web_api.Modules
{
    public class Character
    {   Int64 id;
        string firstName;
        string secondName;
        string lastName;
        int age;
        int height;
        int weight;
        string birthDate;
    
        string job;
        string description;

        public Character(){}

        public Character(Int64 id ,string firstName, string secondName, string lastName, int age, int height, int weight, string birthDate, string job, string description)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.lastName = lastName;
            this.age = age;
            this.height = height;
            this.weight = weight;
            this.birthDate = birthDate;
           
            this.job = job;
            this.description = description;
            this.id=id;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string SecondName { get => secondName; set => secondName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
        public int Height { get => height; set => height = value; }
        public int Weight { get => weight; set => weight = value; }
        public string BirthDate { get => birthDate; set => birthDate = value; }
      
        public string Job { get => job; set => job = value; }
        public string Description { get => description; set => description = value; }
        public Int64 Id{get=> id; set=> id=value;}
    }
}