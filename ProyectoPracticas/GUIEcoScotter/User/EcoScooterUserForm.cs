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

    }
}
