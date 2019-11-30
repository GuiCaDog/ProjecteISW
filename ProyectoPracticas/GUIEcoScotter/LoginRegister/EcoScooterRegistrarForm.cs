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
    public partial class EcoScooterRegistrarForm : EcoScooterFormAtrasAceptar
    {
        
        public EcoScooterRegistrarForm(IEcoScooterService ecoService) : base(ecoService)
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EcoScooterRegistrarForm_Load(object sender, EventArgs e)
        {

        }
        protected override void Button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("aa" + ecoService);
        }
        protected override void Button2_Click(object sender, EventArgs e)
        {
            String nombre = textBoxNombre.Text;
            String dni = textBoxDNI.Text;
            String email = textBoxEmail.Text;
            int telefono = int.Parse(textBoxTelefono.Text);
            DateTime birth = dateTimePickerNac.Value;

            int numeroTarjeta = int.Parse(textBoxNumeroTarjeta.Text);
            int cVV= int.Parse(textBoxCVV.Text);
            DateTime caducidad = dateTimePickerCaducidad.Value;

            String usuario = textBoxUsuario.Text;
            String contraseña = textBoxContraseña.Text;
            String rContraseña = textBoxRepContraseña.Text;
            if (contraseña.Equals(rContraseña))
            {
                try
                {
                    Console.WriteLine(birth + "\n" + dni + "\n" + email + "\n" + nombre + "\n" + telefono + "\n" + cVV + "\n"+ caducidad + "\n" + usuario + "\n" + numeroTarjeta + "\n" + contraseña);
                    ecoService.RegisterUser(birth, dni, email, nombre, telefono, cVV, caducidad, usuario, numeroTarjeta, contraseña);
                    this.Hide();
                }
                catch(ServiceException exc)
                {
                    Console.WriteLine(exc);
                }
            }
            else
            {
                mistakes.Text = "Contraseña no coincide";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
