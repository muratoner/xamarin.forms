using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using MHG.Sample.Utility;

namespace MHG.Sample.Model
{
    public static class PersonFactory
    {
        public static List<Person> People = new List<Person>();

        public static int Count => People.Count;

        public static ObservableCollection<Grouping<string, Person>> BindingWithGrouping(string val = "")
        {
            var people = GetData();
            if (val != null)
                people = people.Where(T => T.Fullname.Contains(val)).ToList();

            var group =
                people.OrderBy(T => T.Fullname)
                    .GroupBy(T => T.Fullname[0].ToString())
                    .Select(T => new Grouping<string, Person>(T.Key, T));
            return new ObservableCollection<Grouping<string, Person>>(group);
        } 

        static List<Person> GetData()
        {
            People.Clear();
            var list =  new ObservableCollection<Person>();
            for (var i = 0; i < new Random().Next(1,10); i++)
            {
                var person = new Person(i, Faker.Name.First(), Faker.Name.Last(), $"{new Random().Next(1, 10)}.jpg")
                {
                    Description = Faker.Lorem.Sentence()
                };
                list.Add(person);
            }
            People.AddRange(list);
            return People;
        }
    }
}
