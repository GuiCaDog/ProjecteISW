using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace EcoScooter.Entities
{
    public partial class Employee:Person
    {
        //[Key]
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
