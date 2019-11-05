using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EcoScooter.Entities
{
    public partial class Rental
    {
        public DateTime? EndDate
        {
            get;
            set;
        }

        [Key]
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

        [InverseProperty("Rentals")]
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


        [InverseProperty("DestinationRentals")]
        public virtual Station DestinationStation
        {
            get;
            set;
        }

        [InverseProperty("OriginRentals")]
        public virtual Station OriginStation
        {
            get;
            set;
        }

        [InverseProperty("Rentals")]
        public virtual Scooter Scooter
        {
            get;
            set;
        }
    }
}
