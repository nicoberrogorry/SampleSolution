using System.Collections.Generic;
using UIProcess.PersonsServiceReference;

namespace UIProcess
{
    public class PersonsUIProcess
    {
        public void CreatePerson(Person person)
        {
            using (var personsServiceClient = new PersonsServiceClient("BasicHttpBinding_IPersonsService"))
            {
                CreatePersonRequest request = new CreatePersonRequest()
                {
                    person = person
                };
                personsServiceClient.CreatePerson(request);
            }
        }

        public List<Person> FindPersonsSummary(FindPersonsFilter findPersonsFilter)
        {
            List<Person> result = null;

            using (var personsServiceClient = new PersonsServiceClient("BasicHttpBinding_IPersonsService"))
            {
                FindPersonsSummaryRequest request = new FindPersonsSummaryRequest()
                {
                    findPersonsFilter = findPersonsFilter
                };

                FindPersonsSummaryResponse response = personsServiceClient.FindPersonsSummary(request);

                result = response.FindPersonsSummaryResult;

            }

            return result;
        }
    }
}
