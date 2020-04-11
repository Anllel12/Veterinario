namespace Veterinario
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
            this.clientes = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.error = new System.Windows.Forms.Label();
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.clientes.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.clientes);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 383);
            this.tabControl1.TabIndex = 0;
            // 
            // clientes
            // 
            this.clientes.Controls.Add(this.dataGridView1);
            this.clientes.ImageIndex = 1;
            this.clientes.Location = new System.Drawing.Point(4, 39);
            this.clientes.Name = "clientes";
            this.clientes.Padding = new System.Windows.Forms.Padding(3);
            this.clientes.Size = new System.Drawing.Size(780, 340);
            this.clientes.TabIndex = 0;
            this.clientes.Text = "Clientes";
            this.clientes.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.error);
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
            // error
            // 
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.Location = new System.Drawing.Point(477, 266);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(272, 46);
            this.error.TabIndex = 45;
            this.error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // añadir
            // 
            this.añadir.FlatAppearance.BorderSize = 0;
            this.añadir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.añadir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.añadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.añadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.añadir.Location = new System.Drawing.Point(279, 266);
            this.añadir.Name = "añadir";
            this.añadir.Size = new System.Drawing.Size(192, 37);
            this.añadir.TabIndex = 44;
            this.añadir.Text = "Añadir";
            this.añadir.UseVisualStyleBackColor = true;
            this.añadir.Click += new System.EventHandler(this.añadir_Click);
            // 
            // nacimientoAñadir
            // 
            this.nacimientoAñadir.Location = new System.Drawing.Point(529, 80);
            this.nacimientoAñadir.MaxSelectionCount = 1;
            this.nacimientoAñadir.Name = "nacimientoAñadir";
            this.nacimientoAñadir.TabIndex = 43;
            this.nacimientoAñadir.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.nacimientoAñadir_DateSelected);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(274, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 40);
            this.label8.TabIndex = 42;
            this.label8.Text = "Telefono";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // telefonoAñadir
            // 
            this.telefonoAñadir.Location = new System.Drawing.Point(279, 179);
            this.telefonoAñadir.Name = "telefonoAñadir";
            this.telefonoAñadir.Size = new System.Drawing.Size(200, 20);
            this.telefonoAñadir.TabIndex = 41;
            // 
            // apellidoAñadir
            // 
            this.apellidoAñadir.Location = new System.Drawing.Point(279, 80);
            this.apellidoAñadir.Name = "apellidoAñadir";
            this.apellidoAñadir.Size = new System.Drawing.Size(200, 20);
            this.apellidoAñadir.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(524, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 40);
            this.label9.TabIndex = 39;
            this.label9.Text = "Nacimiento";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nombreAñadir
            // 
            this.nombreAñadir.Location = new System.Drawing.Point(20, 80);
            this.nombreAñadir.Name = "nombreAñadir";
            this.nombreAñadir.Size = new System.Drawing.Size(200, 20);
            this.nombreAñadir.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(282, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 40);
            this.label10.TabIndex = 37;
            this.label10.Text = "Apellido";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 40);
            this.label11.TabIndex = 36;
            this.label11.Text = "Direccion";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dniAñadir
            // 
            this.dniAñadir.Location = new System.Drawing.Point(20, 289);
            this.dniAñadir.Name = "dniAñadir";
            this.dniAñadir.Size = new System.Drawing.Size(200, 20);
            this.dniAñadir.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 224);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 40);
            this.label12.TabIndex = 34;
            this.label12.Text = "DNI";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // direccionAñadir
            // 
            this.direccionAñadir.Location = new System.Drawing.Point(20, 179);
            this.direccionAñadir.Name = "direccionAñadir";
            this.direccionAñadir.Size = new System.Drawing.Size(200, 20);
            this.direccionAñadir.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 40);
            this.label13.TabIndex = 32;
            this.label13.Text = "Nombre";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.ImageIndex = 0;
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(780, 340);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Buscar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8_search_1.ico");
            this.imageList1.Images.SetKeyName(1, "icons8_woman_profile_2.ico");
            this.imageList1.Images.SetKeyName(2, "icons8_plus.ico");
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(774, 334);
            this.dataGridView1.TabIndex = 0;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 381);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Clients";
            this.Text = "Clients";
            this.tabControl1.ResumeLayout(false);
            this.clientes.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage clientes;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.Label error;
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
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}