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
        String usuari;
        public EcoScooterUserForm(IEcoScooterService ecoService) : base(ecoService)
        {
            InitializeComponent();

        }

        public void setNomUsuari(String s)
        {
            personLoginLabel.Text = s;
            usuari = s;
        }

        private void ButtonAlquilarPatinete(object sender, EventArgs e)
        {
            EcoScooterAlquilarPatineteForm eAP = new EcoScooterAlquilarPatineteForm(ecoService);
            eAP.setNomUsuari(usuari);
            eAP.Show();
            this.Close();
           // this.Hide();

        }

        private void ButtonDevolverPatinete(object sender, EventArgs e)
        {
            EcoScooterDevolverPatineteForm eDP = new EcoScooterDevolverPatineteForm(ecoService);
            eDP.setNomUsuari(usuari);
            eDP.Show();
            this.Close();
            // this.Hide();

        }

        private void ButtonObtenerRecorridos(object sender, EventArgs e)
        {
            EcoScooterObtenerRecorridosForm eOR = new EcoScooterObtenerRecorridosForm(ecoService);
            eOR.setNomUsuari(usuari);
            eOR.Show();
            this.Close();
            //this.Hide();
        }

        private void ButtonAtras_Click(object sender, EventArgs e)
        {
            //EcoScooterAppForm eAF = new EcoScooterAppForm(ecoService);
           // eAF.Show();
            this.Close();
        }

        private void PersonLoginLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
