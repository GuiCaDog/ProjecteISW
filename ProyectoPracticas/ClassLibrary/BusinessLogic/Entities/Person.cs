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
            name = name;
            Telephon = telephon;
        }

        public DateTime Birthdate
        {
            get;
            set;
        }

        public string Dni
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
        public string Nom
        {
            get;
            set;
        }
        public int Telephon
        {
            get;
            set;
        }


    }
}
