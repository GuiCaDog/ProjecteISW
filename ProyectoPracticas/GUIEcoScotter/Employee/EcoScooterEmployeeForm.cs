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
        String usuari;
        public EcoScooterEmployeeForm(IEcoScooterService ecoService) : base(ecoService)
        {
            InitializeComponent();

        }

        public void setNomUsuari(String s)
        {
            personLoginLabel.Text = s;
            usuari = s;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            EcoScooterRegistrarEstacionForm eRE = new EcoScooterRegistrarEstacionForm(ecoService);
            eRE.setNomUsuari(usuari);
            
            eRE.Show();
            this.Close();
            //this.Hide();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            EcoScooterRegistrarPatineteForm eRP = new EcoScooterRegistrarPatineteForm(ecoService);
            eRP.setNomUsuari(usuari);
            
            eRP.Show();
            this.Close();
            //this.Hide();
        }

        private void ButtonAtras_Click(object sender, EventArgs e)
        {
            EcoScooterAppForm eAF = new EcoScooterAppForm(ecoService);
            eAF.Show();
            ecoService.desconectar();
            this.Close();
        }
    }
}
