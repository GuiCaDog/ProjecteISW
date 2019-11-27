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
    public partial class Prova : Form
    {
        private IEcoScooterService ecoService;

        public Prova(IEcoScooterService ecoService)
        {
            InitializeComponent();
            this.ecoService = ecoService;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            http://www.upv.es
        }
    }
}
