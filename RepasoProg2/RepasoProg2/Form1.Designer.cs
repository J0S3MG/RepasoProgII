namespace RepasoProg2
{
    partial class Form1
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.tbxNro = new System.Windows.Forms.TextBox();
            this.lbxVista = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAgregarS = new System.Windows.Forms.Button();
            this.btnExpT = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCrearT = new System.Windows.Forms.Button();
            this.tbxCuil = new System.Windows.Forms.TextBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.tbxDesc = new System.Windows.Forms.TextBox();
            this.tbxPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rbtMantenimiento = new System.Windows.Forms.RadioButton();
            this.rbtReparacion = new System.Windows.Forms.RadioButton();
            this.cbxNroTicket = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(225, 21);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(78, 48);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Text = "Eliminar Servico";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // tbxNro
            // 
            this.tbxNro.Location = new System.Drawing.Point(9, 47);
            this.tbxNro.Name = "tbxNro";
            this.tbxNro.Size = new System.Drawing.Size(188, 22);
            this.tbxNro.TabIndex = 1;
            this.tbxNro.TextChanged += new System.EventHandler(this.tbxNro_TextChanged);
            // 
            // lbxVista
            // 
            this.lbxVista.FormattingEnabled = true;
            this.lbxVista.ItemHeight = 16;
            this.lbxVista.Location = new System.Drawing.Point(22, 118);
            this.lbxVista.Name = "lbxVista";
            this.lbxVista.Size = new System.Drawing.Size(443, 356);
            this.lbxVista.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nro Servicio";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxNro);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 93);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eliminar Servicio";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnCrearT);
            this.groupBox2.Controls.Add(this.tbxCuil);
            this.groupBox2.Controls.Add(this.tbxNombre);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(505, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 422);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ticket";
            // 
            // btnAgregarS
            // 
            this.btnAgregarS.Location = new System.Drawing.Point(169, 130);
            this.btnAgregarS.Name = "btnAgregarS";
            this.btnAgregarS.Size = new System.Drawing.Size(106, 42);
            this.btnAgregarS.TabIndex = 8;
            this.btnAgregarS.Text = "Agregar Servicio";
            this.btnAgregarS.UseVisualStyleBackColor = true;
            this.btnAgregarS.Click += new System.EventHandler(this.btnAgregarS_Click);
            // 
            // btnExpT
            // 
            this.btnExpT.Location = new System.Drawing.Point(158, 21);
            this.btnExpT.Name = "btnExpT";
            this.btnExpT.Size = new System.Drawing.Size(117, 50);
            this.btnExpT.TabIndex = 1;
            this.btnExpT.Text = "Exportar Tickets";
            this.btnExpT.UseVisualStyleBackColor = true;
            this.btnExpT.Click += new System.EventHandler(this.btnExpT_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Importar Servicios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCrearT
            // 
            this.btnCrearT.Location = new System.Drawing.Point(202, 61);
            this.btnCrearT.Name = "btnCrearT";
            this.btnCrearT.Size = new System.Drawing.Size(106, 42);
            this.btnCrearT.TabIndex = 6;
            this.btnCrearT.Text = "Crear Ticket";
            this.btnCrearT.UseVisualStyleBackColor = true;
            this.btnCrearT.Click += new System.EventHandler(this.btnCrearT_Click);
            // 
            // tbxCuil
            // 
            this.tbxCuil.Location = new System.Drawing.Point(16, 98);
            this.tbxCuil.Name = "tbxCuil";
            this.tbxCuil.Size = new System.Drawing.Size(163, 22);
            this.tbxCuil.TabIndex = 5;
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(16, 49);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(163, 22);
            this.tbxNombre.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "CUIL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btnExpT);
            this.groupBox3.Location = new System.Drawing.Point(16, 324);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 82);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CSV";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.cbxNroTicket);
            this.groupBox4.Controls.Add(this.rbtReparacion);
            this.groupBox4.Controls.Add(this.rbtMantenimiento);
            this.groupBox4.Controls.Add(this.btnAgregarS);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.tbxPrecio);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.tbxDesc);
            this.groupBox4.Controls.Add(this.tbxCodigo);
            this.groupBox4.Location = new System.Drawing.Point(16, 137);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(292, 187);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Servicio";
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Location = new System.Drawing.Point(18, 86);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.Size = new System.Drawing.Size(117, 22);
            this.tbxCodigo.TabIndex = 11;
            // 
            // tbxDesc
            // 
            this.tbxDesc.Location = new System.Drawing.Point(16, 42);
            this.tbxDesc.Name = "tbxDesc";
            this.tbxDesc.Size = new System.Drawing.Size(147, 22);
            this.tbxDesc.TabIndex = 12;
            // 
            // tbxPrecio
            // 
            this.tbxPrecio.Location = new System.Drawing.Point(18, 130);
            this.tbxPrecio.Name = "tbxPrecio";
            this.tbxPrecio.Size = new System.Drawing.Size(117, 22);
            this.tbxPrecio.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Codigo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Descripcion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Precio Base";
            // 
            // rbtMantenimiento
            // 
            this.rbtMantenimiento.AutoSize = true;
            this.rbtMantenimiento.Location = new System.Drawing.Point(158, 104);
            this.rbtMantenimiento.Name = "rbtMantenimiento";
            this.rbtMantenimiento.Size = new System.Drawing.Size(115, 20);
            this.rbtMantenimiento.TabIndex = 16;
            this.rbtMantenimiento.TabStop = true;
            this.rbtMantenimiento.Text = "Mantenimiento";
            this.rbtMantenimiento.UseVisualStyleBackColor = true;
            // 
            // rbtReparacion
            // 
            this.rbtReparacion.AutoSize = true;
            this.rbtReparacion.Location = new System.Drawing.Point(158, 78);
            this.rbtReparacion.Name = "rbtReparacion";
            this.rbtReparacion.Size = new System.Drawing.Size(99, 20);
            this.rbtReparacion.TabIndex = 17;
            this.rbtReparacion.TabStop = true;
            this.rbtReparacion.Text = "Reparacion";
            this.rbtReparacion.UseVisualStyleBackColor = true;
            // 
            // cbxNroTicket
            // 
            this.cbxNroTicket.FormattingEnabled = true;
            this.cbxNroTicket.Location = new System.Drawing.Point(175, 40);
            this.cbxNroTicket.Name = "cbxNroTicket";
            this.cbxNroTicket.Size = new System.Drawing.Size(100, 24);
            this.cbxNroTicket.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(172, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Nro Ticket";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 482);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbxVista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox tbxNro;
        private System.Windows.Forms.ListBox lbxVista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxCuil;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Button btnCrearT;
        private System.Windows.Forms.Button btnAgregarS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExpT;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbtReparacion;
        private System.Windows.Forms.RadioButton rbtMantenimiento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxPrecio;
        private System.Windows.Forms.TextBox tbxDesc;
        private System.Windows.Forms.TextBox tbxCodigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxNroTicket;
    }
}

