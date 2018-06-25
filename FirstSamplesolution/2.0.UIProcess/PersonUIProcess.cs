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
            List<Person> result = new List<Person>();

            using (var personsServiceClient = new PersonsServiceClient())
            {
                Person[] persons = personsServiceClient.FindPersonsSummary(findPersonsFilter);

                result.AddRange(persons);
            }

            return result;
        }
    }
}
