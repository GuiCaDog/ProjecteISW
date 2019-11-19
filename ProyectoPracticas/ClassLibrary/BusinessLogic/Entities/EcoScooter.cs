﻿using System;
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
        public Station findByID(string id) //IDAL dal
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

    }
}
