﻿namespace Veterinario
{
    partial class Clients
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clients));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridClients = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.errorAñadir = new System.Windows.Forms.Label();
            this.añadir = new System.Windows.Forms.Button();
            this.nacimientoAñadir = new System.Windows.Forms.MonthCalendar();
            this.label8 = new System.Windows.Forms.Label();
            this.telefonoAñadir = new System.Windows.Forms.TextBox();
            this.apellidoAñadir = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nombreAñadir = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dniAñadir = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.direccionAñadir = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.errorBuscar = new System.Windows.Forms.Label();
            this.buscar = new System.Windows.Forms.Button();
            this.nacimientoBuscar = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.telefonoBuscar = new System.Windows.Forms.TextBox();
            this.apellidoBuscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nombreBuscar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dniBuscar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.direccionBuscar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 383);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridClients);
            this.tabPage1.ImageIndex = 1;
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 340);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clientes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridClients
            // 
            this.dataGridClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridClients.Location = new System.Drawing.Point(3, 3);
            this.dataGridClients.Name = "dataGridClients";
            this.dataGridClients.Size = new System.Drawing.Size(774, 334);
            this.dataGridClients.TabIndex = 0;
            this.dataGridClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridClients_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::Veterinario.Properties.Resources.fondo3;
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.errorAñadir);
            this.tabPage2.Controls.Add(this.añadir);
            this.tabPage2.Controls.Add(this.nacimientoAñadir);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.telefonoAñadir);
            this.tabPage2.Controls.Add(this.apellidoAñadir);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.nombreAñadir);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.dniAñadir);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.direccionAñadir);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.ImageIndex = 2;
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 340);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Añadir";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // errorAñadir
            // 
            this.errorAñadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorAñadir.Location = new System.Drawing.Point(464, 253);
            this.errorAñadir.Name = "errorAñadir";
            this.errorAñadir.Size = new System.Drawing.Size(272, 46);
            this.errorAñadir.TabIndex = 45;
            this.errorAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // añadir
            // 
            this.añadir.FlatAppearance.BorderSize = 0;
            this.añadir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.añadir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.añadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.añadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.añadir.Location = new System.Drawing.Point(266, 253);
            this.añadir.Name = "añadir";
            this.añadir.Size = new System.Drawing.Size(192, 37);
            this.añadir.TabIndex = 44;
            this.añadir.Text = "Añadir";
            this.añadir.UseVisualStyleBackColor = true;
            this.añadir.Click += new System.EventHandler(this.añadir_Click);
            // 
            // nacimientoAñadir
            // 
            this.nacimientoAñadir.Location = new System.Drawing.Point(516, 67);
            this.nacimientoAñadir.MaxSelectionCount = 1;
            this.nacimientoAñadir.Name = "nacimientoAñadir";
            this.nacimientoAñadir.TabIndex = 43;
            this.nacimientoAñadir.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.nacimientoAñadir_DateSelected);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(261, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 40);
            this.label8.TabIndex = 42;
            this.label8.Text = "Telefono";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // telefonoAñadir
            // 
            this.telefonoAñadir.Location = new System.Drawing.Point(266, 166);
            this.telefonoAñadir.Name = "telefonoAñadir";
            this.telefonoAñadir.Size = new System.Drawing.Size(200, 20);
            this.telefonoAñadir.TabIndex = 41;
            // 
            // apellidoAñadir
            // 
            this.apellidoAñadir.Location = new System.Drawing.Point(266, 67);
            this.apellidoAñadir.Name = "apellidoAñadir";
            this.apellidoAñadir.Size = new System.Drawing.Size(200, 20);
            this.apellidoAñadir.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(511, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 40);
            this.label9.TabIndex = 39;
            this.label9.Text = "Nacimiento";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nombreAñadir
            // 
            this.nombreAñadir.Location = new System.Drawing.Point(7, 67);
            this.nombreAñadir.Name = "nombreAñadir";
            this.nombreAñadir.Size = new System.Drawing.Size(200, 20);
            this.nombreAñadir.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(269, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 40);
            this.label10.TabIndex = 37;
            this.label10.Text = "Apellido";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 40);
            this.label11.TabIndex = 36;
            this.label11.Text = "Direccion";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dniAñadir
            // 
            this.dniAñadir.Location = new System.Drawing.Point(7, 276);
            this.dniAñadir.Name = "dniAñadir";
            this.dniAñadir.Size = new System.Drawing.Size(200, 20);
            this.dniAñadir.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 211);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 40);
            this.label12.TabIndex = 34;
            this.label12.Text = "DNI";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // direccionAñadir
            // 
            this.direccionAñadir.Location = new System.Drawing.Point(7, 166);
            this.direccionAñadir.Name = "direccionAñadir";
            this.direccionAñadir.Size = new System.Drawing.Size(200, 20);
            this.direccionAñadir.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 40);
            this.label13.TabIndex = 32;
            this.label13.Text = "Nombre";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8_search_1.ico");
            this.imageList1.Images.SetKeyName(1, "icons8_woman_profile_2.ico");
            this.imageList1.Images.SetKeyName(2, "icons8_plus.ico");
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Veterinario.Properties.Resources.icons8_undo_30px;
            this.button2.Location = new System.Drawing.Point(744, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 76;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::Veterinario.Properties.Resources.fondo2;
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.errorBuscar);
            this.tabPage3.Controls.Add(this.buscar);
            this.tabPage3.Controls.Add(this.nacimientoBuscar);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.telefonoBuscar);
            this.tabPage3.Controls.Add(this.apellidoBuscar);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.nombreBuscar);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.dniBuscar);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.direccionBuscar);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.ImageIndex = 0;
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(780, 340);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Buscar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Veterinario.Properties.Resources.icons8_undo_30px;
            this.button1.Location = new System.Drawing.Point(744, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 76;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorBuscar
            // 
            this.errorBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorBuscar.Location = new System.Drawing.Point(464, 252);
            this.errorBuscar.Name = "errorBuscar";
            this.errorBuscar.Size = new System.Drawing.Size(272, 46);
            this.errorBuscar.TabIndex = 59;
            this.errorBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buscar
            // 
            this.buscar.FlatAppearance.BorderSize = 0;
            this.buscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar.Location = new System.Drawing.Point(266, 252);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(192, 37);
            this.buscar.TabIndex = 58;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // nacimientoBuscar
            // 
            this.nacimientoBuscar.Location = new System.Drawing.Point(516, 66);
            this.nacimientoBuscar.MaxSelectionCount = 1;
            this.nacimientoBuscar.Name = "nacimientoBuscar";
            this.nacimientoBuscar.TabIndex = 57;
            this.nacimientoBuscar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.nacimientoBuscar_DateSelected);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 40);
            this.label2.TabIndex = 56;
            this.label2.Text = "Telefono";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // telefonoBuscar
            // 
            this.telefonoBuscar.Location = new System.Drawing.Point(266, 165);
            this.telefonoBuscar.Name = "telefonoBuscar";
            this.telefonoBuscar.Size = new System.Drawing.Size(200, 20);
            this.telefonoBuscar.TabIndex = 55;
            // 
            // apellidoBuscar
            // 
            this.apellidoBuscar.Location = new System.Drawing.Point(266, 66);
            this.apellidoBuscar.Name = "apellidoBuscar";
            this.apellidoBuscar.Size = new System.Drawing.Size(200, 20);
            this.apellidoBuscar.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(511, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 40);
            this.label3.TabIndex = 53;
            this.label3.Text = "Nacimiento";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nombreBuscar
            // 
            this.nombreBuscar.Location = new System.Drawing.Point(7, 66);
            this.nombreBuscar.Name = "nombreBuscar";
            this.nombreBuscar.Size = new System.Drawing.Size(200, 20);
            this.nombreBuscar.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(269, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 40);
            this.label4.TabIndex = 51;
            this.label4.Text = "Apellido";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 40);
            this.label5.TabIndex = 50;
            this.label5.Text = "Direccion";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dniBuscar
            // 
            this.dniBuscar.Location = new System.Drawing.Point(7, 275);
            this.dniBuscar.Name = "dniBuscar";
            this.dniBuscar.Size = new System.Drawing.Size(200, 20);
            this.dniBuscar.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 40);
            this.label6.TabIndex = 48;
            this.label6.Text = "DNI";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // direccionBuscar
            // 
            this.direccionBuscar.Location = new System.Drawing.Point(7, 165);
            this.direccionBuscar.Name = "direccionBuscar";
            this.direccionBuscar.Size = new System.Drawing.Size(200, 20);
            this.direccionBuscar.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 40);
            this.label7.TabIndex = 46;
            this.label7.Text = "Nombre";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 381);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Clients";
            this.Text = "Clientes";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.Label errorAñadir;
        public System.Windows.Forms.Button añadir;
        public System.Windows.Forms.MonthCalendar nacimientoAñadir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox telefonoAñadir;
        private System.Windows.Forms.TextBox apellidoAñadir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nombreAñadir;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox direccionAñadir;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label errorBuscar;
        public System.Windows.Forms.Button buscar;
        public System.Windows.Forms.MonthCalendar nacimientoBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox telefonoBuscar;
        private System.Windows.Forms.TextBox apellidoBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombreBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dniBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox direccionBuscar;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox dniAñadir;
        public System.Windows.Forms.DataGridView dataGridClients;
    }
}