using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoScooter.Entities
{

    public partial class Scooter
    {
        public Scooter() {
            Rentals = new List<Rental>();
            PlanningWork = new List<PlanningWork>();
        }

        public Scooter(int id, DateTime registerDate, ScooterState state) : this()
{
           Id = id;
           RegisterDate = registerDate;
           State = state;
        }


        


    }
}
