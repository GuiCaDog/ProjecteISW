using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoScooter.Entities
{
    public partial class Rental
    {
        public Rental()
        {
            TrackPoints = new List<TrackPoint>();
        }

        public Rental(DateTime? endDate, int id, Station originStation, int price, Scooter scooter, DateTime startDate ,User user) : this()
        {
            
            EndDate = endDate;
            Id = id;
            OriginStation = originStation;
            Price = price;
            Scooter = scooter;
            StartDate = startDate;
            User = user;
        }

    }
}
