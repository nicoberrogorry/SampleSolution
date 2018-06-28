using System.Collections.Generic;
using System.ServiceModel;
using BusinessComponent.Administration;
using BusinessEntities;

namespace Services.Administration
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class PersonsService : IPersonsService
    {
        private PersonsComponent personsComponent = new PersonsComponent();

        public void CreatePerson(Person person)
        {
            personsComponent.CreatePerson(person);
        }

        public List<Person> FindPersonsSummary(FindPersonsFilter findPersonsFilter)
        {
            List<Person> result = personsComponent.FindPersonsSummary(findPersonsFilter);
            return result;
        }

        public Person GetPersonDetails(int personId)
        {
            Person result = personsComponent.GetPersonDetails(personId);
            return result;
        }
    }
}