using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoScooter.Entities
{
    public partial class User:Person
    {
        public User(DateTime birthDate, string dni, string email, string name, int telephon) : base()
        {
                Rentals = new List<Rental>();
        }

        public User(DateTime birthDate, string dni, string email, string name, int telephon,int cw, DateTime expirationDate, string login, int number, string password):base(birthDate,dni, email, name, telephon)
        {
            
            Cw = cw;
            ExpirationDate = expirationDate;
            Number = number;
            Password = password;

            Rentals = new List<Rental>();

        }
        //Metodes usats per a implementar serveis
        //Donat un login diu si coincidix en el del usuari
        public Boolean isLogin(String login)
        {
            return this.Login == login;
        }
        //Donat una contraseña diu si coincidix en la del usuari
        public Boolean isPassword(String password)
        {
            return this.Password == password;
        }


    }
}
