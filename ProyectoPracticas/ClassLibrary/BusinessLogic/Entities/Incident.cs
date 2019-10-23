using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoScooter.Entities
{
    public partial class Incident
    {
        public Incident()
        {

        }
        public Incident(string description, int id, DateTime timeStamp)
        {
            Description = description;
            Id = id;
            TimeStamp = timeStamp;
        }
        


    }
}
