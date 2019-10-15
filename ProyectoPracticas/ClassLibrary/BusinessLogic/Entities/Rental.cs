using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoScooter.Domain
{
    public partial class Rental
    {
        public DateTime EndDate
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }
            //decimal no double
        public double Price
        {
            get;
            set;
        }

        public DateTime StartDate
        {
            get;
            set;
        }

    }
}
