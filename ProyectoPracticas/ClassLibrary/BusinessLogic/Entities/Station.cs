using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoScooter.Entities
{
    public partial class Station
    {
        public Station()
        {
            DestinationRentals = new List<Rental>();
            OriginRentals = new List<Rental>();
            Scooters = new List<Scooter>();
        }
        //EXPECTED_ADDRESS, EXPECTED_ID, EXPECTED_LAT, EXPECTED_LONG
        public Station(string adress, string id, double latitude, double longitude) : this()
        {
            Address = adress;
            Latitude = latitude;
            Longitude = longitude;
            Id = id;
        }




        //-------------RentScooterMethods------------------
        public bool availableScooter()
        {
            return Scooters.Count > 0;
        }


        //Simplement agafar un Scooter de la llista
        public Scooter retrieveScooter()
        {
            Scooter s = Scooters.First();
            s.State = ScooterState.inUse;
            Scooters.Remove(s);
            return s;
        }

        public void addOriginRental(Rental r)
        {
            OriginRentals.Add(r);
        }
        //------------------------------------------------

        //Tornar un Scooter a la llista
        public void returnScooter(Scooter s, Rental r)
        {
            s.State = ScooterState.available;
            Scooters.Add(s);
            DestinationRentals.Add(r);
        }

        public override String ToString()
        {
            return "Dirección: " + Address + ". ID: " + Id + ".      (Lat.: " + Latitude + ", Long.: " + Longitude+")";
        }
    }

}
