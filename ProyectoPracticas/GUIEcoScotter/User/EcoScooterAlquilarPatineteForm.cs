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
            String dir, id, coords,station2;
            List<String> stationList = (List<String>)ecoService.GetStations();
            foreach (String station in stationList)
            {
                Console.WriteLine(station);
                dir = station.Substring(10, station.IndexOf(".") - 10);
                station2 = station.Substring(station.IndexOf(".")+1);
                id = station2.Substring(station2.IndexOf("ID:") + 4, station2.IndexOf(".")-station2.IndexOf("ID:")-4);
                coords = station2.Substring(station2.IndexOf("("), station2.LastIndexOf(")")- station2.IndexOf("(")+1);
                Console.WriteLine(dir+", "+id+", "+coords);

                //ListViewItem item0 = new ListViewItem(id);
                //ListViewItem item1 = new ListViewItem(dir);
                //ListViewItem item2 = new ListViewItem(coords);

                listViewEstaciones.Items.Add(new ListViewItem(new[] { id, dir, coords }));
            }

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void ListViewEstaciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Atras
        protected override void Button1_Click(object sender, EventArgs e)
        {
            EcoScooterUserForm eUF = new EcoScooterUserForm(ecoService);
            eUF.Show();
            this.Close();
        }

        //Aceptar
        protected override void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewEstaciones.FocusedItem == null)
                {
                    throw new ServiceException("Debes de seleccionar una estación.");
                }
                string id = "";
                //foreach(ListViewItem.ListViewSubItem item in listViewEstaciones.FocusedItem.SubItems)
                //{
                //    Console.WriteLine(item.ToString() + "\n");

                //} 
                id = listViewEstaciones.FocusedItem.Text;
                Console.WriteLine(id);
                //estacion = estacion.Substring(estacion.IndexOf("ID: "));
                //Console.WriteLine(estacion + "\n");
                //estacion = estacion.Substring(4, estacion.IndexOf(".")-4);
                //Console.WriteLine(estacion + "\n");
                ecoService.RentScooter(id);
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
