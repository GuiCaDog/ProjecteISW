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
            Login = login;
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


        //----------MÈTODE USAT EN RegisterUser-----------------------------------------------
        public bool validateData(out string reason)
        {
            reason = "Error";
            bool OK = true;
            //Comprovar si es major de 16 anys
            if(Birthdate.CompareTo(DateTime.Now.AddYears(-16)) > 0) { 
                OK = false;
                reason += "\n Usuari menor de 16 anys";
            }
            //Comprovar si la targeta es vàlida(te 8 posicions)
            if(Number.ToString().Length != 8 || Cw == null)
            {
                OK = false;
                reason += "\n Targeta incorrecta";
            }
            //Ja existix ixe usuari?    
            //S'ha fet en ecoScooter perque ahi es on esta la llista de Persones
            return OK;
        }

        //-----------ReturnScooterMethods----------------
        public Rental getLastRental()
        {
            Rental res = null;
            DateTime last = DateTime.Now;
            last.AddYears(-2000);
            foreach(Rental r in Rentals)
            {
                //Si r es posterior a last
                if(r.StartDate.CompareTo(last) > 0)
                {
                    last = r.StartDate;
                    res = r;
                }
            }
            return res;
        }
        //Usat en el métode getRouteDescription
        public Rental findRentalById(int id)
        {
            foreach(Rental r in Rentals)
            {
                if (r.isId(id))
                {
                    return r;
                }
            }
            return null;
        }

        public int Edad()
        {
            // Save today's date.
            DateTime today = DateTime.Today;
            // Calculate the age.
            int age = today.Year - Birthdate.Year;
            // Go back to the year the person was born in case of a leap year
            if (Birthdate.Date > today.AddYears(-age)) age--;

            return age;
        }
    }
}
