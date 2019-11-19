﻿using System;
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
        //------------------------------------------------

        //Tornar un Scooter a la llista
        public void returnScooter(Scooter s)
        {
            s.State = ScooterState.available;
            Scooters.Add(s);
        }
    }

}
