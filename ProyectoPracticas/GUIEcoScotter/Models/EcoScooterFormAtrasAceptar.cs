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

    public partial class EcoScooterFormAtrasAceptar : EcoScooterFormBase
    {
        private IEcoScooterService ecoService;

        public EcoScooterFormAtrasAceptar()
        {
            InitializeComponent();
        }
        public EcoScooterFormAtrasAceptar(IEcoScooterService ecoService) : this() {
            this.ecoService = ecoService;
        }

        private void EcoScooterFormBase_Load(object sender, EventArgs e)
        {

        }

        protected virtual void Button1_Click(object sender, EventArgs e)
        {
        }

        protected virtual void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
