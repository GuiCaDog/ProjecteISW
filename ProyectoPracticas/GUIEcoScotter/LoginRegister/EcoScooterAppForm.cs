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
    public partial class EcoScooterAppForm : EcoScooterFormBase
    {
        //EcoScooterEmployeeForm eF;
        public EcoScooterAppForm(IEcoScooterService ecoService) : base(ecoService)
        {
            InitializeComponent();
            //eF = new EcoScooterEmployeeForm(ecoService);
            //eF.Show();
            //eF.Visible = false;

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonIniciarSesion_Click(object sender, EventArgs e)
        {
            string user = textLogin.Text;
            string password = textBoxPassword.Text;
            if (textLogin.Text.Equals("PACO"))
            {
                try
                {
                    ((EcoScooterService)ecoService).addEmployee(DateTime.Now.AddYears(-20), "11112222", "noEmail", "PACO", 55, "123", 0000, "bona", 1000);
                    ecoService.LoginEmployee("11112222", int.Parse(password));
                    ((EcoScooterService)ecoService).clearEmployees();
                }
                catch (ServiceException ex)
                {
                    Console.WriteLine(ex);
                }
                EcoScooterEmployeeForm eF = new EcoScooterEmployeeForm(ecoService);
                eF.Show();
                //this.Hide();
            }
            else
            {
                try
                {
                    ecoService.LoginUser(user, password);
                }
                catch(ServiceException ex)
                {
                    Console.WriteLine(ex);
                }
                EcoScooterUserForm eU = new EcoScooterUserForm(ecoService);
                eU.Show();
                //this.Hide();
            }

            
            //this.Visible = false;
            //eF.Visible = true;

        }


        private void ButtonRegistrarse_Click(object sender, EventArgs e)
        {
            EcoScooterRegistrarForm r = new EcoScooterRegistrarForm(ecoService);
            r.Show();
        }

        private void EcoScooterAppForm_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
