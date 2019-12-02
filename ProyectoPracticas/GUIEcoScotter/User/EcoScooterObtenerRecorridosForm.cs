﻿using System;
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

        public EcoScooterObtenerRecorridosForm(IEcoScooterService ecoService) : base(ecoService)
        {
            InitializeComponent();
        }

        private void Fecha_Seleccionada(object sender, EventArgs e)
        {
            try
            {
                textoError.Text = "";
                DateTime fechaInicio = dateTimePicker1.Value;
                DateTime fechaFinal = dateTimePicker2.Value;
                listView1.Clear();
                routeList = (List<String>)ecoService.GetUserRoutes(fechaInicio, fechaFinal);
                foreach (String route in routeList)
                {
                    Console.WriteLine(route);
                    listView1.Items.Add(route);
                }

            }
            catch (ServiceException excepcio)
            {
                 textoError.Text = excepcio.Message;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
