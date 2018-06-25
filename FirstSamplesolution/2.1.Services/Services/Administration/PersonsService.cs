using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using BusinessComponent.Administration;
using BusinessEntities;
using Services.Administration;

namespace Services.Administration
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class PersonsService : IPersonsService
    {
        public void CreatePerson(Person person)
        {
            PersonComponent personComponent = new PersonComponent();
            personComponent.CreatePerson(person);
        }

        public List<Person> FindPersonsSummary(FindPersonsFilter findPersonsFilter)
        {
            List<Person> result = null;

            PersonComponent personComponent = new PersonComponent();

            result = PersonComponent.FindPersonsSummary(findPersonsFilter);

            return result;
        }
    }
}