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
        public Station(string adress, double latitude, double longitude, string id) : this()
        {
            Address = adress;
            Latitude = latitude;
            Longitude = longitude;
            Id = id;
        }

        //--------Mètode usat en RentScooter i Register Station-----------------------------
        public static Station findByID(string id, EcoScooter eS)
        {
            foreach (Station st in eS.Stations)
            {
                if (st.Id.Equals(id))
                {
                    return st;
                }
            }
            return null;
        }


        //--------Mètode usat en RentScooter-----------------------------
        public bool availableScooter()
        {
            return Scooters.Count <= 0;
        }

        //--------Mètode usat en RentScooter-----------------------------
        public Scooter retrieveScooter(EcoScooter eS)
        {
            Scooter s = eS.Scooters.First();
            eS.Scooters.Remove(s);
            return s;
        }

    }

}
