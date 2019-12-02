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
            //List<String> stationList = new List<string>();
            //stationList.Add("Estació del Nord");
            //stationList.Add("Estació de Valencia");
            //stationList.Add("Estació de Madrid");
            //Station s = new Station("direccio", "id", 40, 80);
            //stationList.Add(s.ToString());

            List<String> stationList = (List<String>)ecoService.GetStations();
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
        protected override void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewEstaciones.FocusedItem == null)
                {
                    throw new ServiceException("Debes de seleccionar una estación.");
                }

                String estacion = listViewEstaciones.FocusedItem.ToString();
                Console.WriteLine(estacion + "\n");
                estacion = estacion.Substring(estacion.IndexOf("ID: "));
                Console.WriteLine(estacion + "\n");
                estacion = estacion.Substring(4, estacion.IndexOf(".")-4);
                Console.WriteLine(estacion + "\n");
            

            
                    ecoService.RentScooter(estacion);
                    Close();
                }
            catch(ServiceException ex)
            {
                textError.Text = ex.Message;
            }
            
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
