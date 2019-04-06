using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoshchytskyiKMAPractice4.Models;

namespace MoshchytskyiKMAPractice4.Tools.Storage
{
    internal interface IDataStorage
    {
        bool PersonExists(string email);

        Person GetPersonByEmail(string email);

        void RemovePerson(Person person);
        void AddPerson(Person person);
        List<Person> PersonsList { get; }
    }
}