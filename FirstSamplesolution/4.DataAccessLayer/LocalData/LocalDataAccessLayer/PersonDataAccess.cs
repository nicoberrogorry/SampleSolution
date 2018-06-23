using BusinessEntities;
using System.Collections.Generic;
using LocalDataAccessLayer.Models;
using System.Linq;
using System;

namespace LocalDataAccessLayer
{
    public class PersonDataAccess
    {
        public void CreatePerson(Person person)
        {
            using (var personsDataContext = new PersonsDataContext())
            {
                personsDataContext.CreatePerson(person.Name, person.Profession.ProfessionId,
                    person.CellularPhone, person.Email, person.LastName, person.Address);
            }
        }

        public List<Person> FindPersonsSummary(FindPersonsFilter personFilter)
        {
            List<Person> result = new List<Person>();

            using (var personsDataContext = new PersonsDataContext())
            {
                using (var foundPersonsSummaries = personsDataContext.FindPersonsSummary(personFilter.Name, personFilter.ProfessionId, personFilter.CellularPhone, personFilter.Email, personFilter.LastName, personFilter.Address))
                {
                    foreach (var personSummary in foundPersonsSummaries)
                    {
                        Profession profession = new Profession
                        {
                            Description = personSummary.ProfessionDescription
                        };

                        Person person = new Person
                        {
                            PersonId = personSummary.PersonId,
                            Name = personSummary.Name,
                            LastName = personSummary.LastName,
                            Profession = profession
                        };

                        result.Add(person);
                    }
                }
            }

            return result;
        }

        public Person GetPersonDetails(int personId)
        {
            Person result;

            try
            {
                using (var personsDataContext = new PersonsDataContext())
                {
                    using (var personDetails = personsDataContext.GetPersonDetails(personId))
                    {
                        var details = personDetails.First();

                        Profession profession = new Profession()
                        {
                            Description = details.Description,
                        };

                        result = new Person()
                        {
                            PersonId = personId,
                            Name = details.Name,
                            LastName = details.LastName,
                            Address = details.Address,
                            CellularPhone = details.CellularPhone,
                            Email = details.Email,
                            Profession = profession
                        };
                    }
                }
            }
            catch (InvalidOperationException invalidOperationException)
            {
                // This means ProfessionId is either negative or no profession with that id exists
                // TODO: LOG EXCEPTIONS
                // TODO: THROW CUSTOM EXCEPTION (Maybe DataAccessLayerException...)
                throw invalidOperationException;
            }

            return result;
        }
    }
}
