using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionaryWork
{
    internal interface IPersonDal
    {
        void addPerson(int key, Person person);
        void deletePerson(int key);
    }
}
