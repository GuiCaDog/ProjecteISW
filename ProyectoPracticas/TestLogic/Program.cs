using System;
using EcoScooter.Entities;
namespace TestLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee(new DateTime(), "DNI", "EMAIL", "NAME", 689627827, "IBAN", 1234, "POSITION", 1000);
            //RELAJAMOS PLANNINGWORK
            Maintenance m = new Maintenance("DESCRIPCION", new DateTime(), 1, new DateTime());
            //RELAJAMOS PLANNINGWORK
            Scooter s = new Scooter(0, new DateTime(), new ScooterState());
            PlanningWork pW = new PlanningWork("DESCRIPCION", m, s, 40);
            //m.addPlanningWork(pW);
            //s.addPlanningWork(pW);
            TrackPoint tP = new TrackPoint(10, 20, 30, 40, new DateTime());
            Station st = new Station("ADRESS", 10, 20, "ID");
            User u = new User(0, new DateTime(), "LOGIN", 0, "PASSWORD");
            Rental r = new Rental(new DateTime(), 0, st, 500, s, new DateTime(), u );
            Incident i = new Incident("DESCRIPTION", 0, new DateTime());
            //EcoScooter eS = new EcoScooter(0, 0, 0, e);
            Console.Write("Hola");

        }
    }
}
