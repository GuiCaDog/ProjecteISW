using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoScooter.Entities
{
    public partial class PlanningWork
    {
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

        public virtual Maintenance Maintenance
        {
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
