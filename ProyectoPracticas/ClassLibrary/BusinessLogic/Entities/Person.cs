using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoScooter.Entities
{
    public partial class Person
    {
        public Person()
        {
        }
        public Person(DateTime birthDate, string dni, string email, string name, int telephon)
        {
            Birthdate = birthDate;
            Dni = dni;
            Email = email;
            Name = name;
            Telephon = telephon;
        }

        


    }
}
