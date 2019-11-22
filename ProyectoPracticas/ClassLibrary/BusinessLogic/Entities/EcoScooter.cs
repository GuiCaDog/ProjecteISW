using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoScooter.Persistence;



namespace EcoScooter.Entities
{
    public partial class EcoScooter
    {
        public EcoScooter()
        {
            Employees = new List<Employee>();
            People = new List<Person>();
            Scooters = new List<Scooter>();
            Stations = new List<Station>();
        }
        public EcoScooter(double discountYounger, double fare, double maxSpeed, Employee employee) : this() 
         {
            Employees.Add(employee);
            People.Add(employee); //Nova linia afegida
            DiscountYounger = discountYounger;
            Fare = fare;
            MaxSpeed = maxSpeed;
         }



        //---------------------Casos d'us------------------------------

        public void RentScooter(string stationId, User u)
        {

            //------------------Usa mètodes de Station y EcoScooter-------------------
            if (u != null)
            {
                //Station station = dal.GetById<Station>(stationId);
                Station station= this.findStationByID(stationId);

                if (station == null) //no existeix la estació
                {
                    throw new Exception("L'estació no existix");
                }

                if (station.availableScooter())
                {
                    Scooter s = station.retrieveScooter();
                    Rental rent = new Rental(null, newRentalID(), station, 0.0, s, DateTime.Now, u);
                    (u).Rentals.Add(rent);
                    
                }
                else
                {
                    throw new Exception("No hi ha patinets disponibles a l'estació");
                }
            }
            else
            {
                throw new Exception("Usuari no identificat");

            }
        }

        //-----------RegisterUserMethod--------------
        //Comprovar si l'usuari es únic
        public bool usuariUnic(string login, IDAL dal)
        {
            return dal.GetById<User>(login) == null;

         /* ----------------Codi auxiliar sense usar dal-----------
          * bool jaExistix = false;
            foreach(Person p in People)
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
             
             */
        }


        //--------Mètode usat en RentScooter i Register Station-----------------------------
        public Station findStationByID(string id) //IDAL dal
        {
            //Usant dal: return dal.GetById<Station>(id);

            foreach (Station st in Stations)
            {
                if (st.Id.Equals(id))
                {
                    return st;
                }
            }
            return null;
        }

        //-----------------RentScooterMethods---------------------------------
        
        //---Busquem d'entre tots els rentals el de maxim id, i retornem el maxim +1
        public int newRentalID()
        {
            int maxID = -1;
            foreach (Person u in People)
            {
                if (u is User) // Aço esta be?
                {
                    foreach (Rental r in ((User) u).Rentals)
                    {
                        if (r.Id > maxID) { maxID = r.Id; }
                    }
                }
            }
            return maxID+1;
        }

        public int newScooterID()
        {
            int maxID = -1;
            foreach (Scooter u in Scooters)
            {
              if (u.Id > maxID) { maxID = u.Id; }
            }
            return maxID+1;
        }

        public int newIncidentID(List<Incident> incidents)
        {
            int maxID = -1;
            foreach (Incident u in incidents)
            {
                if (u.Id > maxID) { maxID = u.Id; }
            }
            return maxID+1;
        }
        //Usat en métode isLogged
        public Person findPersonById(string id)
        {
            //Podriem usar dal.GetById<Person>(id)

            foreach(Person p in People)
            {
                if (p.Dni.Equals(id))
                {
                    return p;
                }
            }
            return null;
        }
        //Usat en métode loginUser
        public List<User> obtindreLlistaUsers()
        {
            //Podriem fer (List<User>) dal.GetAll<User>()

            List<User> res = new List<User>;

            foreach(Person p in People)
            {
                if(p is User)
                {
                    res.Add((User)p);
                }
            }

            return res;
        }
        //Usat en métode loginEmployee
        public Employee findEmployeeById(string id)
        {
            Person p = findPersonById(id);
            if(p!=null && p is Employee) { return (Employee)p; }
            else { return null; }
        }
    }
}
