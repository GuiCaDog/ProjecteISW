using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace EcoScooter.Entities
{
    public partial class PlanningWork
    {
        [Key]
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

        [InverseProperty("PlanningWork")]
        public virtual Maintenance Maintenance
        {
            get;
            set;
        }

        [InverseProperty("PlanningWork")]
        public virtual Scooter Scooter
        {
            get;
            set;
        }
    }
}
