namespace MHG.Sample.Model
{
    public class Person
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Fullname => $"{Name} {Surname}";

        public string ImageUrl { get; set; }

        public string Description { get; set; }

        public Person(int id, string name, string surname, string imageUrl)
        {
            ID = id;
            Name = name;
            Surname = surname;
            ImageUrl = imageUrl;
        }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
}
