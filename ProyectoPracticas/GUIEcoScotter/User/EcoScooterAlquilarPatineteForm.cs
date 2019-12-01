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
            List<String> stationList = (List<String>)ecoService.GetStations();
           /* List<String> stationList = new List<string>();
            stationList.Add("Estació del Nord");
            stationList.Add("Estació de Valencia");
            stationList.Add("Estació de Madrid");
            Station s = new Station("direccio", "id", 40, 80);
            stationList.Add(s.ToString());*/

            foreach (String station in stationList)
            {
                Console.WriteLine(station);
                listViewEstaciones.Items.Add(station);
            }
                      
        }
        //Botó Aceptar
        protected override void Button2_Click(object sender, EventArgs e)
        {
            if (listViewEstaciones.FocusedItem == null)
            {
                throw new ServiceException("Debes de seleccionar una estación.");
            }
           
            String estacion = listViewEstaciones.FocusedItem.ToString();
            estacion = estacion.Substring(estacion.IndexOf("ID: "));
            estacion = estacion.Substring(estacion.IndexOf(" "));
            estacion = estacion.Substring(1, estacion.IndexOf("."));
            estacion = estacion.Substring(0, estacion.Length - 1); //estacion tindra el ID
            Console.WriteLine("----    ." + estacion + ".    ----------");
                
                    //No fa falta fer açò, pq ya heu fa el cas d'us RentScooter
                //Station station = ecoService.findStationByID(estacion);
                // Scooter scooter = station.retrieveScooter(); 

            ecoService.RentScooter(estacion);

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void ListViewEstaciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
