﻿namespace ProyectoKamil
{
    partial class frmViewEmployees
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateTimePickerBirthDay = new DateTimePicker();
            textBoxName = new TextBox();
            textBoxSelectRFC = new TextBox();
            selectWorkCenter = new NumericUpDown();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)selectWorkCenter).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 173);
            label1.Name = "label1";
            label1.Size = new Size(102, 32);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            label1.Click += label_Name_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 223);
            label2.Name = "label2";
            label2.Size = new Size(55, 32);
            label2.TabIndex = 1;
            label2.Text = "RFC";
            label2.Click += label_RFC_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 268);
            label3.Name = "label3";
            label3.Size = new Size(204, 32);
            label3.TabIndex = 2;
            label3.Text = "Centro de Trabajo";
            label3.Click += label_workCenter_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(124, 312);
            label4.Name = "label4";
            label4.Size = new Size(240, 32);
            label4.TabIndex = 3;
            label4.Text = "Fecha de Nacimiento";
            label4.Click += label_birthDate_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePickerBirthDay.Location = new Point(438, 312);
            dateTimePickerBirthDay.Name = "dateTimePickerBirthDay";
            dateTimePickerBirthDay.Size = new Size(400, 39);
            dateTimePickerBirthDay.TabIndex = 4;
            dateTimePickerBirthDay.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePickerBirthDay.ValueChanged += dateTimePicker_birthDay_ValueChanged;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(438, 170);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(200, 39);
            textBoxName.TabIndex = 5;
            textBoxName.TextChanged += textBox_selectName_TextChanged;
            // 
            // textBox2
            // 
            textBoxSelectRFC.Location = new Point(438, 220);
            textBoxSelectRFC.Name = "textBoxSelectRFC";
            textBoxSelectRFC.Size = new Size(200, 39);
            textBoxSelectRFC.TabIndex = 7;
            textBoxSelectRFC.TextChanged += textBox_selectRFC_TextChanged;
            // 
            // numericUpDown1
            // 
            selectWorkCenter.Location = new Point(438, 265);
            selectWorkCenter.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            selectWorkCenter.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            selectWorkCenter.Name = "numWorkCenter";
            selectWorkCenter.Size = new Size(76, 39);
            selectWorkCenter.TabIndex = 8;
            selectWorkCenter.Value = new decimal(new int[] { 1, 0, 0, 0 });
            selectWorkCenter.ValueChanged += numericUpDown_selectWorkCenter_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(498, 494);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 9;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_Buscar_Click;
            // 
            // frmViewEmployees
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 729);
            Controls.Add(button1);
            Controls.Add(selectWorkCenter);
            Controls.Add(textBoxSelectRFC);
            Controls.Add(textBoxName);
            Controls.Add(dateTimePickerBirthDay);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmViewEmployees";
            Text = "Ver empleados";
            Load += frmViewEmployees_Load;
            ((System.ComponentModel.ISupportInitialize)selectWorkCenter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePickerBirthDay;
        private TextBox textBoxName;
        private TextBox textBoxSelectRFC;
        private NumericUpDown selectWorkCenter;
        private Button button1;
    }
}