using BusinessEntities;
using LocalDataAccessLayer;
using System.Collections.Generic;

namespace BusinessComponent.Administration
{
    public class PersonComponent
    {
        public void CreatePerson(Person person)
        {
            PersonDataAccess personDataAccess = new PersonDataAccess();
            personDataAccess.CreatePerson(person);
        }

        public static List<Person> FindPersonsSummary(FindPersonsFilter findPersonFilter)
        {
            List<Person> result = null;

            PersonDataAccess personDataAccess = new PersonDataAccess();

            result = personDataAccess.FindPersonsSummary(findPersonFilter);

            return result;
        }
    }
}
