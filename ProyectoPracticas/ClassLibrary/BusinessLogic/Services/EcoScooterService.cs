using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoScooter.Entities;
using EcoScooter.Persistence;
using EcoScooter.BusinessLogic.Services;

namespace EcoScooter.BusinessLogic.Services
{
    public class EcoScooterService : IEcoScooterService
    {
        private readonly IDAL dal; 
        private EcoScooter.Entities.EcoScooter ecoScooter;

        //Variables que usem-------------------------
        //private List<User> userList;
        //private List<Incident> incidentList;
        //Hay que mantener una referencia al usuario con la sesión actualmente iniciada. Se debe declarar bajo esta línea.
        private Person personaLogejada; //Quan fa login ens guardem la seua referencia
                                        //--------------------------------------------

        public EcoScooterService(IDAL dal)
        {
            this.dal = dal;
            try
            {
                ecoScooter = dal.GetAll<EcoScooter.Entities.EcoScooter>().First();
            }
            catch (InvalidOperationException)
            {
                ecoScooter = new Entities.EcoScooter();
                UpdateEcoScooterData(10, 15, 30); //15 en lugar de 0.015 para una simulación más conveniente.
                dal.Insert<EcoScooter.Entities.EcoScooter>(ecoScooter);
                dal.Commit();
            }
        }
        public void UpdateEcoScooterData(double discountYounger, decimal fare, double maxSpeed)
        {
            ecoScooter.DiscountYounger = discountYounger;
            ecoScooter.Fare = fare;
            ecoScooter.MaxSpeed = maxSpeed;
        }

        public void removeAllData() {
            dal.Clear<Entities.EcoScooter>();
            dal.Clear<Employee>();
            dal.Clear<Maintenance>();
            dal.Clear<Incident>();
            dal.Clear<Person>();
            dal.Clear<PlanningWork>();
            dal.Clear<Rental>();
            dal.Clear<Scooter>();
            dal.Clear<Station>();
            dal.Clear<TrackPoint>();
            dal.Clear<User>();
            dal.Commit();
        }
        public void saveChanges() {
            dal.Commit();
        }
        public bool isLoggedAsUser(string dni) {
            return ecoScooter.isLogged(dni, "usuari",personaLogejada);
        }

        public bool isLoggedAsEmployee(string dni) {
            return ecoScooter.isLogged(dni, "empleat",personaLogejada);
        }

        //He fet un métode per reutiliçar codi
        //private bool isLogged(string dni, string type)
        //{
        //    Person personaBuscada = ecoScooter.findPersonById(dni);
        //    if (personaBuscada == null)
        //    {
        //        throw new ServiceException("El dni del " +type+" es incorrecte");
        //    }
        //    return personaBuscada.Equals(personaLogejada);
        //}


        //------------------Usa mètodes de User y EcoScooter-------------------
        public void RegisterUser(DateTime birthDate, String dni, String email, String name, int telephon, int cvv, DateTime expirationDate, string login, int number, string password)
        {

            ecoScooter.RegisterUser(birthDate, dni, email, name, telephon, cvv, expirationDate, login, number, password);
            saveChanges();


            //User u = new User(birthDate, dni, email, name, telephon, cvv, expirationDate, login, number, password);
            
            ////Raons per les quals ha habut error
            //string reason;

            ////Comprovem si la edat i la targeta estan be
            //bool validated = u.validateData(out reason);
            
            ////Si l'usuari no es unic, no hem d'afegirlo
            //if (!ecoScooter.usuariUnic(login,dal))
            //{
            //    validated = false;
            //    reason += "\n Nom d'suari ja existent";
                
            //}
            //if (validated)
            //{
            //    ecoScooter.People.Add(u);//Tenim que fer esto?
            //    //dal.Insert<User>(u);//I esto tambe? Les 2 coses?
            //    //dal.Commit();
            //    saveChanges();
            //}
            //else
            //{
            //    throw new ServiceException(reason);
            //}
        }

        public void addEmployee(DateTime birthDate, String dni, String email, String name, int telephon, String iban, int pin, String position, Decimal salary)
        {
            //ecoScooter.Employees.Clear();
            Employee e = new Employee(birthDate, dni, email, name, telephon, iban, pin, position, salary);
            ecoScooter.People.Add(e);
            saveChanges();
        }
        public void clearEmployees()
        {
            ecoScooter.Employees.Clear();
        }
        //No se si moure part a ecoscooter.
        public void LoginUser(string login, string password)
        {
            
            personaLogejada = ecoScooter.LoginUser(login, password, personaLogejada);
            
            saveChanges();


            //userList =ecoScooter.obtindreLlistaUsers();
            //int i = 0;
            ////Busquem hasta trobar un usuari amb ixe Login
            //while(i < userList.Count && !userList[i].isLogin(login)) { i++; }
            ////Hem trobat un usuari amb ixe login
            //if(i < userList.Count)
            //{
            //    if (userList[i].isPassword(password)) {
            //        /*El usuari se loguea correctamet. Guardem la seua referencia*/
            //        personaLogejada = userList[i];
            //    }
            //    //La contraseña era incorrecta
            //    else { throw new ServiceException("Contraseña incorrecta"); }  
            //}
            ////Ixe login no existix
            //else { throw new ServiceException("El usuario no existe"); }

        }

        public void LoginEmployee(String dni, int pin)
        {
            
            personaLogejada = ecoScooter.LoginEmployee(dni, pin, personaLogejada);
            
            //saveChanges();

            ////En este cas sí podem buscar per clau primaria (Dni)
            //Employee empleat = ecoScooter.findEmployeeById(dni);//Crida a findPerson i asegura que es un empleat. Si no es null.
            ////Ha trobat el empleat asociat a ixe dni
            //if (empleat != null)
            //{
            //    if (empleat.isPin(pin) ){
            //        /*El empleat se loguea correctamet. Guardem la seua referencia*/
            //        personaLogejada = empleat;
            //    }
            //    //El pin era incorrecto
            //    else { throw new ServiceException("El pin del empleado es incorrecto"); }
            //}
            ////No existix un empleat amb ixe dni
            //else {throw new ServiceException("El empleado no existe"); }
        }

        public void RegisterStation(String address, Double latitude, Double longitude, String stationId)
        {

            ecoScooter.RegisterStation(address, latitude, longitude, stationId, (Employee)personaLogejada);
            saveChanges();

            ////Station(string adress, string id,  double latitude, double longitude) : this()
            //Station aux = dal.GetById<Station>(stationId); //Busquem si ya existeix una estació amb ixe Id
            //if (aux == null) {
            //    Station s = new Station(address, latitude, longitude, stationId);
            //    //Falta comprovar si falta informació o es incorrecta
            //    dal.Insert<Station>(s);
            //    //dal.Commit();
            //}
            //else {
            //    throw new Exception("La estación ya existe");
            //}



        }

        public void RegisterScooter(DateTime registerDate, ScooterState state, String stationId)
        {

            ecoScooter.RegisterScooter(registerDate, state, stationId, (Employee) personaLogejada);
            saveChanges();

            ////Scooter(int id, DateTime registerDate, ScooterState state) : this()
            //                    //id autogenerat :(                               
            //Scooter s = new Scooter(ecoScooter.newScooterID() ,registerDate, state);           
            //if (state.Equals(ScooterState.available))
            //{
            //    Station station = ecoScooter.findStationByID(stationId);
            //    if (station == null) //no existeix la estació
            //    {
            //        throw new Exception("L'estació no existix");
            //    }
            //    else
            //    {                                                  
            //        ecoScooter.Scooters.Add(s);
            //        //dal.Commit();
            //    }
            //} 
            //else {
            //    throw new Exception("Estació no disponible");
            //}


        }

        public void RentScooter(string stationId)
        {
            ecoScooter.RentScooter(stationId,(User) personaLogejada);
            saveChanges();
            //------------------Usa mètodes de Station y EcoScooter-------------------
            //if (personaLogejada != null)
            //{
            //    Station station = dal.GetById<Station>(stationId);
            //    Station station2 = ecoScooter.findStationByID(stationId); 
                
            //    if (station == null) //no existeix la estació
            //    {
            //        throw new Exception("L'estació no existix");
            //    }

            //    if(station.availableScooter())
            //    {
            //        Scooter s = station.retrieveScooter();
            //        Rental rent = new Rental(null, ecoScooter.newRentalID(), station, ecoScooter.Fare,s,DateTime.Now,(User)personaLogejada);
            //        ((User)personaLogejada).Rentals.Add(rent);
            //        saveChanges();
            //    }
            //    else
            //    {
            //        throw new Exception("No hi ha patinets disponibles a l'estació");
            //    }
            //}
            //else
            //{
            //    throw new Exception("Usuari no identificat");

            //}
        }

        
        public void ReturnScooter(string stationId)
        {

            ecoScooter.ReturnScooter(stationId, (User) personaLogejada);
            saveChanges();


            //--------------------METODE DELEGANT EN ECOSCOOOTER--------------------------------

            ////------------------Usa mètodes de User i de Station-----------------------
            ////No se si esta del tot bé, o falta algo
            //if (personaLogejada != null)
            //{
            //    Station station = ecoScooter.findStationByID(stationId);

            //    if (station == null) //no existeix la estació
            //    {
            //        throw new Exception("L'estació no existix");
            //    }

            //    else
            //    {
            //        //Obtenim el alquiler mes recent
            //        Rental r = ((User)personaLogejada).getLastRental();
            //        if(r.EndDate != null)
            //        {
            //            throw new Exception("Devolució ja efectuada");

            //        }
            //        //int numSerie = r.Scooter.Id; //Per a que el necessitem??
            //        if(wasIncident())
            //        {
            //            RegisterIncident("Accident", r.StartDate, r.Id); 
            //            //Com obtenim l'hora a la qual es va produir l'incident?
            //        }
            //        r.EndDate = DateTime.Now;
            //        double min = r.EndDate.Value.Subtract(r.StartDate).TotalMinutes;
            //        r.Price = min * ecoScooter.Fare;
            //        int edad = ((User)personaLogejada).Edad();
            //        if (edad > 16 && edad < 25)
            //        {
            //            r.Price *= 0.9;
            //        }
            //        // r.addEndDate(DateTime.Now); ???  com usem el setter que hem definit?

            //        station.returnScooter(r.Scooter);
                    
            //    }

            //}
            //else
            //{
            //    throw new Exception("Usuari no identificat");

            //}
        }

        //private bool wasIncident()
        //{
        //    return true; // A implementar quan desenvolupem la capa de interficie
        //}

        public void RegisterIncident(string description, DateTime timeStamp, int rentalId)
        {
            
            ecoScooter.RegisterIncident(description, timeStamp, rentalId, (User) personaLogejada);
            saveChanges();

            ////-------------------Versio sense delegar a ecoScooter-------------------------------------
            ///
            ////incidentList = (List<Incident>)dal.GetAll<Incident>();  NO GASTAR
            //incidentList = ecoScooter.llistaIncidents();

            //                //Incident(string description, int id, DateTime timeStamp)
            //Incident i = new Incident(description, ecoScooter.newIncidentID(incidentList) , timeStamp);
            ////2. El	sistema	actualitza	la	informació	associada	a	un	lloguer	amb incident
            //Rental r = dal.GetById<Rental>(rentalId);
            //r.addIncident(i);
            //dal.Insert<Rental>(r);
            //dal.Commit()

            //---------------------------------------------------------------------------------------------

        }

        public void wasIncident(string description, DateTime timeStam)
        {
            ecoScooter.wasIncident(description, timeStam);
        }

        public ICollection<String> GetUserRoutes(DateTime startDate, DateTime endDate)
        {
            return ecoScooter.GetUserRoutes(startDate, endDate, (User) personaLogejada);
            //List<String> ids = (List<String>)GetUserRoutesIds(startDate, endDate);
            //List<String> res = new List<String>();
            //DateTime tStartDate = new DateTime();
            //DateTime tEndDate = new DateTime();
            //decimal tPrice;
            //String tOriginStationId;
            //String tDestinationStationId;
            //foreach(String id in ids)
            //{
            //    GetRouteDescription(int.Parse(id), out tStartDate, out tEndDate, out tPrice, out tOriginStationId, out tDestinationStationId);
            //    res.Add(tStartDate + ", " + tEndDate + ", " + tPrice + ", " + tOriginStationId + ", " + tDestinationStationId);
            //}
            //return res;
        }
        //rentalId.Id, out DateTime startDate, out DateTime endDate, out decimal price, out String originStationId, out String destinationStationId);
        public void GetRouteDescription(int rentalId, out DateTime startDate, out DateTime endDate, out decimal price, out String originStationId, out String destinationStationId)
        {
            ecoScooter.GetRouteDescription(rentalId, out startDate, out endDate, out price, out originStationId, out destinationStationId, (User)personaLogejada);
            //if(personaLogejada == null)
            //{
            //    throw new ServiceException("Usuari no identificat");
            //}
            ////Pre: es usuario y esta logueado
            //Rental r = (Rental)((User)personaLogejada).findRentalById(rentalId);
            //if (r != null)
            //{
            //    startDate = r.StartDate;
            //    endDate = (DateTime)(r.EndDate);
            //    price = (decimal)r.Price;
            //    // originStationId = int.Parse(r.OriginStation.Id);
            //    // destinationStationId = int.Parse(r.DestinationStation.Id);
            //    originStationId = r.OriginStation.Id;
            //    destinationStationId = r.DestinationStation.Id;

            //}
            //else { throw new ServiceException("No existix ixe id de Rental per a ixe usuari"); }
        }
        

        public ICollection<String> GetUserRoutesIds(DateTime startDate, DateTime endDate)
        {
            return ecoScooter.GetUserRoutesIds(startDate, endDate, (User)personaLogejada);
            //if (personaLogejada == null)
            //{
            //    throw new ServiceException("Usuari no identificat");
            //}

            ////En la precondició ya comprobem que el usuari está logueat y es un usuari (podem downcastear)
            ////Si la data inicial es major que la final, ja ni seguim
            //if (startDate.CompareTo(endDate) > 0) { throw new ServiceException("El intervalo es incorrecte"); }
            ////Guardem els rentals de ixe usuari
            //List<Rental> llistaRentals = (List<Rental>)((User)personaLogejada).Rentals;
            //List<String> descripcions = new List<String>();
            //foreach (Rental r in llistaRentals)
            //{
            //    //Usem un métode implementat en Rentals que torna true si esta entre ixes dates
            //    if (r.inInterval(startDate, endDate))
            //    {
            //        descripcions.Add(r.Id + "");
            //    }
            //}
            ////Si no hem trobat ninguna ruta
            //if (descripcions.Count == 0) { throw new ServiceException("No hi han rutes en ixe interval"); }
            
            //return descripcions;
        }
        //IMPLEMENTACIÓ ANTIGA
        //public void GetRouteDescription(int rentalId, out DateTime startDate, out DateTime endDate, out decimal price, out int originStationId, out int destinationStationId)
        //{
        //    //Pre: es usuario y esta logueado
        //    Rental r = (Rental)((User)personaLogejada).findRentalById(rentalId);
        //    if (r != null)
        //    {
        //        startDate = r.StartDate;
        //        endDate = (DateTime)(r.EndDate);
        //        price = (decimal)r.Price;
        //        originStationId = int.Parse(r.OriginStation.Id);
        //        destinationStationId = int.Parse(r.DestinationStation.Id);
        //    }
        //    else { throw new ServiceException("No existix ixe id de Rental per a ixe usuari"); }
        //}
        ////No se si moure algo a ecoscooter

        //public ICollection<String> GetUserRoutesIds(DateTime startDate, DateTime endDate)
        //{
        //    return obtindreInfoDeRentalsUser(startDate, endDate, 1);//Amb 1 colocará en el List els Ids dels rentals
        //}

        //public ICollection<String> GetUserRoutes(DateTime startDate, DateTime endDate)
        //{
        //    return obtindreInfoDeRentalsUser(startDate, endDate, 0);//Amb 0 colocará en el List descripcions
        //}
        ////Métode per reutilizar codi. Si x == 0, coloca descripcions. Si x == 1, coloca la id del rental
        //private ICollection<String> obtindreInfoDeRentalsUser(DateTime startDate, DateTime endDate, int x)
        //{
        //    //En la precondició ya comprobem que el usuari está logueat y es un usuari (podem downcastear)
        //    //Si la data inicial es major que la final, ja ni seguim
        //    if (startDate.CompareTo(endDate) > 0) { throw new ServiceException("El intervalo es incorrecte"); }
        //    //Guardem els rentals de ixe usuari
        //    List<Rental> llistaRentals = (List<Rental>)((User)personaLogejada).Rentals;
        //    List<String> descripcions = new List<String>();
        //    foreach (Rental r in llistaRentals)
        //    {
        //        //Usem un métode implementat en Rentals que torna true si esta entre ixes dates
        //        if (r.inInterval(startDate, endDate))
        //        {
        //            //El métode getDescripcio ja ens formateja el String
        //            if (x == 0){descripcions.Add(r.getDescripcio());}
        //            else if(x == 1) { descripcions.Add(r.Id+""); }
        //        }
        //    }
        //    //Si no hem trobat ninguna ruta
        //    if (descripcions.Count == 0) { throw new ServiceException("No hi han rutes en ixe interval"); }
        //    return descripcions;
        //}


        public ICollection<String> GetStations() {
            return ecoScooter.GetStations();
        }

        public List<Incident> GetIncidents() {      
            return ecoScooter.llistaIncidents();
        }
        public int newIncidentID(List<Incident> incidents)
        {
            return ecoScooter.newIncidentID(incidents);
        }

         public Station findStationByID(string id)
        {
            return ecoScooter.findStationByID(id);
        }

        public void desconectar()
        {
            personaLogejada = null;
        }

        public bool scooterPendiente()
        {
            
            return ecoScooter.scooterPendiente((User)personaLogejada);
        }
    }
}
