using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessComponent.Administration;
using BusinessEntities;

namespace Services.Administration
{
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