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

        void removeAllData() { }
        void saveChanges() { }
        bool isLoggedAsUser(string dni) { return false; }

        bool isLoggedAsEmployee(string dni) { return false; }

        void RegisterUser(DateTime birthDate, String dni, String email, String name, int telephon, int cvv, DateTime expirationDate, string login, int number, string password)
        {

        }

        void LoginUser(string login, string password)
        {

        }

        void LoginEmployee(String dni, int pin)
        {

        }

        void RegisterStation(String address, Double latitude, Double longitude, String stationId)
        {

        }

        void RegisterScooter(DateTime registerDate, ScooterState state, String stationId)
        {

        }

        void RentScooter(string stationId)
        {

        }
        void ReturnScooter(string stationId)
        {

        }

        void RegisterIncident(string description, DateTime timeStamp, int rentalId)
        {

        }


        ICollection<String> GetUserRoutesIds(DateTime startDate, DateTime endDate)
        {
            return null;
        }

        void GetRouteDescription(int rentalId, out DateTime startDate, out DateTime endDate, out decimal price, out int originStationId, out int destinationStationId)
        {
            startDate = new DateTime();
            endDate = new DateTime();
            price = 100;
            originStationId = 10;
            destinationStationId = 10;
        }

        ICollection<String> GetUserRoutes(DateTime startDate, DateTime endDate)
        {
            return null;
        }
    }
}
