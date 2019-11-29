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
    public partial class EcoScooterUserForm : EcoScooterFormBase
    {

        public EcoScooterUserForm(IEcoScooterService ecoService) : base(ecoService)
        {
            InitializeComponent();

        }


        private void Button1_Click(object sender, EventArgs e)
        {
            EcoScooterAlquilarPatineteForm eAP = new EcoScooterAlquilarPatineteForm(ecoService);
            eAP.Show();
            //this.Hide();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            EcoScooterDevolverPatineteForm eDP = new EcoScooterDevolverPatineteForm(ecoService);
            eDP.Show();
           // this.Hide();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            EcoScooterObtenerRecorridosForm eOR = new EcoScooterObtenerRecorridosForm(ecoService);
            eOR.Show();
           // this.Hide();

        }
    }
}
