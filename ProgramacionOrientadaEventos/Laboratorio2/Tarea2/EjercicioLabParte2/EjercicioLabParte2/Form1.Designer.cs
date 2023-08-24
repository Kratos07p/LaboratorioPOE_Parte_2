namespace EjercicioLabParte2
{
    partial class Form1
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
            tbcInterfaz = new TabControl();
            tbpListado = new TabPage();
            btnVender = new Button();
            btnRentar = new Button();
            label4 = new Label();
            label3 = new Label();
            btnEliminar = new Button();
            btnAgregar = new Button();
            tbCategoria = new TextBox();
            tbPelicula = new TextBox();
            btnEditar = new Button();
            lbListado = new Label();
            lstCartelera = new ListBox();
            tbpRenta = new TabPage();
            label8 = new Label();
            tbUsuarioRenta = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            tbFechaLimite = new TextBox();
            tbCategoriaRentar = new TextBox();
            tbPeliculaRentar = new TextBox();
            btnAgregarRenta = new Button();
            lstRentas = new ListBox();
            lbRentas = new Label();
            tbpVenta = new TabPage();
            lstVenta = new ListBox();
            lbVentas = new Label();
            tbPeliculaVenta = new TextBox();
            tbCategoriaVenta = new TextBox();
            tbUsuarioVenta = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label9 = new Label();
            btnVenta = new Button();
            tbcInterfaz.SuspendLayout();
            tbpListado.SuspendLayout();
            tbpRenta.SuspendLayout();
            tbpVenta.SuspendLayout();
            SuspendLayout();
            // 
            // tbcInterfaz
            // 
            tbcInterfaz.Controls.Add(tbpListado);
            tbcInterfaz.Controls.Add(tbpRenta);
            tbcInterfaz.Controls.Add(tbpVenta);
            tbcInterfaz.Location = new Point(-6, 1);
            tbcInterfaz.Name = "tbcInterfaz";
            tbcInterfaz.SelectedIndex = 0;
            tbcInterfaz.Size = new Size(705, 398);
            tbcInterfaz.TabIndex = 0;
            // 
            // tbpListado
            // 
            tbpListado.BackColor = Color.Plum;
            tbpListado.Controls.Add(btnVender);
            tbpListado.Controls.Add(btnRentar);
            tbpListado.Controls.Add(label4);
            tbpListado.Controls.Add(label3);
            tbpListado.Controls.Add(btnEliminar);
            tbpListado.Controls.Add(btnAgregar);
            tbpListado.Controls.Add(tbCategoria);
            tbpListado.Controls.Add(tbPelicula);
            tbpListado.Controls.Add(btnEditar);
            tbpListado.Controls.Add(lbListado);
            tbpListado.Controls.Add(lstCartelera);
            tbpListado.Location = new Point(4, 24);
            tbpListado.Name = "tbpListado";
            tbpListado.Padding = new Padding(3);
            tbpListado.Size = new Size(697, 370);
            tbpListado.TabIndex = 0;
            tbpListado.Text = "Listado De Peliculas";
            // 
            // btnVender
            // 
            btnVender.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVender.Location = new Point(456, 317);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(129, 23);
            btnVender.TabIndex = 10;
            btnVender.Text = "Vender Pelicula";
            btnVender.UseVisualStyleBackColor = true;
            btnVender.Click += btnVender_Click;
            // 
            // btnRentar
            // 
            btnRentar.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRentar.Location = new Point(456, 277);
            btnRentar.Name = "btnRentar";
            btnRentar.Size = new Size(129, 23);
            btnRentar.TabIndex = 9;
            btnRentar.Text = "Rentar Pelicula";
            btnRentar.UseVisualStyleBackColor = true;
            btnRentar.Click += btnRentar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(560, 68);
            label4.Name = "label4";
            label4.Size = new Size(74, 19);
            label4.TabIndex = 8;
            label4.Text = "Categoria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(406, 68);
            label3.Name = "label3";
            label3.Size = new Size(68, 19);
            label3.TabIndex = 7;
            label3.Text = "Peliculas";
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(456, 239);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(134, 23);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar Pelicula";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.Location = new Point(456, 157);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(129, 28);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar Pelicula";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // tbCategoria
            // 
            tbCategoria.Location = new Point(548, 107);
            tbCategoria.Multiline = true;
            tbCategoria.Name = "tbCategoria";
            tbCategoria.Size = new Size(100, 25);
            tbCategoria.TabIndex = 4;
            // 
            // tbPelicula
            // 
            tbPelicula.Location = new Point(394, 107);
            tbPelicula.Multiline = true;
            tbPelicula.Name = "tbPelicula";
            tbPelicula.Size = new Size(100, 25);
            tbPelicula.TabIndex = 3;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.Location = new Point(456, 201);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(129, 23);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar Pelicula";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // lbListado
            // 
            lbListado.AutoSize = true;
            lbListado.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbListado.ForeColor = Color.Red;
            lbListado.Location = new Point(268, 3);
            lbListado.Name = "lbListado";
            lbListado.Size = new Size(180, 26);
            lbListado.TabIndex = 1;
            lbListado.Text = "Listado de Peliculas";
            // 
            // lstCartelera
            // 
            lstCartelera.BackColor = Color.Plum;
            lstCartelera.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lstCartelera.FormattingEnabled = true;
            lstCartelera.ItemHeight = 23;
            lstCartelera.Items.AddRange(new object[] { "Barbie - PG-13", "Oppenheimer - R", "Godzilla - PG-13", "Sonic 2 - PG" });
            lstCartelera.Location = new Point(3, 61);
            lstCartelera.Name = "lstCartelera";
            lstCartelera.Size = new Size(283, 303);
            lstCartelera.TabIndex = 0;
            // 
            // tbpRenta
            // 
            tbpRenta.BackColor = Color.Plum;
            tbpRenta.Controls.Add(label8);
            tbpRenta.Controls.Add(tbUsuarioRenta);
            tbpRenta.Controls.Add(label7);
            tbpRenta.Controls.Add(label6);
            tbpRenta.Controls.Add(label5);
            tbpRenta.Controls.Add(tbFechaLimite);
            tbpRenta.Controls.Add(tbCategoriaRentar);
            tbpRenta.Controls.Add(tbPeliculaRentar);
            tbpRenta.Controls.Add(btnAgregarRenta);
            tbpRenta.Controls.Add(lstRentas);
            tbpRenta.Controls.Add(lbRentas);
            tbpRenta.Location = new Point(4, 24);
            tbpRenta.Name = "tbpRenta";
            tbpRenta.Padding = new Padding(3);
            tbpRenta.Size = new Size(697, 370);
            tbpRenta.TabIndex = 1;
            tbpRenta.Text = "Rentas";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(438, 192);
            label8.Name = "label8";
            label8.Size = new Size(56, 19);
            label8.TabIndex = 13;
            label8.Text = "Cliente";
            // 
            // tbUsuarioRenta
            // 
            tbUsuarioRenta.Location = new Point(417, 230);
            tbUsuarioRenta.Name = "tbUsuarioRenta";
            tbUsuarioRenta.Size = new Size(100, 23);
            tbUsuarioRenta.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(559, 192);
            label7.Name = "label7";
            label7.Size = new Size(94, 19);
            label7.TabIndex = 11;
            label7.Text = "Fecha Limite";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(570, 97);
            label6.Name = "label6";
            label6.Size = new Size(74, 19);
            label6.TabIndex = 10;
            label6.Text = "Categoria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(438, 97);
            label5.Name = "label5";
            label5.Size = new Size(62, 19);
            label5.TabIndex = 9;
            label5.Text = "Pelicula";
            // 
            // tbFechaLimite
            // 
            tbFechaLimite.Location = new Point(559, 230);
            tbFechaLimite.Name = "tbFechaLimite";
            tbFechaLimite.Size = new Size(100, 23);
            tbFechaLimite.TabIndex = 8;
            // 
            // tbCategoriaRentar
            // 
            tbCategoriaRentar.Location = new Point(559, 131);
            tbCategoriaRentar.Multiline = true;
            tbCategoriaRentar.Name = "tbCategoriaRentar";
            tbCategoriaRentar.Size = new Size(100, 23);
            tbCategoriaRentar.TabIndex = 7;
            // 
            // tbPeliculaRentar
            // 
            tbPeliculaRentar.Location = new Point(417, 131);
            tbPeliculaRentar.Multiline = true;
            tbPeliculaRentar.Name = "tbPeliculaRentar";
            tbPeliculaRentar.Size = new Size(100, 23);
            tbPeliculaRentar.TabIndex = 6;
            // 
            // btnAgregarRenta
            // 
            btnAgregarRenta.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarRenta.Location = new Point(481, 294);
            btnAgregarRenta.Name = "btnAgregarRenta";
            btnAgregarRenta.Size = new Size(117, 28);
            btnAgregarRenta.TabIndex = 5;
            btnAgregarRenta.Text = "Agregar Renta";
            btnAgregarRenta.UseVisualStyleBackColor = true;
            btnAgregarRenta.Click += btnAgregarRenta_Click;
            // 
            // lstRentas
            // 
            lstRentas.BackColor = Color.Plum;
            lstRentas.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lstRentas.FormattingEnabled = true;
            lstRentas.ItemHeight = 23;
            lstRentas.Location = new Point(6, 84);
            lstRentas.Name = "lstRentas";
            lstRentas.Size = new Size(379, 280);
            lstRentas.TabIndex = 4;
            // 
            // lbRentas
            // 
            lbRentas.AutoSize = true;
            lbRentas.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbRentas.ForeColor = Color.Red;
            lbRentas.Location = new Point(283, 3);
            lbRentas.Name = "lbRentas";
            lbRentas.Size = new Size(150, 26);
            lbRentas.TabIndex = 3;
            lbRentas.Text = "Rentas Actuales";
            // 
            // tbpVenta
            // 
            tbpVenta.BackColor = Color.Plum;
            tbpVenta.Controls.Add(btnVenta);
            tbpVenta.Controls.Add(label9);
            tbpVenta.Controls.Add(label2);
            tbpVenta.Controls.Add(label1);
            tbpVenta.Controls.Add(tbUsuarioVenta);
            tbpVenta.Controls.Add(tbCategoriaVenta);
            tbpVenta.Controls.Add(tbPeliculaVenta);
            tbpVenta.Controls.Add(lbVentas);
            tbpVenta.Controls.Add(lstVenta);
            tbpVenta.Location = new Point(4, 24);
            tbpVenta.Name = "tbpVenta";
            tbpVenta.Padding = new Padding(3);
            tbpVenta.Size = new Size(697, 370);
            tbpVenta.TabIndex = 2;
            tbpVenta.Text = "Venta";
            // 
            // lstVenta
            // 
            lstVenta.BackColor = Color.Plum;
            lstVenta.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lstVenta.FormattingEnabled = true;
            lstVenta.ItemHeight = 23;
            lstVenta.Location = new Point(3, 87);
            lstVenta.Name = "lstVenta";
            lstVenta.Size = new Size(364, 280);
            lstVenta.TabIndex = 0;
            // 
            // lbVentas
            // 
            lbVentas.AutoSize = true;
            lbVentas.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbVentas.ForeColor = Color.Red;
            lbVentas.Location = new Point(279, 3);
            lbVentas.Name = "lbVentas";
            lbVentas.Size = new Size(149, 26);
            lbVentas.TabIndex = 1;
            lbVentas.Text = "Ventas Actuales";
            // 
            // tbPeliculaVenta
            // 
            tbPeliculaVenta.Location = new Point(415, 104);
            tbPeliculaVenta.Name = "tbPeliculaVenta";
            tbPeliculaVenta.Size = new Size(100, 23);
            tbPeliculaVenta.TabIndex = 2;
            // 
            // tbCategoriaVenta
            // 
            tbCategoriaVenta.Location = new Point(547, 104);
            tbCategoriaVenta.Name = "tbCategoriaVenta";
            tbCategoriaVenta.Size = new Size(100, 23);
            tbCategoriaVenta.TabIndex = 3;
            // 
            // tbUsuarioVenta
            // 
            tbUsuarioVenta.Location = new Point(483, 183);
            tbUsuarioVenta.Name = "tbUsuarioVenta";
            tbUsuarioVenta.Size = new Size(100, 23);
            tbUsuarioVenta.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(434, 71);
            label1.Name = "label1";
            label1.Size = new Size(62, 19);
            label1.TabIndex = 6;
            label1.Text = "Pelicula";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(562, 71);
            label2.Name = "label2";
            label2.Size = new Size(74, 19);
            label2.TabIndex = 7;
            label2.Text = "Categoria";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(501, 152);
            label9.Name = "label9";
            label9.Size = new Size(61, 19);
            label9.TabIndex = 8;
            label9.Text = "Usuario";
            // 
            // btnVenta
            // 
            btnVenta.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVenta.Location = new Point(483, 247);
            btnVenta.Name = "btnVenta";
            btnVenta.Size = new Size(116, 28);
            btnVenta.TabIndex = 9;
            btnVenta.Text = "Agregar Venta";
            btnVenta.UseVisualStyleBackColor = true;
            btnVenta.Click += btnVenta_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(694, 389);
            Controls.Add(tbcInterfaz);
            Name = "Form1";
            Text = "Form1";
            tbcInterfaz.ResumeLayout(false);
            tbpListado.ResumeLayout(false);
            tbpListado.PerformLayout();
            tbpRenta.ResumeLayout(false);
            tbpRenta.PerformLayout();
            tbpVenta.ResumeLayout(false);
            tbpVenta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbcInterfaz;
        private TabPage tbpListado;
        private TabPage tbpRenta;
        private ListBox lstCartelera;
        private Label lbListado;
        private Label lbRentas;
        private Button btnEditar;
        private Button btnAgregar;
        private TextBox tbCategoria;
        private TextBox tbPelicula;
        private Button btnEliminar;
        private Button btnVender;
        private Button btnRentar;
        private Label label4;
        private Label label3;
        private ListBox lstRentas;
        private Button btnAgregarRenta;
        private TextBox tbPeliculaRentar;
        private TextBox tbCategoriaRentar;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox tbFechaLimite;
        private Label label8;
        private TextBox tbUsuarioRenta;
        private TabPage tbpVenta;
        private ListBox lstVenta;
        private Label lbVentas;
        private TextBox tbUsuarioVenta;
        private TextBox tbCategoriaVenta;
        private TextBox tbPeliculaVenta;
        private Label label2;
        private Label label1;
        private Label label9;
        private Button btnVenta;
    }
}