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
    public partial class EcoScooterRegistrarIncidenteForm : EcoScooterFormAtrasAceptar
    {

        public EcoScooterRegistrarIncidenteForm(IEcoScooterService ecoService) : base(ecoService)
        {
            InitializeComponent();


        }
        //Botó Aceptar
        protected override void Button2_Click(object sender, EventArgs e)
        {
                String descripcion = textDescripcion.Text;
                String hora = textHora.Text;
                DateTime dia = dateTimePickerDia.Value;

            //List<Incident> l = ecoService.llistaIncidents();
                                //newIncidentID(List < Incident > incidents)           
                                //canviar ID
            Incident inc = new Incident(descripcion, 1, dia) ;

            


        }


        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
