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

        public List<Person> FindPerson(Person person)
        {
            var matchedPersons = new List<Person>();
            using (var personsDataContext = new PersonsDataContext())
            {
                using (var allMatches = personsDataContext.FindPerson(person.Name, person.ProfessionId, person.CellularPhone, person.Email, person.LastName, person.Address))
                {
                    foreach (var match in allMatches)
                    {
                        matchedPersons.Add(new Person
                        {
                            PersonId = match.PersonId,
                            Name = match.Name,
                            ProfessionId = match.ProfessionId,
                            LastName = match.LastName,
                            Address = match.Address,
                            CellularPhone = match.CellularPhone,
                            Email = match.Email
                        });
                    }
                }
            }
            return matchedPersons;
        }
    }
}
