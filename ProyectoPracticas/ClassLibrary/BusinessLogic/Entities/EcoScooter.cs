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
            People.Add(employee); //Nova linia afegida
            DiscountYounger = discountYounger;
            Fare = fare;
            MaxSpeed = maxSpeed;
         }
       

    }
}
