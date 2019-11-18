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

        public bool validateData(out string reason, EcoScooter eS)
        {
            reason = "error";
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
                reason += "\n Numero de targeta incorrecto";
            }
            //Ja existix ixe usuari?    
            bool jaExistix = false;
            foreach(Person p in eS.People)
            {
                if(p is User && !jaExistix)
                {
                    if(((User)p).Login.Equals(Login))
                    {
                        jaExistix = true;
                        OK = false;
                        reason += "\n Nom d'usuari ja existent";
                    }
                }
            }
            return true;
        }


    }
}
