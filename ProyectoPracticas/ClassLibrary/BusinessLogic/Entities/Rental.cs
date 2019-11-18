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

        public Rental(DateTime? endDate, int id, Station originStation, decimal price, Scooter scooter, DateTime startDate ,User user) : this()
        {
            
            EndDate = endDate;
            Id = id;
            OriginStation = originStation;
            Price = price;
            Scooter = scooter;
            StartDate = startDate;
            User = user;
        }


        //Métodes implementats per als serves
        public bool inInterval(DateTime startDate, DateTime endDate)
        {
            return (startDate.CompareTo(this.StartDate) <= 0 && endDate.CompareTo(this.EndDate) <= 0);
        }
    }
}
