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
    public partial class EcoScooterDevolverPatineteForm : EcoScooterFormAtrasAceptar
    {
        //private string description;
        //private DateTime dia;
        String usuari;
        public EcoScooterDevolverPatineteForm(IEcoScooterService ecoService) : base(ecoService)
        {
            InitializeComponent();
            //List<String> stationList = (List<String>)ecoService.GetStations();
            //foreach (String station in stationList)
            //{
            //    Console.WriteLine(station);
            //    listViewEstaciones.Items.Add(station);
            //}
            String dir, id, coords, station2;
            List<String> stationList = (List<String>)ecoService.GetStations();
            foreach (String station in stationList)
            {
                Console.WriteLine(station);
                dir = station.Substring(10, station.IndexOf(".") - 10);
                station2 = station.Substring(station.IndexOf(".") + 1);
                id = station2.Substring(station2.IndexOf("ID:") + 4, station2.IndexOf(".") - station2.IndexOf("ID:") - 4);
                coords = station2.Substring(station2.IndexOf("("), station2.LastIndexOf(")") - station2.IndexOf("(") + 1);
                Console.WriteLine(dir + ", " + id + ", " + coords);

                //ListViewItem item0 = new ListViewItem(id);
                //ListViewItem item1 = new ListViewItem(dir);
                //ListViewItem item2 = new ListViewItem(coords);

                listViewEstaciones.Items.Add(new ListViewItem(new[] { id, dir, coords }));
            }
        }

        public void setNomUsuari(String s)
        {
            personLoginLabel.Text = s;
            usuari = s;
        }
        //Atras
        protected override void Button1_Click(object sender, EventArgs e)
        {
            EcoScooterUserForm eUF = new EcoScooterUserForm(ecoService);
            eUF.setNomUsuari(usuari);
            eUF.Show();
            this.Close();
             

            //EcoScooterRegistrarIncidenteForm eRI = new EcoScooterRegistrarIncidenteForm(ecoService);
            //if (listViewEstaciones.FocusedItem == null)
            //{
            //    throw new ServiceException("Debes de seleccionar una estación.");
            //}

            //String estacion = listViewEstaciones.FocusedItem.ToString();
            //Console.WriteLine(estacion + "\n");
            //estacion = estacion.Substring(estacion.IndexOf("ID: "));
            //Console.WriteLine(estacion + "\n");
            //estacion = estacion.Substring(4, estacion.IndexOf(".") - 4);
            //Console.WriteLine(estacion + "\n");
            //eRI.setRentalId(estacion);
            //this.Hide();
            
           

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
                else
                {

                    String estacion = listViewEstaciones.FocusedItem.Text;
                    //Console.WriteLine(estacion + "\n");
                    //estacion = estacion.Substring(estacion.IndexOf("ID: "));
                    //Console.WriteLine(estacion + "\n");
                    //estacion = estacion.Substring(4, estacion.IndexOf(".") - 4);
                    //Console.WriteLine(estacion + "\n");
                    Console.WriteLine(estacion);
                    ecoService.ReturnScooter(estacion);

                    EcoScooterUserForm eUF = new EcoScooterUserForm(ecoService);
                    eUF.setNomUsuari(usuari);
                    eUF.Show();
                    this.Close();
                }
            }
            catch (ServiceException ex)
            {
                labelError.Text = ex.Message;
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void EcoScooterDevolverPatineteForm_Load(object sender, EventArgs e)
        {

        }

     

        private void Si_Click(object sender, EventArgs e)
        {
            EcoScooterRegistrarIncidenteForm eRI = new EcoScooterRegistrarIncidenteForm(ecoService);
            eRI.setNomUsuari(usuari);
            //eRI.setParent(this);
            eRI.Show();
            this.Close();
            

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void listViewEstaciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //public void setIncidentInfo(string descr, DateTime when)
        //{
        //    description = descr;
        //    dia = when;
        //}
    }
}
