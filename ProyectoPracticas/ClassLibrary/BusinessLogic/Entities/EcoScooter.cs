using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoScooter.Entities
{
    public partial class EcoScooter
    {
        public EcoScooter()
        {
            Employees = new List<Employee>();
            People = new List<Person>();
            Scooters = new List<Scooter>();
            Stations = new List<Station>();
        }
        public EcoScooter(double discountYounger, double fare, double maxSpeed, Employee employee) : this() 
         {
            Employees.Add(employee);
            DiscountYounger = discountYounger;
            Fare = fare;
            MaxSpeed = maxSpeed;
         }
        public double DiscountYounger
        {
            get;
            set;
        }
        public double Fare
        {
            get;
            set;
        }
        public double MaxSpeed
        {
            get;
            set;
        }

        public virtual ICollection<Person> People
        {
            get;
            set;
        }

        public virtual ICollection<Employee> Employees
        {
            get;
            set;
        }
        public virtual ICollection<Scooter> Scooters
        {
            get;
            set;
        }
        public virtual ICollection<Station> Stations
        {
            get;
            set;
        }

    }
}
