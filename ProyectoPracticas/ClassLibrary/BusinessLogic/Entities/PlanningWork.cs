using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoScooter.Domain
{
    public partial class PlanningWork
    {
        public PlanningWork()
        {
            //no te cap llista
        }
        public PlanningWork(string description, Maintenance maintenance, Scooter scooter, int workingTime)
        {
            Description = description;
            Maintenance = maintenance;
            Scooter = scooter;
            WorkingTime = workingTime;
        }
        public string Description
        {
            get;
            set;
        }
        public int WorkingTime
        {
            get;
            set;
        }

        public virtual Maintenance Maintenance {
            get;
            set;
        }

        public virtual Scooter Scooter
        {
            get;
            set;
        }   


    }
}
