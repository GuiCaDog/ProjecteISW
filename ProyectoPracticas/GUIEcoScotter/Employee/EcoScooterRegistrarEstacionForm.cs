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
    public partial class EcoScooterRegistrarEstacionForm : EcoScooterFormAtrasAceptar
    {

        public EcoScooterRegistrarEstacionForm(IEcoScooterService ecoService) : base(ecoService)
        {
            InitializeComponent();

        }
        //Aceptar
        protected override void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                String ciudad = textBoxCiudad.Text;
                String calle = textBoxCalle.Text;
                String numero = textBoxNumero.Text;
                
                double latitud = Double.Parse(textBoxLatitud.Text);
                double longitud = Double.Parse(textBoxLongitud.Text);
                String id = textBoxId.Text;

                String direccion = calle + ", " + numero + ", " + ciudad;
                Console.WriteLine(direccion + ", " + latitud + ", " + longitud + ", " + id);
            
                ecoService.RegisterStation(direccion, latitud, longitud, id);
                this.Close();
            }
            catch (ServiceException excepcio) { textoError.Text = excepcio.Message; }
            catch(System.FormatException) {
                if(textBoxLatitud.Text == "" || textBoxLongitud.Text == "")
                {
                    textoError.Text = "Latitud y longitud deben tener un valor";
                }
                textoError.Text = "La latitud y la longitud deben contener NÚMEROS";
            }
        }

        //Atras
        protected override void Button1_Click(object sender, EventArgs e)
        {
            EcoScooterEmployeeForm eUF = new EcoScooterEmployeeForm(ecoService);
            eUF.Show();
            this.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }
    }
}
