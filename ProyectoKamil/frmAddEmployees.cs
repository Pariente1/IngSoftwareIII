﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProyectoKamil.RFCGenerator;

namespace ProyectoKamil
{

    public partial class frmAddEmployees : Form
    {
        public frmAddEmployees()
        {
            InitializeComponent();
            this.Size = new Size(1200, 800);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void frmAddWorker_Load(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSaveAddWorker_Click(object sender, EventArgs e)
        {
            string nombre = textBoxName.Text;
            string apellidoPaterno = textBoxFatherLastname.Text;
            string apellidoMaterno = textBoxMotherLastname.Text;
            DateTime fechaNac = dateTimePicker.Value;
            string centroTrabajo = comboBoxWorkCenter.SelectedItem?.ToString() ?? "Favor de seleccionar un centro de trabajo";
            string nombrePuesto = comboBoxJobPosition.SelectedItem?.ToString() ?? "Favor de seleccionar un puesto de trabajo";
            int isDirective = 0;
            string rfcCalculado = RFCGenerator.GenerarRFC(nombre, apellidoPaterno, apellidoMaterno, fechaNac);

            if (fechaNac == new DateTime(1900, 1, 1))
            {
                MessageBox.Show("Por favor selecciona una fecha; no puede ser 01/01/1900.");
                return;
            }

            if (fechaNac > new DateTime(2002, 1, 1))
            {
                MessageBox.Show("Solo puede ingregar personas mayores de edad.");
                return;
            }

            string connectionString = "Data Source=(localdb)\\local;Initial Catalog=ProyectoKamil;Integrated Security=True;TrustServerCertificate=True";
            string query = "INSERT INTO Empleado (Nombre, Apellido_Paterno, Apellido_Materno, Fecha_Nacimiento, RFC, Nombre_Centro, Nombre_Puesto, Directivo) VALUES (@Nombre, @apellidoPaterno, @apellidoMaterno, @fechaNac, @rfcCalculado, @centroTrabajo, @nombrePuesto, @isDirective)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@apellidoPaterno", apellidoPaterno);
                        cmd.Parameters.AddWithValue("@apellidoMaterno", apellidoMaterno);
                        cmd.Parameters.AddWithValue("@fechaNac", fechaNac);
                        cmd.Parameters.AddWithValue("@rfcCalculado", rfcCalculado);
                        cmd.Parameters.AddWithValue("@centroTrabajo", centroTrabajo);
                        cmd.Parameters.AddWithValue("@nombrePuesto", nombrePuesto);
                        cmd.Parameters.AddWithValue("@isDirective", isDirective);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                            MessageBox.Show("Empleado agregado correctamente.");
                        else
                            MessageBox.Show("No se pudo agregar el empleado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar: " + ex.Message);
                }
            }

        }

        private void textBoxFatherLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxIsDirective_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMotherLastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumeroCentroTrabajo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown_jobPosition_ValueChanged(object sender, EventArgs e)
        {

        }

        private void isNotDirective_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxJobPosition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxWorkCenter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


}
