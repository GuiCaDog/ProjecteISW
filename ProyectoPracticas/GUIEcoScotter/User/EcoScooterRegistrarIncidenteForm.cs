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
        //private EcoScooterDevolverPatineteForm dPat;
        String usuari;
        public EcoScooterRegistrarIncidenteForm(IEcoScooterService ecoService) : base(ecoService)
        {
            InitializeComponent();

        }
        public void setNomUsuari(String s)
        {
            personLoginLabel.Text = s;
            label5.Text = s;
            usuari = s;
        }


        //Atras
        protected override void Button1_Click(object sender, EventArgs e)
        {
            EcoScooterDevolverPatineteForm eUF = new EcoScooterDevolverPatineteForm(ecoService);
            eUF.setNomUsuari(usuari);
            eUF.Show();
            this.Close();
        }

        //Botó Aceptar
        protected override void Button2_Click(object sender, EventArgs e)
        {
            if (textDescripcion.Text.Equals("") || textHora.Text.Equals("") || textHora.Text.Equals("") || dateTimePickerDia.Value == null)
            {
                textError.Text = "Existen campos vacíos";
            }
            else
            {
                String descripcion = textDescripcion.Text;
                String hora = textHora.Text;
                String min = textMin.Text;
                DateTime dia = dateTimePickerDia.Value;
                try
                {
                    int h = int.Parse(hora); int m = int.Parse(min);
                    if (h < 0 || h > 23 || m < 0 || m > 59)
                    {
                        textError.Text = "Hora[00,23] : Min[00,59]";
                    }
                    else
                    {
                        dia.AddHours(h); dia.AddMinutes(m);
                        ecoService.wasIncident(descripcion, dia);
                        //dPat.setIncidentInfo(descripcion, dia);
                        EcoScooterDevolverPatineteForm eUF = new EcoScooterDevolverPatineteForm(ecoService);
                        eUF.setNomUsuari(usuari);
                        eUF.Show();
                        this.Close();
                    }
                }
                catch(Exception)
                {
                    textError.Text = "Hora[00,23] : Min[00,59]";
                }
                //dia.AddHours(int.Parse(hora));
                //((EcoScooterService)ecoService).wasIncident(descripcion, dia);

                // ecoService.RegisterIncident(descripcion, dia, rentalID);

                //List<Incident> l = ecoService.llistaIncidents();
                //newIncidentID(List < Incident > incidents)           
                //canviar ID
                //Incident inc = new Incident(descripcion, 1, dia) ;
            }



        }


        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void EcoScooterRegistrarIncidenteForm_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        //public void setParent(EcoScooterDevolverPatineteForm dP)
        //{
        //    dPat = dP;
        //}
    }
}
