using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoScooter.Domain
{
    public partial class Employee : Person
    {
        public Employee() : base()
        {
            Maintenances = new List<Maintenance>();
        }
        //en primer lloc, passarem en ordre alfabètic els paràmetres que rep per a instanciar les seues propietats heretades i en segon lloc els paràmetres
         //propis(també en ordre alfabètic).
        public Employee(DateTime birthDate, String dni, String email, String name, int telephon, String iban, int pin, String position, Decimal salary) : base(birthDate, dni, email, name, telephon)
        {
            Iban = iban;
            Pin = pin;
            Position = position;
            Salary = salary;
            Maintenances = new List<Maintenance>();
        }
        public string Iban
        {
            get;
            set;
        }

        public int Pin
        {
            get;
            set;
        }

        public string Position
        {
            get;
            set;
        }
                
        public Decimal Salary
        {
            get;
            set;
        }

        /*Relaciones*/
        public virtual ICollection<Maintenance> Maintenances
        {
            get;
            set;
        }

    }
}
