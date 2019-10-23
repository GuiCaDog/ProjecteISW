using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoScooter.Entities
{
    public partial class Rental
    {
        public DateTime? EndDate
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }

        public Decimal Price
        {
            get;
            set;
        }

        public DateTime StartDate
        {
            get;
            set;
        }

        public virtual User User
        {
            get;
            set;
        }
        public virtual Incident Incident
        {
            get;
            set;
        }
        public virtual ICollection<TrackPoint> TrackPoints
        {
            get;
            set;
        }
        public virtual Station DestinationStation
        {
            get;
            set;
        }
        public virtual Station OriginStation
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
