using BusinessEntities;
using LocalDataAccessLayer;
using System.Collections.Generic;

namespace BusinessComponent.Administration
{
    public class PersonsComponent
    {
        private PersonDataAccess personDataAccess = new PersonDataAccess();

        public void CreatePerson(Person person)
        {
            personDataAccess.CreatePerson(person);
        }

        public List<Person> FindPersonsSummary(FindPersonsFilter findPersonFilter)
        {
            List<Person> result = personDataAccess.FindPersonsSummary(findPersonFilter);
            return result;
        }

        public Person GetPersonDetails(int personId)
        {
            Person result = personDataAccess.GetPersonDetails(personId);
            return result;
        }
    }
}
