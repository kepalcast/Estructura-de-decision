namespace TrabajoClase
{
    partial class fmEstacionamiento
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtHoraSalida = new System.Windows.Forms.MaskedTextBox();
            this.txtHoraInicio = new System.Windows.Forms.MaskedTextBox();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.lblHoraSalida = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lvlRegistro = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lvlLimpiar = new System.Windows.Forms.Button();
            this.lvlSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(168, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(763, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTROL DE REGISTRO DE ESTACIONAMIENTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "PLACA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "COSTO DEL DÍA $";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(118, 136);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(132, 23);
            this.txtPlaca.TabIndex = 3;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCosto.Location = new System.Drawing.Point(310, 196);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(72, 30);
            this.lblCosto.TabIndex = 4;
            this.lblCosto.Text = "label4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.txtHoraSalida);
            this.groupBox1.Controls.Add(this.txtHoraInicio);
            this.groupBox1.Controls.Add(this.lblHoraInicio);
            this.groupBox1.Controls.Add(this.lblHoraSalida);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Location = new System.Drawing.Point(618, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 205);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.Location = new System.Drawing.Point(192, 49);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 15);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "label8";
            this.lblFecha.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtHoraSalida
            // 
            this.txtHoraSalida.Location = new System.Drawing.Point(159, 154);
            this.txtHoraSalida.Mask = "00:00";
            this.txtHoraSalida.Name = "txtHoraSalida";
            this.txtHoraSalida.Size = new System.Drawing.Size(169, 23);
            this.txtHoraSalida.TabIndex = 5;
            this.txtHoraSalida.ValidatingType = typeof(System.DateTime);
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.Location = new System.Drawing.Point(159, 103);
            this.txtHoraInicio.Mask = "00:00";
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.Size = new System.Drawing.Size(169, 23);
            this.txtHoraInicio.TabIndex = 4;
            this.txtHoraInicio.ValidatingType = typeof(System.DateTime);
            this.txtHoraInicio.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Location = new System.Drawing.Point(47, 103);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(78, 15);
            this.lblHoraInicio.TabIndex = 3;
            this.lblHoraInicio.Text = "HORA INICIO";
            // 
            // lblHoraSalida
            // 
            this.lblHoraSalida.AutoSize = true;
            this.lblHoraSalida.Location = new System.Drawing.Point(47, 154);
            this.lblHoraSalida.Name = "lblHoraSalida";
            this.lblHoraSalida.Size = new System.Drawing.Size(82, 15);
            this.lblHoraSalida.TabIndex = 2;
            this.lblHoraSalida.Text = "HORA SALIDA";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(47, 49);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(44, 15);
            this.label.TabIndex = 1;
            this.label.Text = "FECHA";
            // 
            // lvlRegistro
            // 
            this.lvlRegistro.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvlRegistro.GridLines = true;
            this.lvlRegistro.Location = new System.Drawing.Point(24, 355);
            this.lvlRegistro.Name = "lvlRegistro";
            this.lvlRegistro.Size = new System.Drawing.Size(1052, 373);
            this.lvlRegistro.TabIndex = 6;
            this.lvlRegistro.UseCompatibleStateImageBehavior = false;
            this.lvlRegistro.View = System.Windows.Forms.View.Details;
            this.lvlRegistro.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "PLACA";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "FECHA";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "HORA INICIAL";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "HORA SALIDA";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "HORAS";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "TARIFA";
            this.columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "IMPORTE";
            this.columnHeader7.Width = 150;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(24, 284);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.lvlRegistro_Click);
            // 
            // lvlLimpiar
            // 
            this.lvlLimpiar.Location = new System.Drawing.Point(24, 754);
            this.lvlLimpiar.Name = "lvlLimpiar";
            this.lvlLimpiar.Size = new System.Drawing.Size(75, 23);
            this.lvlLimpiar.TabIndex = 8;
            this.lvlLimpiar.Text = "LIMPIAR";
            this.lvlLimpiar.UseVisualStyleBackColor = true;
            this.lvlLimpiar.Click += new System.EventHandler(this.lvlLimpiar_Click);
            // 
            // lvlSalir
            // 
            this.lvlSalir.Location = new System.Drawing.Point(1001, 754);
            this.lvlSalir.Name = "lvlSalir";
            this.lvlSalir.Size = new System.Drawing.Size(75, 23);
            this.lvlSalir.TabIndex = 9;
            this.lvlSalir.Text = "SALIR";
            this.lvlSalir.UseVisualStyleBackColor = true;
            this.lvlSalir.Click += new System.EventHandler(this.lvlSalir_Click);
            // 
            // fmEstacionamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 789);
            this.Controls.Add(this.lvlSalir);
            this.Controls.Add(this.lvlLimpiar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lvlRegistro);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fmEstacionamiento";
            this.Text = "Control de registro de estacionamiento";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPlaca;
        private Label lblCosto;
        private GroupBox groupBox1;
        private Label lblFecha;
        private MaskedTextBox txtHoraSalida;
        private MaskedTextBox txtHoraInicio;
        private Label lblHoraInicio;
        private Label lblHoraSalida;
        private Label label;
        private ListView lvlRegistro;
        private Button btnRegistrar;
        private Button lvlLimpiar;
        private Button lvlSalir;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
    }
}