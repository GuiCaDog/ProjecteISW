using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoScooter.Domain
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
                //decimal no double
        public double Salary
        {
            get;
            set;
        }
    }
}
