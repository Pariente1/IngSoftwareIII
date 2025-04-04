﻿namespace ProyectoKamil
{
    partial class frmUpdatingEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGuardar = new Button();
            comboBoxJobPosition = new ComboBox();
            comboBoxWorkCenter = new ComboBox();
            label_Birthdate = new Label();
            label_Name = new Label();
            label_MotherLastname = new Label();
            label_FatherLastname = new Label();
            label1 = new Label();
            label_WorkCenter = new Label();
            dateTimePicker = new DateTimePicker();
            textBoxMotherLastname = new TextBox();
            textBoxFatherLastname = new TextBox();
            textBoxName = new TextBox();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(213, 270);
            btnGuardar.Margin = new Padding(2, 1, 2, 1);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(182, 22);
            btnGuardar.TabIndex = 39;
            btnGuardar.Text = "Modificar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // comboBoxJobPosition
            // 
            comboBoxJobPosition.FormattingEnabled = true;
            comboBoxJobPosition.Items.AddRange(new object[] { "Vendedor ", "Cajero" });
            comboBoxJobPosition.Location = new Point(319, 192);
            comboBoxJobPosition.Margin = new Padding(2, 1, 2, 1);
            comboBoxJobPosition.Name = "comboBoxJobPosition";
            comboBoxJobPosition.Size = new Size(132, 23);
            comboBoxJobPosition.TabIndex = 51;
            // 
            // comboBoxWorkCenter
            // 
            comboBoxWorkCenter.FormattingEnabled = true;
            comboBoxWorkCenter.Items.AddRange(new object[] { "Centro Culiacan", "Centro Guasave", "Centro Navolato" });
            comboBoxWorkCenter.Location = new Point(319, 164);
            comboBoxWorkCenter.Margin = new Padding(2, 1, 2, 1);
            comboBoxWorkCenter.Name = "comboBoxWorkCenter";
            comboBoxWorkCenter.Size = new Size(132, 23);
            comboBoxWorkCenter.TabIndex = 50;
            comboBoxWorkCenter.SelectedIndexChanged += comboBoxWorkCenter_SelectedIndexChanged;
            // 
            // label_Birthdate
            // 
            label_Birthdate.AutoSize = true;
            label_Birthdate.Location = new Point(162, 139);
            label_Birthdate.Margin = new Padding(2, 0, 2, 0);
            label_Birthdate.Name = "label_Birthdate";
            label_Birthdate.RightToLeft = RightToLeft.Yes;
            label_Birthdate.Size = new Size(119, 15);
            label_Birthdate.TabIndex = 49;
            label_Birthdate.Text = "Fecha de Nacimiento";
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Location = new Point(162, 58);
            label_Name.Margin = new Padding(2, 0, 2, 0);
            label_Name.Name = "label_Name";
            label_Name.RightToLeft = RightToLeft.Yes;
            label_Name.Size = new Size(51, 15);
            label_Name.TabIndex = 48;
            label_Name.Text = "Nombre";
            // 
            // label_MotherLastname
            // 
            label_MotherLastname.AutoSize = true;
            label_MotherLastname.Location = new Point(162, 110);
            label_MotherLastname.Margin = new Padding(2, 0, 2, 0);
            label_MotherLastname.Name = "label_MotherLastname";
            label_MotherLastname.RightToLeft = RightToLeft.Yes;
            label_MotherLastname.Size = new Size(99, 15);
            label_MotherLastname.TabIndex = 47;
            label_MotherLastname.Text = "Apellido Materno";
            // 
            // label_FatherLastname
            // 
            label_FatherLastname.AutoSize = true;
            label_FatherLastname.Location = new Point(162, 85);
            label_FatherLastname.Margin = new Padding(2, 0, 2, 0);
            label_FatherLastname.Name = "label_FatherLastname";
            label_FatherLastname.RightToLeft = RightToLeft.Yes;
            label_FatherLastname.Size = new Size(95, 15);
            label_FatherLastname.TabIndex = 46;
            label_FatherLastname.Text = "Apellido Paterno";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(162, 193);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 45;
            label1.Text = "Puesto de Trabajo";
            // 
            // label_WorkCenter
            // 
            label_WorkCenter.AutoSize = true;
            label_WorkCenter.Location = new Point(162, 165);
            label_WorkCenter.Margin = new Padding(2, 0, 2, 0);
            label_WorkCenter.Name = "label_WorkCenter";
            label_WorkCenter.Size = new Size(101, 15);
            label_WorkCenter.TabIndex = 44;
            label_WorkCenter.Text = "Centro de Trabajo";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(319, 137);
            dateTimePicker.Margin = new Padding(2, 1, 2, 1);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(261, 23);
            dateTimePicker.TabIndex = 43;
            dateTimePicker.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // textBoxMotherLastname
            // 
            textBoxMotherLastname.Location = new Point(319, 109);
            textBoxMotherLastname.Margin = new Padding(2, 1, 2, 1);
            textBoxMotherLastname.Name = "textBoxMotherLastname";
            textBoxMotherLastname.Size = new Size(110, 23);
            textBoxMotherLastname.TabIndex = 42;
            textBoxMotherLastname.TextAlign = HorizontalAlignment.Center;
            textBoxMotherLastname.TextChanged += textBoxMotherLastname_TextChanged;
            // 
            // textBoxFatherLastname
            // 
            textBoxFatherLastname.Location = new Point(319, 84);
            textBoxFatherLastname.Margin = new Padding(2, 1, 2, 1);
            textBoxFatherLastname.Name = "textBoxFatherLastname";
            textBoxFatherLastname.Size = new Size(110, 23);
            textBoxFatherLastname.TabIndex = 41;
            textBoxFatherLastname.TextAlign = HorizontalAlignment.Center;
            textBoxFatherLastname.UseWaitCursor = true;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(319, 56);
            textBoxName.Margin = new Padding(2, 1, 2, 1);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(110, 23);
            textBoxName.TabIndex = 40;
            textBoxName.TextAlign = HorizontalAlignment.Center;
            textBoxName.UseWaitCursor = true;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // frmUpdatingEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 361);
            Controls.Add(comboBoxJobPosition);
            Controls.Add(comboBoxWorkCenter);
            Controls.Add(label_Birthdate);
            Controls.Add(label_Name);
            Controls.Add(label_MotherLastname);
            Controls.Add(label_FatherLastname);
            Controls.Add(label1);
            Controls.Add(label_WorkCenter);
            Controls.Add(dateTimePicker);
            Controls.Add(textBoxMotherLastname);
            Controls.Add(textBoxFatherLastname);
            Controls.Add(textBoxName);
            Controls.Add(btnGuardar);
            Name = "frmUpdatingEmployee";
            Text = "frmUpdatingEmployee";
            Load += frmUpdatingEmployee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private ComboBox comboBoxJobPosition;
        private ComboBox comboBoxWorkCenter;
        private Label label_Birthdate;
        private Label label_Name;
        private Label label_MotherLastname;
        private Label label_FatherLastname;
        private Label label1;
        private Label label_WorkCenter;
        private DateTimePicker dateTimePicker;
        private TextBox textBoxMotherLastname;
        private TextBox textBoxFatherLastname;
        private TextBox textBoxName;
    }
}