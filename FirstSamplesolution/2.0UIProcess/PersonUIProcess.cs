using BusinessComponent.Administration;
using BusinessEntities;
using System;
using System.Collections.Generic;

namespace UIProcess
{
    public class PersonUIProcess
    {
        public void CreatePerson(Person person)
        {
            var personComponent = new PersonComponent();
            personComponent.CreatePerson(person);
        }

        public List<Person> FindPerson(Person person)
        {
            var personComponent = new PersonComponent();
            var matchedPersons = PersonComponent.FindPerson(person);
            return matchedPersons;
        }
    }
}
