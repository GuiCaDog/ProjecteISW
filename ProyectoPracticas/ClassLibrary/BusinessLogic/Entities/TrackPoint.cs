using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoScooter.Entities
{
    public partial class TrackPoint
    {
        public TrackPoint()
        {

        }
        public TrackPoint(double batteryLevel, double latitude, double longitude, double speed, DateTime timeStamp)
        {
            BatteryLevel = batteryLevel;
            Latitude = latitude;
            Longitude = longitude;
            Speed = speed;
            TimeStamp = timeStamp;
        }
        
     
    }
}
