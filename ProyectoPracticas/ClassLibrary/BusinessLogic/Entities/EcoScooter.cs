using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoScooter.Domain
{
    public partial class EcoScooter
    {
        double DiscountYounger
        {
            get;
            set;
        }
        double Fare
        {
            get;
            set;
        }
        double MaxSpeed
        {
            get;
            set;
        }

        ICollection<Person> PersonCollection;
        ICollection<Employee> EmployeeCollection;
        ICollection<Scooter> ScooterCollection;
        //.......

    }
}
