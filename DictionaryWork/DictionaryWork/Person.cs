using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionaryWork
{
    internal class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }

        public static Dictionary<int, Person> Persons = new Dictionary<int, Person>();

        public Person(int id, string name, string surName)
        {
            ID = id;
            Name = name;
            SurName = surName;
        }
    }
}
