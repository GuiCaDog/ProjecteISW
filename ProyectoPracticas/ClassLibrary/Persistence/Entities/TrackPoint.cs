using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace EcoScooter.Entities
{
    public partial class TrackPoint
    {
        [Key]
        public int Id
        {
            get;
            set;
        }
        public double BatteryLevel
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

        public double Speed
        {
            get;
            set;
        }

        public DateTime TimeStamp
        {
            get;
            set;
        }
    }
}
