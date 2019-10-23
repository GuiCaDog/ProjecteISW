using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoScooter.Entities
{
    public partial class User
    {
        public User()
        {
                Rentals = new List<Rental>();
        }

        public User(int cw, DateTime expirationDate, string login, int number, string password) : this()
        {
            Cw = cw;
            ExpirationDate = expirationDate;
            Number = number;
            Password = password;

        }
        
        
    }
}
