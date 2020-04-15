namespace Veterinario
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.clientes = new System.Windows.Forms.TabPage();
            this.dataGridEmployee = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.contraseñaAñadir = new System.Windows.Forms.TextBox();
            this.usuarioAñadir = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployee)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.clientes);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(-2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(785, 381);
            this.tabControl1.TabIndex = 1;
            // 
            // clientes
            // 
            this.clientes.Controls.Add(this.dataGridEmployee);
            this.clientes.ImageIndex = 0;
            this.clientes.Location = new System.Drawing.Point(4, 39);
            this.clientes.Name = "clientes";
            this.clientes.Padding = new System.Windows.Forms.Padding(3);
            this.clientes.Size = new System.Drawing.Size(777, 338);
            this.clientes.TabIndex = 0;
            this.clientes.Text = "Empleados";
            this.clientes.UseVisualStyleBackColor = true;
            // 
            // dataGridEmployee
            // 
            this.dataGridEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridEmployee.Location = new System.Drawing.Point(3, 3);
            this.dataGridEmployee.Name = "dataGridEmployee";
            this.dataGridEmployee.Size = new System.Drawing.Size(771, 332);
            this.dataGridEmployee.TabIndex = 0;
            this.dataGridEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEmployee_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.contraseñaAñadir);
            this.tabPage2.Controls.Add(this.usuarioAñadir);
            this.tabPage2.Controls.Add(this.label14);
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
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(777, 338);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Añadir";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 40);
            this.label1.TabIndex = 49;
            this.label1.Text = "Contraseña";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contraseñaAñadir
            // 
            this.contraseñaAñadir.Location = new System.Drawing.Point(394, 179);
            this.contraseñaAñadir.Name = "contraseñaAñadir";
            this.contraseñaAñadir.Size = new System.Drawing.Size(170, 20);
            this.contraseñaAñadir.TabIndex = 48;
            // 
            // usuarioAñadir
            // 
            this.usuarioAñadir.Location = new System.Drawing.Point(394, 80);
            this.usuarioAñadir.Name = "usuarioAñadir";
            this.usuarioAñadir.Size = new System.Drawing.Size(170, 20);
            this.usuarioAñadir.TabIndex = 47;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(389, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 40);
            this.label14.TabIndex = 46;
            this.label14.Text = "Usuario";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorAñadir
            // 
            this.errorAñadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorAñadir.Location = new System.Drawing.Point(390, 263);
            this.errorAñadir.Name = "errorAñadir";
            this.errorAñadir.Size = new System.Drawing.Size(378, 46);
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
            this.añadir.Location = new System.Drawing.Point(198, 266);
            this.añadir.Name = "añadir";
            this.añadir.Size = new System.Drawing.Size(192, 37);
            this.añadir.TabIndex = 44;
            this.añadir.Text = "Añadir";
            this.añadir.UseVisualStyleBackColor = true;
            this.añadir.Click += new System.EventHandler(this.añadir_Click);
            // 
            // nacimientoAñadir
            // 
            this.nacimientoAñadir.Location = new System.Drawing.Point(576, 80);
            this.nacimientoAñadir.MaxSelectionCount = 1;
            this.nacimientoAñadir.Name = "nacimientoAñadir";
            this.nacimientoAñadir.TabIndex = 43;
            this.nacimientoAñadir.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.nacimientoAñadir_DateSelected);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(193, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 40);
            this.label8.TabIndex = 42;
            this.label8.Text = "Telefono";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // telefonoAñadir
            // 
            this.telefonoAñadir.Location = new System.Drawing.Point(198, 179);
            this.telefonoAñadir.Name = "telefonoAñadir";
            this.telefonoAñadir.Size = new System.Drawing.Size(170, 20);
            this.telefonoAñadir.TabIndex = 41;
            // 
            // apellidoAñadir
            // 
            this.apellidoAñadir.Location = new System.Drawing.Point(198, 80);
            this.apellidoAñadir.Name = "apellidoAñadir";
            this.apellidoAñadir.Size = new System.Drawing.Size(170, 20);
            this.apellidoAñadir.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(601, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 40);
            this.label9.TabIndex = 39;
            this.label9.Text = "Nacimiento";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nombreAñadir
            // 
            this.nombreAñadir.Location = new System.Drawing.Point(9, 80);
            this.nombreAñadir.Name = "nombreAñadir";
            this.nombreAñadir.Size = new System.Drawing.Size(170, 20);
            this.nombreAñadir.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(193, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 40);
            this.label10.TabIndex = 37;
            this.label10.Text = "Apellido";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 40);
            this.label11.TabIndex = 36;
            this.label11.Text = "Direccion";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dniAñadir
            // 
            this.dniAñadir.Location = new System.Drawing.Point(9, 289);
            this.dniAñadir.Name = "dniAñadir";
            this.dniAñadir.Size = new System.Drawing.Size(170, 20);
            this.dniAñadir.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 224);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 40);
            this.label12.TabIndex = 34;
            this.label12.Text = "DNI";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // direccionAñadir
            // 
            this.direccionAñadir.Location = new System.Drawing.Point(9, 179);
            this.direccionAñadir.Name = "direccionAñadir";
            this.direccionAñadir.Size = new System.Drawing.Size(170, 20);
            this.direccionAñadir.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 40);
            this.label13.TabIndex = 32;
            this.label13.Text = "Nombre";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
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
            this.tabPage3.ImageIndex = 2;
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(777, 338);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Buscar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // errorBuscar
            // 
            this.errorBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorBuscar.Location = new System.Drawing.Point(481, 265);
            this.errorBuscar.Name = "errorBuscar";
            this.errorBuscar.Size = new System.Drawing.Size(272, 46);
            this.errorBuscar.TabIndex = 73;
            this.errorBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buscar
            // 
            this.buscar.FlatAppearance.BorderSize = 0;
            this.buscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar.Location = new System.Drawing.Point(283, 265);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(192, 37);
            this.buscar.TabIndex = 72;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            // 
            // nacimientoBuscar
            // 
            this.nacimientoBuscar.Location = new System.Drawing.Point(533, 79);
            this.nacimientoBuscar.MaxSelectionCount = 1;
            this.nacimientoBuscar.Name = "nacimientoBuscar";
            this.nacimientoBuscar.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 40);
            this.label2.TabIndex = 70;
            this.label2.Text = "Telefono";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // telefonoBuscar
            // 
            this.telefonoBuscar.Location = new System.Drawing.Point(283, 178);
            this.telefonoBuscar.Name = "telefonoBuscar";
            this.telefonoBuscar.Size = new System.Drawing.Size(200, 20);
            this.telefonoBuscar.TabIndex = 69;
            // 
            // apellidoBuscar
            // 
            this.apellidoBuscar.Location = new System.Drawing.Point(283, 79);
            this.apellidoBuscar.Name = "apellidoBuscar";
            this.apellidoBuscar.Size = new System.Drawing.Size(200, 20);
            this.apellidoBuscar.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(528, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 40);
            this.label3.TabIndex = 67;
            this.label3.Text = "Nacimiento";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nombreBuscar
            // 
            this.nombreBuscar.Location = new System.Drawing.Point(24, 79);
            this.nombreBuscar.Name = "nombreBuscar";
            this.nombreBuscar.Size = new System.Drawing.Size(200, 20);
            this.nombreBuscar.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(286, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 40);
            this.label4.TabIndex = 65;
            this.label4.Text = "Apellido";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 40);
            this.label5.TabIndex = 64;
            this.label5.Text = "Direccion";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dniBuscar
            // 
            this.dniBuscar.Location = new System.Drawing.Point(24, 277);
            this.dniBuscar.Name = "dniBuscar";
            this.dniBuscar.Size = new System.Drawing.Size(200, 20);
            this.dniBuscar.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 40);
            this.label6.TabIndex = 62;
            this.label6.Text = "DNI";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // direccionBuscar
            // 
            this.direccionBuscar.Location = new System.Drawing.Point(24, 178);
            this.direccionBuscar.Name = "direccionBuscar";
            this.direccionBuscar.Size = new System.Drawing.Size(200, 20);
            this.direccionBuscar.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 40);
            this.label7.TabIndex = 60;
            this.label7.Text = "Nombre";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8_medical_doctor_1.ico");
            this.imageList1.Images.SetKeyName(1, "icons8_plus.ico");
            this.imageList1.Images.SetKeyName(2, "icons8_search_1.ico");
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Veterinario.Properties.Resources.icons8_undo_30px;
            this.button2.Location = new System.Drawing.Point(741, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 75;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
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
            this.button1.TabIndex = 74;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 381);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Employee";
            this.Text = "Empleados";
            this.tabControl1.ResumeLayout(false);
            this.clientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployee)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage clientes;
        private System.Windows.Forms.TabPage tabPage2;
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
        private System.Windows.Forms.TextBox dniAñadir;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox direccionAñadir;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ImageList imageList1;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox contraseñaAñadir;
        private System.Windows.Forms.TextBox usuarioAñadir;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridView dataGridEmployee;
    }
}