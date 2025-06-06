﻿using ProyectoKamil.Data;
using ProyectoKamil.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoKamil
{
    public partial class frmUpdateDirector : Form
    {
        private EmployeeDto _empleado = new EmployeeDto();
        public frmUpdateDirector()
        {
            InitializeComponent();
            this.Size = new Size(700, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CargarDatos();
        }


        private void CargarDatos()
        {
            textBoxName.Text = _empleado.Nombre ?? "";
            textBoxFatherLastname.Text = _empleado.ApellidoPaterno ?? ""; ;
            textBoxMotherLastname.Text = _empleado.ApellidoMaterno ?? ""; ;
            dateTimePicker.Value = new DateTime(1900, 1, 1);
            //  ComboBoxes:
            comboBoxWorkCenter.SelectedValue = _empleado.CentroTrabajo;
            comboBoxJobPosition.SelectedValue = _empleado.IdPuesto;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxJobPosition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxWorkCenter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // Recopilar los criterios de busqueda desde la interfaz
            string? nombre = string.IsNullOrEmpty(textBoxName.Text.Trim())
                ? null
                : textBoxName.Text.Trim();

            string? apellidoPaterno = string.IsNullOrWhiteSpace(textBoxFatherLastname.Text)
                ? null
                : textBoxFatherLastname.Text.Trim();

            string? apellidoMaterno = string.IsNullOrWhiteSpace(textBoxMotherLastname.Text)
                ? null
                : textBoxMotherLastname.Text.Trim();

            DateTime? fechaNac = null;
            if (dateTimePicker.Value.Date != new DateTime(1900, 1, 1))
            {
                fechaNac = dateTimePicker.Value.Date;
            }

            int? centroTrabajo = null;
            if (comboBoxWorkCenter.SelectedValue != null && Convert.ToInt32(comboBoxWorkCenter.SelectedValue) != 0)
            {
                centroTrabajo = Convert.ToInt32(comboBoxWorkCenter.SelectedValue);
            }

            int? puestoTrabajo = null;
            if (comboBoxJobPosition.SelectedValue != null && Convert.ToInt32(comboBoxJobPosition.SelectedValue) != 0)
            {
                puestoTrabajo = Convert.ToInt32(comboBoxJobPosition.SelectedValue);
            }

            //LLamar al repositorio
            List<EmployeeDto> listaEmpleados = EmployeeRepository.BuscarEmpleados(nombre, apellidoPaterno, apellidoMaterno, "", fechaNac, centroTrabajo, puestoTrabajo);

            // 3) Procesar el resultado
            if (listaEmpleados.Count == 0)
            {
                MessageBox.Show("No se encontró ningún empleado con los criterios proporcionados.");
                return;
            }

            // 5) Abrir el formulario de actualización con el primer empleado encontrado
            EmployeeDto empleadoSeleccionado = listaEmpleados[0];

            frmUpdatingDirector window = new frmUpdatingDirector(empleadoSeleccionado);
            window.ShowDialog();
        }

        private void frmUpdateDirector_Load(object sender, EventArgs e)
        {

        }
    }
}
