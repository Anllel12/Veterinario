namespace Veterinario
{
    partial class Animals
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Animals));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.error = new System.Windows.Forms.Label();
            this.añadir = new System.Windows.Forms.Button();
            this.nacimientoAñadir = new System.Windows.Forms.MonthCalendar();
            this.label8 = new System.Windows.Forms.Label();
            this.sexoAñadir = new System.Windows.Forms.TextBox();
            this.razaAñadir = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nombreAñadir = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dniAñadir = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.especieAñadir = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.buscar = new System.Windows.Forms.Button();
            this.nacimientoBuscar = new System.Windows.Forms.MonthCalendar();
            this.label7 = new System.Windows.Forms.Label();
            this.sexoBuscar = new System.Windows.Forms.TextBox();
            this.razaBuscar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nombreBuscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dniDueñoBuscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.especieBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.codigoBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 381);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.ImageIndex = 1;
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 338);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Animales";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(770, 332);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.error);
            this.tabPage2.Controls.Add(this.añadir);
            this.tabPage2.Controls.Add(this.nacimientoAñadir);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.sexoAñadir);
            this.tabPage2.Controls.Add(this.razaAñadir);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.nombreAñadir);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.dniAñadir);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.especieAñadir);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.ImageIndex = 6;
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 338);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Añadir";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // error
            // 
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.Location = new System.Drawing.Point(491, 265);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(272, 46);
            this.error.TabIndex = 31;
            this.error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // añadir
            // 
            this.añadir.FlatAppearance.BorderSize = 0;
            this.añadir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.añadir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.añadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.añadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.añadir.Location = new System.Drawing.Point(281, 250);
            this.añadir.Name = "añadir";
            this.añadir.Size = new System.Drawing.Size(192, 37);
            this.añadir.TabIndex = 30;
            this.añadir.Text = "Añadir";
            this.añadir.UseVisualStyleBackColor = true;
            this.añadir.Click += new System.EventHandler(this.añadir_Click);
            // 
            // nacimientoAñadir
            // 
            this.nacimientoAñadir.Location = new System.Drawing.Point(531, 82);
            this.nacimientoAñadir.MaxSelectionCount = 1;
            this.nacimientoAñadir.Name = "nacimientoAñadir";
            this.nacimientoAñadir.TabIndex = 29;
            this.nacimientoAñadir.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.nacimientoAñadir_DateSelected);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(276, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 40);
            this.label8.TabIndex = 28;
            this.label8.Text = "Sexo";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sexoAñadir
            // 
            this.sexoAñadir.Location = new System.Drawing.Point(281, 181);
            this.sexoAñadir.Name = "sexoAñadir";
            this.sexoAñadir.Size = new System.Drawing.Size(200, 20);
            this.sexoAñadir.TabIndex = 27;
            // 
            // razaAñadir
            // 
            this.razaAñadir.Location = new System.Drawing.Point(281, 82);
            this.razaAñadir.Name = "razaAñadir";
            this.razaAñadir.Size = new System.Drawing.Size(200, 20);
            this.razaAñadir.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(526, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 40);
            this.label9.TabIndex = 25;
            this.label9.Text = "Nacimiento";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nombreAñadir
            // 
            this.nombreAñadir.Location = new System.Drawing.Point(22, 82);
            this.nombreAñadir.Name = "nombreAñadir";
            this.nombreAñadir.Size = new System.Drawing.Size(200, 20);
            this.nombreAñadir.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(284, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 40);
            this.label10.TabIndex = 23;
            this.label10.Text = "Raza";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 40);
            this.label11.TabIndex = 22;
            this.label11.Text = "Especie";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dniAñadir
            // 
            this.dniAñadir.Location = new System.Drawing.Point(22, 291);
            this.dniAñadir.Name = "dniAñadir";
            this.dniAñadir.Size = new System.Drawing.Size(200, 20);
            this.dniAñadir.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(24, 226);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 40);
            this.label12.TabIndex = 20;
            this.label12.Text = "DNI Dueño";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // especieAñadir
            // 
            this.especieAñadir.Location = new System.Drawing.Point(22, 181);
            this.especieAñadir.Name = "especieAñadir";
            this.especieAñadir.Size = new System.Drawing.Size(200, 20);
            this.especieAñadir.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 40);
            this.label13.TabIndex = 18;
            this.label13.Text = "Nombre";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.buscar);
            this.tabPage4.Controls.Add(this.nacimientoBuscar);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.sexoBuscar);
            this.tabPage4.Controls.Add(this.razaBuscar);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.nombreBuscar);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.dniDueñoBuscar);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.especieBuscar);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.codigoBuscar);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.ImageIndex = 8;
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(776, 338);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Buscar";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // buscar
            // 
            this.buscar.FlatAppearance.BorderSize = 0;
            this.buscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar.Location = new System.Drawing.Point(572, 266);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(192, 37);
            this.buscar.TabIndex = 15;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // nacimientoBuscar
            // 
            this.nacimientoBuscar.Location = new System.Drawing.Point(572, 74);
            this.nacimientoBuscar.Name = "nacimientoBuscar";
            this.nacimientoBuscar.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(320, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 40);
            this.label7.TabIndex = 13;
            this.label7.Text = "Sexo";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sexoBuscar
            // 
            this.sexoBuscar.Location = new System.Drawing.Point(325, 283);
            this.sexoBuscar.Name = "sexoBuscar";
            this.sexoBuscar.Size = new System.Drawing.Size(200, 20);
            this.sexoBuscar.TabIndex = 12;
            // 
            // razaBuscar
            // 
            this.razaBuscar.Location = new System.Drawing.Point(325, 173);
            this.razaBuscar.Name = "razaBuscar";
            this.razaBuscar.Size = new System.Drawing.Size(200, 20);
            this.razaBuscar.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(567, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 40);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nacimiento";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nombreBuscar
            // 
            this.nombreBuscar.Location = new System.Drawing.Point(325, 78);
            this.nombreBuscar.Name = "nombreBuscar";
            this.nombreBuscar.Size = new System.Drawing.Size(200, 20);
            this.nombreBuscar.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(320, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 40);
            this.label5.TabIndex = 8;
            this.label5.Text = "Raza";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 40);
            this.label4.TabIndex = 6;
            this.label4.Text = "Especie";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dniDueñoBuscar
            // 
            this.dniDueñoBuscar.Location = new System.Drawing.Point(26, 283);
            this.dniDueñoBuscar.Name = "dniDueñoBuscar";
            this.dniDueñoBuscar.Size = new System.Drawing.Size(200, 20);
            this.dniDueñoBuscar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "DNI Dueño";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // especieBuscar
            // 
            this.especieBuscar.Location = new System.Drawing.Point(26, 173);
            this.especieBuscar.Name = "especieBuscar";
            this.especieBuscar.Size = new System.Drawing.Size(200, 20);
            this.especieBuscar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // codigoBuscar
            // 
            this.codigoBuscar.Location = new System.Drawing.Point(26, 78);
            this.codigoBuscar.Name = "codigoBuscar";
            this.codigoBuscar.Size = new System.Drawing.Size(200, 20);
            this.codigoBuscar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8_cat_butt.ico");
            this.imageList1.Images.SetKeyName(1, "icons8_dog.ico");
            this.imageList1.Images.SetKeyName(2, "icons8_heart_with_pulse_1.ico");
            this.imageList1.Images.SetKeyName(3, "icons8_medical_doctor_1.ico");
            this.imageList1.Images.SetKeyName(4, "icons8_pig.ico");
            this.imageList1.Images.SetKeyName(5, "icons8_syringe.ico");
            this.imageList1.Images.SetKeyName(6, "icons8_cat_footprint.ico");
            this.imageList1.Images.SetKeyName(7, "icons8_corgi.ico");
            this.imageList1.Images.SetKeyName(8, "icons8_search_1.ico");
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Veterinario.Properties.Resources.icons8_undo_30px;
            this.button2.Location = new System.Drawing.Point(740, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 77;
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
            this.button1.Location = new System.Drawing.Point(740, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 77;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Animals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 381);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Animals";
            this.Text = "Animales";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox sexoAñadir;
        private System.Windows.Forms.TextBox razaAñadir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nombreAñadir;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox dniAñadir;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox especieAñadir;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Button añadir;
        public System.Windows.Forms.MonthCalendar nacimientoAñadir;
        public System.Windows.Forms.Button buscar;
        public System.Windows.Forms.MonthCalendar nacimientoBuscar;
        public System.Windows.Forms.TextBox sexoBuscar;
        public System.Windows.Forms.TextBox razaBuscar;
        public System.Windows.Forms.TextBox nombreBuscar;
        public System.Windows.Forms.TextBox dniDueñoBuscar;
        public System.Windows.Forms.TextBox especieBuscar;
        public System.Windows.Forms.TextBox codigoBuscar;
        public System.Windows.Forms.Label error;
        public System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
    }
}

