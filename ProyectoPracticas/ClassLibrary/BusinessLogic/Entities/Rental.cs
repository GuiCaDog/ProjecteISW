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
                                                                                                                            
        public Rental(DateTime? endDate, int id, Station originStation, double price, Scooter scooter, DateTime startDate ,User user) : this()
        {
            
            EndDate = endDate;
            Id = id;
            OriginStation = originStation;
            Price = price;
            Scooter = scooter;
            StartDate = startDate;
            User = user;

            //Afegit incident
            Incident = null;
        }


        //Métodes implementats per als serveis
        public bool inInterval(DateTime startDate, DateTime endDate)
        {
            return (startDate.CompareTo(this.StartDate) <= 0 && endDate.CompareTo(this.EndDate) <= 0);
        }

        public void addEndDate(DateTime end)
        {
            EndDate = end;
        }

        public void addIncident(Incident i)
        {
            Incident = i;
        }

        public Incident getIncident()
        {
            return Incident;
        }

        ////Usat en GetUserRoutes
        //public String getDescripcio()
        //{
        //    return this.StartDate + ", " + this.EndDate + ", " + this.Price
        //                + ", " + this.OriginStation + ", " + this.DestinationStation;
        //}
        //Usat en getRentalById de User
        public bool isId(int id)
        {
            return this.Id == id;
        }
    }
}
