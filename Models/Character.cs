namespace simpsons_net_web_api.Models
{
    public class Character
    {
        int id;
        string name;
        string gender;
        int age;
        string description;
        string photo;

        public Character(int id, string name, string gender, int age, string description, string photo)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.description = description;
            this.photo = photo;
        }

        public Character(){}

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Gender
        {
            get => gender;
            set => gender = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public string Description
        {
            get => description;
            set => description = value;
        }

        public string Photo
        {
            get => photo;
            set => photo = value;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }
    }
}