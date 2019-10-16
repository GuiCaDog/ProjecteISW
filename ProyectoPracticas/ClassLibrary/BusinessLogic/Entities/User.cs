using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoScooter.Domain
{
    public partial class User
    {
        public User()
        {

        }

        public User(int cw, DateTime expirationDate, string login, int number, string password)
        {
            Cw = cw;
            ExpirationDate = expirationDate;
            Number = number;
            Password = password;

        }
        
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
