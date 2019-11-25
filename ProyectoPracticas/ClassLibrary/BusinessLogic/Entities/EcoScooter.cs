using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoScooter.Persistence;
using EcoScooter.BusinessLogic.Services;




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
            Fare = Convert.ToDecimal(fare);
            MaxSpeed = maxSpeed;
         }



        //---------------------Casos d'us-----------------------------------------------------------


        public void RegisterUser(DateTime birthDate, String dni, String email, String name, int telephon, int cvv, DateTime expirationDate, string login, int number, string password)
        {

            User u = new User(birthDate, dni, email, name, telephon, cvv, expirationDate, login, number, password);

            //Raons per les quals ha habut error
            string reason;

            //Comprovem si la edat i la targeta estan be
            bool validated = u.validateData(out reason);

            //Si l'usuari no es unic, no hem d'afegirlo
            if (!usuariUnic(login))
            {
                validated = false;
                reason += "\n Nom d'suari ja existent";

            }
            else if (!dniValid(dni))
            {
                validated = false;
                reason += "\n DNI ja existent";
            }
            if (validated)
            {
                People.Add(u);//Tenim que fer esto?
                //dal.Insert<User>(u);//I esto tambe? Les 2 coses?
                //dal.Commit();
                //saveChanges();
            }
            else
            {
                throw new ServiceException(reason);
            }
        }

        public Person LoginUser(string login, string password, User personaLogejada)
        {
                if (personaLogejada != null) { throw new ServiceException("Usuari ja loguejat"); }
                List<User> userList = obtindreLlistaUsers();
                int i = 0;
                //Busquem hasta trobar un usuari amb ixe Login
                while (i < userList.Count && !userList[i].isLogin(login)) { i++; }
                //Hem trobat un usuari amb ixe login
                if (i < userList.Count)
                {
                    if (userList[i].isPassword(password))
                    {
                        /*El usuari se loguea correctamet. Guardem la seua referencia*/
                        return userList[i];
                    }
                    //La contraseña era incorrecta
                    else { throw new ServiceException("Contraseña incorrecta"); }
                }
                //Ixe login no existix
                else { throw new ServiceException("El usuario no existe"); }
     
            
        }

        public Person LoginEmployee(String dni, int pin, Employee personaLogejada)
        {
            //En este cas sí podem buscar per clau primaria (Dni)
            if (personaLogejada != null) { throw new ServiceException("Empleat ja loguejat"); }
            Employee empleat = findEmployeeById(dni);//Crida a findPerson i asegura que es un empleat. Si no es null.
            //Ha trobat el empleat asociat a ixe dni
            if (empleat != null)
            {
                if (empleat.isPin(pin))
                {
                    /*El empleat se loguea correctamet. Guardem la seua referencia*/
                    return empleat;
                }
                //El pin era incorrecto
                else { throw new ServiceException("El pin del empleado es incorrecto"); }
            }
            //No existix un empleat amb ixe dni
            else { throw new ServiceException("El empleado no existe"); }
        }
        public void RegisterIncident(string description, DateTime timeStamp, int rentalId, User personaLogejada)
        {
            if (personaLogejada == null)
            {
                throw new ServiceException("Usuari no identificat");
            }
            //incidentList = (List<Incident>)dal.GetAll<Incident>();  NO GASTAR
            List<Incident> incidentList = llistaIncidents();

            //Incident(string description, int id, DateTime timeStamp)
            Incident i = new Incident(description, newIncidentID(incidentList), timeStamp);
            //2. El	sistema	actualitza	la	informació	associada	a	un	lloguer	amb incident
            Rental r = findRentalByID(rentalId);//dal.GetById<Rental>(rentalId);
            r.addIncident(i);

        }

        public void RegisterStation(String address, Double latitude, Double longitude, String stationId, Employee e)
        {
            if(e == null)
            {
                throw new ServiceException("L'empleat no està loguejat!");
            }
            //Station(string adress, string id,  double latitude, double longitude) : this()
            Station aux = findStationByID(stationId); //Busquem si ya existeix una estació amb ixe Id
            if (aux == null)
            {
                Station s = new Station(address, stationId, latitude, longitude);
                //Falta comprovar si falta informació o es incorrecta
                Stations.Add(s);
                //dal.Commit();
            }
            else
            {
                throw new ServiceException("La estación ya existe");
            }



        }

        public void RegisterScooter(DateTime registerDate, ScooterState state, String stationId, Employee e)
        {
            //Scooter(int id, DateTime registerDate, ScooterState state) : this()
            //id autogenerat :(     
            if (e == null)
            {
                throw new ServiceException("L'empleat no està loguejat");
            }
            //Falta comprovar que la informacio introduida es correcta també
            Scooter s = new Scooter(registerDate, state);
            if (state.Equals(ScooterState.available))
            {
                Station station = findStationByID(stationId);
                if (station == null) //no existeix la estació
                {
                    throw new ServiceException("L'estació no existix");
                }
                else
                {
                    Scooters.Add(s);
                    //dal.Commit();
                }
            }
            else
            {
                throw new ServiceException("Estació no disponible");
            }


        }


        public void RentScooter(string stationId, User u)
        {

            //------------------Usa mètodes de Station y EcoScooter-------------------
            if (u != null)
            {
                //Station station = dal.GetById<Station>(stationId);
                Station station= this.findStationByID(stationId);

                if (station == null) //no existeix la estació
                {
                    throw new ServiceException("L'estació no existix");
                }

                if (station.availableScooter())
                {
                    Scooter s = station.retrieveScooter();
                    Rental rent = new Rental(null, Fare, DateTime.Now, station, s,  u);
                    (u).Rentals.Add(rent);
                    
                }
                else
                {
                    throw new ServiceException("No hi ha patinets disponibles a l'estació");
                }
            }
            else
            {
                throw new ServiceException("Usuari no identificat");

            }
        }

        public void ReturnScooter(string stationId, User u)
        {
            //------------------Usa mètodes de User i de Station-----------------------
            //No se si esta del tot bé, o falta algo
            if (u != null)
            {
                Station station = findStationByID(stationId);

                if (station == null) //no existeix la estació
                {
                    throw new ServiceException("L'estació no existix");
                }

                else
                {
                    //Obtenim el alquiler mes recent
                    Rental r = (u).getLastRental();
                    if (r.EndDate != null)
                    {
                        throw new ServiceException("Devolució ja efectuada");

                    }
                    //int numSerie = r.Scooter.Id; //Per a que el necessitem??
                    if (wasIncident())
                    {
                        RegisterIncident("Accident", r.StartDate, r.Id, u);
                        //Com obtenim l'hora a la qual es va produir l'incident?
                    }
                    r.EndDate = DateTime.Now;
                    decimal min = Convert.ToDecimal(r.EndDate.Value.Subtract(r.StartDate).TotalMinutes);
                    r.Price = min * Fare;
                    int edad = (u).Edad();
                    if (edad > 16 && edad < 25)
                    {
                        r.Price *= Convert.ToDecimal(0.9);
                    }
                    // r.addEndDate(DateTime.Now); ???  com usem el setter que hem definit?

                    station.returnScooter(r.Scooter);

                }

            }
            else
            {
                throw new ServiceException("Usuari no identificat");

            }
        }

        private bool wasIncident()
        {
            return true; // A implementar quan desenvolupem la capa de interficie
        }



        //-----------RegisterUserMethod--------------
        //Comprovar si l'usuari es únic
        public bool usuariUnic(string login)//, IDAL dal)
        {
            //return dal.GetById<User>(login) == null;

            // ----------------Codi auxiliar sense usar dal-----------
           bool OK = true;
           bool jaExistix = false;
            foreach(Person p in People)
            {
                if(p is User && !jaExistix)
                {
                    if(((User)p).Login.Equals(login))
                    {
                        jaExistix = true;
                        OK = false;
                        //reason += "\n Nom d'usuari ja existent";
                    }
                }
            }
            return OK;
             
             
        }

        public bool dniValid(string dni)
        {
            bool OK = true;
            bool jaExistix = false;
            foreach (Person p in People)
            {
                if (!jaExistix)
                {
                    if (p.Dni.Equals(dni))
                    {
                        jaExistix = true;
                        OK = false;
                        //reason += "\n Nom d'usuari ja existent";
                    }
                }
            }
            return OK;
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

        public List<Incident> llistaIncidents()
        {
            List<Incident> listIncident = new List<Incident>();
            foreach (Person u in People)
            {
                if (u is User)
                {
                    foreach (Rental r in ((User)u).Rentals)
                    {
                        Incident a = r.getIncident();
                        if (a != null)  { listIncident.Add(a); }
                    }
                }
            }
            return listIncident;

        }
        //Usat en RegisterIncident
        public Rental findRentalByID(int id)
        {
            foreach (Person u in People)
            {
                if (u is User) // Aço esta be?
                {
                    foreach (Rental r in ((User)u).Rentals)
                    {
                        if (r.Id.Equals(id)) { return r; }
                    }
                }
            }
            return null;
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

            List<User> res = new List<User>();

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
