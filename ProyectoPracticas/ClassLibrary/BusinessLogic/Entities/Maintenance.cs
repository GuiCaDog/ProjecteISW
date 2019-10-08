using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoScooter.Domain
{
    public partial class Maintenance
    {
        public string Description {
            get;
            set;
        }
        public DateTime EndDate {
            get;
            set;
        }

        public int Id { 
        
            get;
            set;
        }
        public DateTime StartDate { 
        
            get;
            set;
        }
    }
}
