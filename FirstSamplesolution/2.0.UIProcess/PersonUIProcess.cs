using BusinessEntities;
using System.Collections.Generic;
using UIProcess.PersonsServiceReference;

namespace UIProcess
{
    public class PersonsUIProcess
    {
        public void CreatePerson(Person person)
        {
            using (var personsServiceClient = new PersonsServiceClient())
            {
                personsServiceClient.CreatePerson(person);
            }
        }

        public List<Person> FindPersonsSummary(FindPersonsFilter findPersonsFilter)
        {
            List<Person> result = null;

            using (var personsServiceClient = new PersonsServiceClient())
            {
                result = personsServiceClient.FindPersonsSummary(findPersonsFilter);
            }

            return result;
        }
    }
}
