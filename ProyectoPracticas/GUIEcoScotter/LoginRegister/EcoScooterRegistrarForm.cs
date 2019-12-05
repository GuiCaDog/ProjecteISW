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
            this.Close();
        }
        protected override void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (emptyFields()) { mistakes.Text = "No pueden haber campos vacios"; }
                else
                {
                    String nombre = textBoxNombre.Text;
                    String dni = textBoxDNI.Text;
                    String email = textBoxEmail.Text;
                    int telefono = 0;
                    int cVV = 0;
                    try
                    {
                        telefono = int.Parse(textBoxTelefono.Text);
                        cVV = int.Parse(textBoxCVV.Text);
                    }
                    catch (System.FormatException exc)
                    {

                        mistakes.Text = "El telefono y el cVV solo contienen\nnúmeros";
                        return;

                    }
            DateTime birth = dateTimePickerNac.Value;

                    if (textBoxNumeroTarjeta.Text.Length != 8)
                    {
                        throw new System.FormatException();
                    }
                    int numeroTarjeta = int.Parse(textBoxNumeroTarjeta.Text);
                    
                    DateTime caducidad = dateTimePickerCaducidad.Value;

                    String usuario = textBoxUsuario.Text;
                    String contraseña = textBoxContraseña.Text;
                    String rContraseña = textBoxRepContraseña.Text;
                    if (contraseña.Equals(rContraseña))
                    {
                        Console.WriteLine(birth + "\n" + dni + "\n" + email + "\n" + nombre + "\n" + telefono + "\n" + cVV + "\n" + caducidad + "\n" + usuario + "\n" + numeroTarjeta + "\n" + contraseña);
                        ecoService.RegisterUser(birth, dni, email, nombre, telefono, cVV, caducidad, usuario, numeroTarjeta, contraseña);
                        this.Hide();
                    }
                    else
                    {
                        mistakes.Text = "Contraseña no coincide";
                    }
                }
            }
            catch (ServiceException exc)
            {
                mistakes.Text = exc.Message;
            }
            catch (System.FormatException exc){
                
                mistakes.Text = "La tarjeta contiene 8 números";
            }
            catch (System.OverflowException) { }
        }

        private bool emptyFields()
        {
            return textBoxNombre.Text.Equals("") || textBoxDNI.Text.Equals("") || textBoxEmail.Text.Equals("")
                || textBoxTelefono.Text.Equals("") || textBoxCVV.Text.Equals("") || textBoxUsuario.Text.Equals("") || textBoxContraseña.Text.Equals("")
                || textBoxRepContraseña.Text.Equals("") || dateTimePickerCaducidad.Value == null;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
