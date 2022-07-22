using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionaryWork
{
    internal class PersonManager : IPersonDal
    {
        public void addPerson(int key, Person person)
        {
            Person.Persons.Add(key, person);
            Console.WriteLine($"Success: {person.ID} numaralı ID'ye sahip {person.Name} {person.SurName} listeye eklendi.");
            Console.WriteLine($"Info: Güncel kişi sayısı: {Person.Persons.Count}");
        }

        public void deletePerson(int key)
        {
            foreach (int id in Person.Persons.Keys)
            {
                if (key == id)
                {
                    Person.Persons.Remove(id);
                    Console.WriteLine($"Success: {id} ID'ye sahip kullanıcı silindi");
                    Console.WriteLine($"Info: Güncel kişi sayısı: {Person.Persons.Count}");
                }
                else if (key != id){}
                else
                {
                    Console.WriteLine($"Error: {key} ID'ye sahip kişi yok.");
                }
            }
            
        }
    }
}
