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
        public EcoScooterDevolverPatineteForm(IEcoScooterService ecoService) : base(ecoService)
        {
            InitializeComponent();
            List<String> stationList = (List<String>)ecoService.GetStations();
            foreach (String station in stationList)
            {
                Console.WriteLine(station);
                listViewEstaciones.Items.Add(station);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
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

                    String estacion = listViewEstaciones.FocusedItem.ToString();
                    Console.WriteLine(estacion + "\n");
                    estacion = estacion.Substring(estacion.IndexOf("ID: "));
                    Console.WriteLine(estacion + "\n");
                    estacion = estacion.Substring(4, estacion.IndexOf(".") - 4);
                    Console.WriteLine(estacion + "\n");

                    ecoService.ReturnScooter(estacion);
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
            //eRI.setParent(this);
            eRI.Show();
            

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
