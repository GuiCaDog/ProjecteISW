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


        public int Id
        {
            get;
            set;
        }
        public DateTime RegisterDate
        {
            get;
            set;
        }
        public ScooterState State
        {
            get;
            set;
        }

        public virtual ICollection<PlanningWork> PlanningWork
        {
            get;
            set;
        }

        public virtual ICollection<Rental> Rentals
        {
            get;
            set;
        }

        public virtual Station Station
        {
            get;
            set;
        }

        public virtual Maintenance Maintenance
        {
            get;
            set;
        }


    }
}
