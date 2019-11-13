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

        public void removeAllData() { }
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

        }

        public void LoginEmployee(String dni, int pin)
        {

        }

        public void RegisterStation(String address, Double latitude, Double longitude, String stationId)
        {

        }

        public void RegisterScooter(DateTime registerDate, ScooterState state, String stationId)
        {

        }

        public void RentScooter(string stationId)
        {

        }
        public void ReturnScooter(string stationId)
        {

        }

        public void RegisterIncident(string description, DateTime timeStamp, int rentalId)
        {

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
