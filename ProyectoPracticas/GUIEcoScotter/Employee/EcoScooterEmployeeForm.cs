using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EcoScooter.BusinessLogic.Services;

namespace GUIEcoScotter
{
    public partial class EcoScooterEmployeeForm : EcoScooterFormBase
    {

        public EcoScooterEmployeeForm(IEcoScooterService ecoService) : base(ecoService)
        {
            InitializeComponent();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            EcoScooterRegistrarEstacionForm eRE = new EcoScooterRegistrarEstacionForm(ecoService);
            eRE.Show();
            this.Close();
            //this.Hide();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            EcoScooterRegistrarPatineteForm eRP = new EcoScooterRegistrarPatineteForm(ecoService);
            eRP.Show();
            this.Close();
            //this.Hide();
        }

        private void ButtonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
