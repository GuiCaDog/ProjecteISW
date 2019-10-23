﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoScooter.Entities
{
    public partial class Employee
    {
        public string Iban
        {
            get;
            set;
        }

        public int Pin
        {
            get;
            set;
        }

        public string Position
        {
            get;
            set;
        }

        public Decimal Salary
        {
            get;
            set;
        }

        /*Relaciones*/
        public virtual ICollection<Maintenance> Maintenances
        {
            get;
            set;
        }
    }
}
