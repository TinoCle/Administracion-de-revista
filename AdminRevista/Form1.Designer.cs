namespace AdminRevista
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCdadTotalPal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCdadArt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCdadPalabras = new System.Windows.Forms.Label();
            this.BotonAgregar = new System.Windows.Forms.Button();
            this.txtTextoArticulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtinfoTexto = new System.Windows.Forms.TextBox();
            this.listaArticulos = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.txtCantidadAutor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtInfoAutor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(26, 25);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1112, 794);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Size = new System.Drawing.Size(1104, 756);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Carga de datos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFecha);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtCdadTotalPal);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtCdadArt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(14, 479);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(1020, 192);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Revista";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(736, 108);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(216, 31);
            this.txtFecha.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(730, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Fecha";
            // 
            // txtCdadTotalPal
            // 
            this.txtCdadTotalPal.Location = new System.Drawing.Point(384, 108);
            this.txtCdadTotalPal.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCdadTotalPal.Name = "txtCdadTotalPal";
            this.txtCdadTotalPal.ReadOnly = true;
            this.txtCdadTotalPal.Size = new System.Drawing.Size(294, 31);
            this.txtCdadTotalPal.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cantidad total de palabras";
            // 
            // txtCdadArt
            // 
            this.txtCdadArt.Location = new System.Drawing.Point(54, 108);
            this.txtCdadArt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCdadArt.Name = "txtCdadArt";
            this.txtCdadArt.ReadOnly = true;
            this.txtCdadArt.Size = new System.Drawing.Size(268, 31);
            this.txtCdadArt.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cantidad de artículos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCdadPalabras);
            this.groupBox1.Controls.Add(this.BotonAgregar);
            this.groupBox1.Controls.Add(this.txtTextoArticulo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAutor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTitulo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(1070, 452);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Artículo nuevo";
            // 
            // lblCdadPalabras
            // 
            this.lblCdadPalabras.AutoSize = true;
            this.lblCdadPalabras.ForeColor = System.Drawing.Color.Green;
            this.lblCdadPalabras.Location = new System.Drawing.Point(948, 137);
            this.lblCdadPalabras.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCdadPalabras.Name = "lblCdadPalabras";
            this.lblCdadPalabras.Size = new System.Drawing.Size(66, 25);
            this.lblCdadPalabras.TabIndex = 23;
            this.lblCdadPalabras.Text = "0/100";
            this.lblCdadPalabras.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BotonAgregar
            // 
            this.BotonAgregar.Location = new System.Drawing.Point(384, 365);
            this.BotonAgregar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BotonAgregar.Name = "BotonAgregar";
            this.BotonAgregar.Size = new System.Drawing.Size(298, 73);
            this.BotonAgregar.TabIndex = 12;
            this.BotonAgregar.Text = "Agregar artículo a la revista";
            this.BotonAgregar.UseVisualStyleBackColor = true;
            this.BotonAgregar.Click += new System.EventHandler(this.BotonAgregar_Click);
            // 
            // txtTextoArticulo
            // 
            this.txtTextoArticulo.Location = new System.Drawing.Point(54, 169);
            this.txtTextoArticulo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTextoArticulo.Multiline = true;
            this.txtTextoArticulo.Name = "txtTextoArticulo";
            this.txtTextoArticulo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTextoArticulo.Size = new System.Drawing.Size(962, 181);
            this.txtTextoArticulo.TabIndex = 11;
            this.txtTextoArticulo.TextChanged += new System.EventHandler(this.TxtTextoArticulo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Texto del artículo";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(384, 77);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(294, 31);
            this.txtAutor.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Autor";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(54, 77);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(268, 31);
            this.txtTitulo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Título";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.txtCantidadAutor);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtInfoAutor);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Size = new System.Drawing.Size(1104, 756);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lista de datos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtinfoTexto);
            this.groupBox4.Controls.Add(this.listaArticulos);
            this.groupBox4.Location = new System.Drawing.Point(50, 231);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox4.Size = new System.Drawing.Size(1000, 396);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 40);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 25);
            this.label10.TabIndex = 21;
            this.label10.Text = "Artículos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(358, 40);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Texto del artículo";
            // 
            // txtinfoTexto
            // 
            this.txtinfoTexto.Location = new System.Drawing.Point(364, 71);
            this.txtinfoTexto.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtinfoTexto.Multiline = true;
            this.txtinfoTexto.Name = "txtinfoTexto";
            this.txtinfoTexto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtinfoTexto.Size = new System.Drawing.Size(608, 279);
            this.txtinfoTexto.TabIndex = 19;
            // 
            // listaArticulos
            // 
            this.listaArticulos.FormattingEnabled = true;
            this.listaArticulos.ItemHeight = 25;
            this.listaArticulos.Location = new System.Drawing.Point(18, 71);
            this.listaArticulos.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listaArticulos.Name = "listaArticulos";
            this.listaArticulos.Size = new System.Drawing.Size(312, 279);
            this.listaArticulos.TabIndex = 18;
            this.listaArticulos.SelectedIndexChanged += new System.EventHandler(this.ListaArticulos_SelectedIndexChanged_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnEliminar);
            this.groupBox3.Controls.Add(this.BtnBuscar);
            this.groupBox3.Location = new System.Drawing.Point(660, 33);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Size = new System.Drawing.Size(390, 142);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Acciones";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Enabled = false;
            this.BtnEliminar.Location = new System.Drawing.Point(204, 37);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(162, 75);
            this.BtnEliminar.TabIndex = 15;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(30, 38);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(162, 75);
            this.BtnBuscar.TabIndex = 14;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // txtCantidadAutor
            // 
            this.txtCantidadAutor.Location = new System.Drawing.Point(414, 65);
            this.txtCantidadAutor.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCantidadAutor.Name = "txtCantidadAutor";
            this.txtCantidadAutor.ReadOnly = true;
            this.txtCantidadAutor.Size = new System.Drawing.Size(206, 31);
            this.txtCantidadAutor.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(408, 33);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(215, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Cantidad de artículos";
            // 
            // txtInfoAutor
            // 
            this.txtInfoAutor.Location = new System.Drawing.Point(50, 65);
            this.txtInfoAutor.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtInfoAutor.Name = "txtInfoAutor";
            this.txtInfoAutor.Size = new System.Drawing.Size(330, 31);
            this.txtInfoAutor.TabIndex = 9;
            this.txtInfoAutor.TextChanged += new System.EventHandler(this.TxtInfoAutor_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Autor";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1162, 842);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Administración de Revista";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCdadTotalPal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCdadArt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTextoArticulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BotonAgregar;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtInfoAutor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCantidadAutor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtinfoTexto;
        private System.Windows.Forms.ListBox listaArticulos;
        private System.Windows.Forms.Label lblCdadPalabras;
    }
}

