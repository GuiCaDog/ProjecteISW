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
    public partial class EcoScooterRegistrarPatineteForm : EcoScooterFormAtrasAceptar
    {

        public EcoScooterRegistrarPatineteForm(IEcoScooterService ecoService) : base(ecoService)
        {
            InitializeComponent();
            List<String> stationList = (List<String>)ecoService.GetStations();
            foreach(String station in stationList)
            {
                Console.WriteLine(station);
                listViewEstaciones.Items.Add(station);
            }
            listViewEstaciones.Visible = false;
            labelEstaciones.Visible = false;

        }
        //Aceptar
        protected override void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaRegistro = dateTimePicker1.Value;
                if (comboBoxEstado.SelectedItem == null || dateTimePicker1.Value==null)
                {
                    throw new ServiceException("Debes rellenar todos los campos");
                }
                String estado = comboBoxEstado.Text;
                int scooterState = 0;
                if (estado.Equals("Mantenimiento")) { scooterState = 2; }
                else{
                    scooterState = 1;

                }

                if (listViewEstaciones.FocusedItem == null)
                {
                    throw new ServiceException("Debes de seleccionar una estación.");
                }

                String estacion = listViewEstaciones.FocusedItem.ToString();
                estacion = estacion.Substring(estacion.IndexOf("ID: "));
                estacion = estacion.Substring(0, estacion.IndexOf("."));
                Console.WriteLine(fechaRegistro + ", " + estado + ", " + scooterState + ", " + estacion + ".");
                //ecoService.RegisterScooter(fechaRegistro, scooterState, estacion);
            }
            catch (ServiceException excepcio)
            {
                textoError2.Text = excepcio.Message;
            }
        }
        //Atrás
        protected override void Button1_Click(Object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxEstado_SelectedIndexChanged(Object sender, EventArgs e)
        {
            if (comboBoxEstado.Text.Equals("Disponible"))
            {
                listViewEstaciones.Visible = true;
                labelEstaciones.Visible = true; ;
            }
            else
            {
                listViewEstaciones.Visible = false;
                labelEstaciones.Visible = false;
            }

            if (dateTimePicker1.Value == null || dateTimePicker1.Value.CompareTo(DateTime.Now) > 0)
            {
                textoError1.Text = "La fecha de registro debe ser anterior a la actual";
            }
            else if(dateTimePicker1.Value != null && dateTimePicker1.Value.CompareTo(DateTime.Now) <= 0)
            {
                textoError1.Text = "";
            }

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void ListViewEstaciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}