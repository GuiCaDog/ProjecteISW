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
using EcoScooter.Entities;

namespace GUIEcoScotter
{
    public partial class EcoScooterAlquilarPatineteForm : EcoScooterFormAtrasAceptar
    {

        public EcoScooterAlquilarPatineteForm(IEcoScooterService ecoService) : base(ecoService)
        {
            InitializeComponent();
            //List<String> stationList = (List<String>)ecoService.GetStations();
            List<String> stationList = new List<string>();
            stationList.Add("Estació del Nord");
            stationList.Add("Estació de Valencia");
            stationList.Add("Estació de Madrid");
            Station s = new Station("direccio", "id", 40, 80);
            stationList.Add(s.ToString());

            foreach (String station in stationList)
            {
                Console.WriteLine(station);
                listViewEstaciones.Items.Add(station);
            }
                      
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void ListViewEstaciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
