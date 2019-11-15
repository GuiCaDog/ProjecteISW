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
        //Variables que usem
        List<User> userList;
        //Hay que mantener una referencia al usuario con la sesión actualmente iniciada. Se debe declarar bajo esta línea.
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
        public void UpdateEcoScooterData(double discountYounger, double fare, double maxSpeed)
        {
            ecoScooter.DiscountYounger = discountYounger;
            ecoScooter.Fare = fare;
            ecoScooter.MaxSpeed = maxSpeed;
        }

        public void removeAllData() {
            dal.Clear<Entities.EcoScooter>();
            dal.Clear<Employee>();
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
        public void saveChanges() { }
        public bool isLoggedAsUser(string dni) { return false; }

        public bool isLoggedAsEmployee(string dni) { return false; }

        public void RegisterUser(DateTime birthDate, String dni, String email, String name, int telephon, int cvv, DateTime expirationDate, string login, int number, string password)
        {
            //...
            //birthDate.Year.
            if(false)
            {
                throw new ServiceException("Datos erroneos");
            }
            User u = new User(birthDate, dni, email, name, telephon, cvv, expirationDate, login, number, password);
            dal.Insert<User>(u);
        }

        public void LoginUser(string login, string password)
        {
            userList =(List<User>) dal.GetAll<User>();
            int i = 0;
            //Busquem hasta trobar un usuari amb ixe Login
            while(i < userList.Count && !userList[i].isLogin(login)) { i++; }
            //Hem trobat un usuari amb ixe login
            if(i < userList.Count)
            {
                if (userList[i].isPassword(password)) { /*El usuari se loguea correctamet*/}
                //La contraseña era incorrecta
                else { new ServiceException("Contraseña incorrecta"); }  
            }
            //Ixe login no existix
            else { new ServiceException("El usuario no existe"); }

        }

        public void LoginEmployee(String dni, int pin)
        {
            //En este cas sí podem buscar per clau primaria (Dni)
            Employee empleat = dal.GetById<Employee>(dni);
            //Ha trobat el empleat asociat a ixe dni
            if (empleat != null)
            {
                if (empleat.isPin(pin) ){ /*El empleat se loguea correctamet*/}
                //El pin era incorrecto
                else { new ServiceException("El pin del empleado es incorrecto"); }
            }
            //No existix un empleat amb ixe dni
            else { new ServiceException("El empleado no existe"); }
        }

        public void RegisterStation(String address, Double latitude, Double longitude, String stationId)
        {
            //Station(string adress, double latitude, double longitude, string id) : this()
            Station aux = dal.GetById<Station>(stationId); //Busquem si ya existeix una estació amb ixe Id
            if (aux == null) {
                Station s = new Station(address, latitude, longitude, stationId);
                //Falta comprovar si falta informació o es incorrecta
                dal.Insert<Station>(s);
                dal.Commit();
            }
            else {
                throw new Exception("La estación ya existe");
            }



        }

        public void RegisterScooter(DateTime registerDate, ScooterState state, String stationId)
        {
            //Scooter(int id, DateTime registerDate, ScooterState state) : this()
                                //id autogenerat :(                               
            Scooter s = new Scooter(123 ,registerDate, state);           
            if (state.Equals("available"))
            {
                Station station = dal.GetById<Station>(stationId);
                if (station == null) //no existeix la estació
                {
                    throw new Exception("La estación no existe");
                }
                else
                {                                
                    dal.Insert<Scooter>(s);
                    dal.Commit();
                }
            } 
            else {
                throw new Exception("Estación no disponible");
            }


        }

        public void RentScooter(string stationId)
        {

        }
        public void ReturnScooter(string stationId)
        {

        }

        public void RegisterIncident(string description, DateTime timeStamp, int rentalId)
        {
            //Incident(string description, int id, DateTime timeStamp)
                                                 //..id..
            Incident i = new Incident(description, 123 , timeStamp);
            //2. El	sistema	actualitza	la	informació	associada	a	un	lloguer	amb incident
            Rental r = dal.GetById<Rental>(rentalId);
            //r.Incident(i);
            

            
        }


        public ICollection<String> GetUserRoutesIds(DateTime startDate, DateTime endDate)
        {
            return null;
        }

        public void GetRouteDescription(int rentalId, out DateTime startDate, out DateTime endDate, out decimal price, out int originStationId, out int destinationStationId)
        {
            startDate = new DateTime();
            endDate = new DateTime();
            price = 100;
            originStationId = 10;
            destinationStationId = 10;
        }

        public ICollection<String> GetUserRoutes(DateTime startDate, DateTime endDate)
        {
            return null;
        }
    }
}
