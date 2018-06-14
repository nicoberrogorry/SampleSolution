using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LocalDataAccessLayer.Models;

namespace LocalDataAccessLayer
{
    public class PersonDataAccess
    {
        public void CreatePerson(Person person)
        {
            using (var personsDataContext = new PersonsDataContext())
            {
                personsDataContext.CreatePerson(person.Name, person.ProfessionId,
                    person.CellularPhone, person.Email, person.LastName, person.Address);
            }
        }
    }
}
