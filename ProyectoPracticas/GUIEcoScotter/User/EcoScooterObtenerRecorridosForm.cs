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
    public partial class EcoScooterObtenerRecorridosForm : EcoScooterFormBase
    {
        private List<String> routeList;
        String usuari;

        public EcoScooterObtenerRecorridosForm(IEcoScooterService ecoService) : base(ecoService)
        {
            InitializeComponent();
        }

        public void setNomUsuari(String s)
        {
            personLoginLabel.Text = s;
            usuari = s;
        }

        private void Fecha_Seleccionada(object sender, EventArgs e)
        {
            try
            {
                textoError.Text = "";
                DateTime fechaInicio = dateTimePicker1.Value;
                DateTime fechaFinal = dateTimePicker2.Value;
                //listView1.Clear();
                listView1.Items.Clear();
                routeList = (List<String>)ecoService.GetUserRoutes(fechaInicio, fechaFinal);


                String fIni, fFin, oriId, finId, price, route2;
                foreach (String route in routeList)
                {
                    Console.WriteLine(route);
                    fIni = route.Substring(0, route.IndexOf(','));
                    route2 = route.Substring(route.IndexOf(',')+2);
                    fFin = route2.Substring(0, route2.IndexOf(','));
                    route2 = route2.Substring(route2.IndexOf(',') + 2);
                    price = route2.Substring(0, route2.IndexOf(' ') - 1);
                    route2 = route2.Substring(route2.IndexOf(' ') +1);
                    oriId = route2.Substring(0, route2.IndexOf(' ')-1);
                    finId = route2.Substring(route2.IndexOf(' ') + 1);
                    Console.WriteLine(fIni);
                    Console.WriteLine(fFin);
                    Console.WriteLine(price);
                    Console.WriteLine(oriId);
                    Console.WriteLine(finId);
                    listView1.Items.Add(new ListViewItem(new[] {oriId, fIni, finId, fFin, price }));
                }

            }
            catch (ServiceException excepcio)
            {
                 textoError.Text = excepcio.Message;
            }
        }
        //Atras
        private void Button1_Click(object sender, EventArgs e)
        {
            EcoScooterUserForm eUF = new EcoScooterUserForm(ecoService);
            eUF.setNomUsuari(usuari);
            eUF.Show();
            this.Close();
        }

            private void TableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
