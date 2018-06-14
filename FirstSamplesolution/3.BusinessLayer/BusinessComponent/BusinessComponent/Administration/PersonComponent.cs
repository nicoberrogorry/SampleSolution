using BusinessEntities;
using LocalDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessComponent.Administration
{
    public class PersonComponent
    {
        public void CreatePerson(Person person)
        {
            var personDataAccess = new PersonDataAccess();
            personDataAccess.CreatePerson(person);
        }
    }
}
