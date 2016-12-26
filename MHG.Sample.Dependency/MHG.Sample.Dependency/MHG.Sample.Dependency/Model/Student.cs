using System;
using SQLite.Net.Attributes;

namespace MHG.Sample.Dependency.Model
{
    public class Student
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}