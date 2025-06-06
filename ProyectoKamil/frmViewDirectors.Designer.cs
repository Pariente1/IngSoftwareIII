﻿namespace ProyectoKamil
{
    partial class frmViewDirectors
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
            btnBuscar = new Button();
            selectWorkCenter = new NumericUpDown();
            textBoxSelectRFC = new TextBox();
            textBoxName = new TextBox();
            dateTimePickerBirthDay = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)selectWorkCenter).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(292, 272);
            btnBuscar.Margin = new Padding(2, 1, 2, 1);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(81, 22);
            btnBuscar.TabIndex = 18;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // selectWorkCenter
            // 
            selectWorkCenter.Location = new Point(349, 141);
            selectWorkCenter.Margin = new Padding(2, 1, 2, 1);
            selectWorkCenter.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            selectWorkCenter.Name = "selectWorkCenter";
            selectWorkCenter.Size = new Size(41, 23);
            selectWorkCenter.TabIndex = 17;
            // 
            // textBoxSelectRFC
            // 
            textBoxSelectRFC.Location = new Point(349, 120);
            textBoxSelectRFC.Margin = new Padding(2, 1, 2, 1);
            textBoxSelectRFC.Name = "textBoxSelectRFC";
            textBoxSelectRFC.Size = new Size(110, 23);
            textBoxSelectRFC.TabIndex = 16;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(349, 97);
            textBoxName.Margin = new Padding(2, 1, 2, 1);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(110, 23);
            textBoxName.TabIndex = 15;
            // 
            // dateTimePickerBirthDay
            // 
            dateTimePickerBirthDay.Location = new Point(349, 163);
            dateTimePickerBirthDay.Margin = new Padding(2, 1, 2, 1);
            dateTimePickerBirthDay.Name = "dateTimePickerBirthDay";
            dateTimePickerBirthDay.Size = new Size(217, 23);
            dateTimePickerBirthDay.TabIndex = 14;
            dateTimePickerBirthDay.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(180, 163);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(119, 15);
            label4.TabIndex = 13;
            label4.Text = "Fecha de Nacimiento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(180, 143);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 12;
            label3.Text = "Centro de Trabajo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 122);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 11;
            label2.Text = "RFC";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(180, 98);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 10;
            label1.Text = "Nombre";
            // 
            // frmViewDirectors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 361);
            Controls.Add(btnBuscar);
            Controls.Add(selectWorkCenter);
            Controls.Add(textBoxSelectRFC);
            Controls.Add(textBoxName);
            Controls.Add(dateTimePickerBirthDay);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "frmViewDirectors";
            Text = "Ver directores";
            Load += frmViewDirectors_Load;
            ((System.ComponentModel.ISupportInitialize)selectWorkCenter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private NumericUpDown selectWorkCenter;
        private TextBox textBoxSelectRFC;
        private TextBox textBoxName;
        private DateTimePicker dateTimePickerBirthDay;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}