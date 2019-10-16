﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoScooter.Domain
{
    public partial class Station
    {
        public Station()
        {
            
        }
        public Station(string adress, double latitude, double longitude, string id)
        {
            Address = adress;
            Latitude = latitude;
            Longitude = longitude;
            Id = id;
        }
        public string Address
        {
            get;
            set;
        }

        public string Id
        {
            get;
            set;
        }

        public double Latitude
        {
            get;
            set;
        }

        public double Longitude
        {
            get;
            set;
        }
        public virtual ICollection<Rental> DestinationRentals
        {
            get;
            set;
        }
        public virtual ICollection<Rental> OriginRentals
        {
            get;
            set;
        }
        public virtual ICollection<Scooter> Scooters
        {
            get;
            set;
        }
    }
}
