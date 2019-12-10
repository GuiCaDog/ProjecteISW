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

    public partial class EcoScooterFormBase : Form
    {
        protected IEcoScooterService ecoService;

        public EcoScooterFormBase()
        {
            InitializeComponent();
        }
        public EcoScooterFormBase(IEcoScooterService ecoService) : this()
        {
            this.ecoService = ecoService;
        }

        private void EcoScooterFormBase_Load(object sender, EventArgs e)
        {

        }
    }
}
