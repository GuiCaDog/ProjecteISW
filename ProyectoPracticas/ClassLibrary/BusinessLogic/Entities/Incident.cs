using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoScooter.Domain
{
    public partial class Incident
    {
        public Incident()
        {

        }
        public Incident(string description, int id, DateTime timeStamp, Rental rental)
        {
            Description = description;
            Id = id;
            TimeStamp = timeStamp;
            Rental = rental;
        }
        public string Description
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }

        public DateTime TimeStamp
        {
            get;
            set;
        }
        public Rental Rental
        {
            get;
            set;
        }

    }
}
