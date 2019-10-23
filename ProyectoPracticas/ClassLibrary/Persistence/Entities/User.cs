using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoScooter.Entities
{
    public partial class User
    {
        public int Cw
        {
            get;
            set;
        }
        public DateTime ExpirationDate
        {
            get;
            set;
        }

        public string Login
        {
            get;
            set;
        }

        public int Number
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }

        public virtual ICollection<Rental> Rentals
        {
            get;
            set;
        }
    }
}
