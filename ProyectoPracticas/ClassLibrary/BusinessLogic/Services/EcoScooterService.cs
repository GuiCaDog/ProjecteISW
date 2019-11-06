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
        public EcoScooterService(IDAL dal)
        {
            this.dal = dal;
        }

        public void removeAllData()
        {

        }
    }
}
