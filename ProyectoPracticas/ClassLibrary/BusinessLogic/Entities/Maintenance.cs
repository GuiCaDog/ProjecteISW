using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoScooter.Entities
{
    public partial class Maintenance
    {
        public Maintenance()
        {
            PlanningWork = new List<PlanningWork>();
        }
                                                    //el ? indica que pot prendre el valor null //el this executa el primer constructor sense parametres
        public Maintenance(String description, DateTime? endDate, int id, DateTime startDate) : this()
        {
            Description = description;
            EndDate = endDate;
            Id = id;
            StartDate = startDate;
        }
        //-------Al main haurem de pasarli una llista de PlanningWorks amb almenys 1 PW----------

        
    }
}
