using BusinessComponent.Administration;
using BusinessEntities;
using System;

namespace UserInterfaceLogic
{
    public class PersonUIProcess
    {
        public void CreatePerson(Person person)
        {
            var personComponent = new PersonComponent();
            personComponent.CreatePerson(person);
        }
    }
}
