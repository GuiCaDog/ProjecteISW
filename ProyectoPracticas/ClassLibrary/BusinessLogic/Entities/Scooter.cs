using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoScooter.Domain
{

    public partial class Scooter
    {
        public int Id
        {
            get;
            set;
        }
        public DateTime Register
        {
            get;
            set;
        }
        public ScooterState State
        {
            get;
            set;
        }
    }
}
