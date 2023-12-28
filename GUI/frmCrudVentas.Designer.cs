namespace GUI
{
    partial class frmCrudVentas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvConsultaVentas = new System.Windows.Forms.DataGridView();
            this.dgvIdVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFechaVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSaborBoli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCantidadBoli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCantidadBoli = new System.Windows.Forms.TextBox();
            this.txtPrecioTotalBoli = new System.Windows.Forms.TextBox();
            this.txtSaborBoli = new System.Windows.Forms.TextBox();
            this.txtIdBoli = new System.Windows.Forms.TextBox();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnInsertarVenta = new System.Windows.Forms.Button();
            this.btnModificarVenta = new System.Windows.Forms.Button();
            this.btnEliminarVenta = new System.Windows.Forms.Button();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtCantidadBoli);
            this.groupBox1.Controls.Add(this.txtPrecioTotalBoli);
            this.groupBox1.Controls.Add(this.txtSaborBoli);
            this.groupBox1.Controls.Add(this.txtIdBoli);
            this.groupBox1.Controls.Add(this.dtpFechaVenta);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnInsertarVenta);
            this.groupBox1.Controls.Add(this.btnModificarVenta);
            this.groupBox1.Controls.Add(this.btnEliminarVenta);
            this.groupBox1.Controls.Add(this.btnVolverMenu);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(-6, -9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(972, 527);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Cyan;
            this.label6.Location = new System.Drawing.Point(670, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 31);
            this.label6.TabIndex = 20;
            this.label6.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(619, 92);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(200, 20);
            this.txtBuscar.TabIndex = 19;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvConsultaVentas);
            this.groupBox2.Location = new System.Drawing.Point(452, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 340);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // dgvConsultaVentas
            // 
            this.dgvConsultaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvIdVenta,
            this.dgvFechaVenta,
            this.dgvSaborBoli,
            this.dgvCantidadBoli,
            this.dgvPrecioVenta});
            this.dgvConsultaVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConsultaVentas.Location = new System.Drawing.Point(3, 16);
            this.dgvConsultaVentas.Name = "dgvConsultaVentas";
            this.dgvConsultaVentas.Size = new System.Drawing.Size(508, 321);
            this.dgvConsultaVentas.TabIndex = 0;
            this.dgvConsultaVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultaVentas_CellContentClick);
            // 
            // dgvIdVenta
            // 
            this.dgvIdVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvIdVenta.HeaderText = "ID";
            this.dgvIdVenta.Name = "dgvIdVenta";
            // 
            // dgvFechaVenta
            // 
            this.dgvFechaVenta.HeaderText = "Fecha Venta";
            this.dgvFechaVenta.Name = "dgvFechaVenta";
            // 
            // dgvSaborBoli
            // 
            this.dgvSaborBoli.HeaderText = "Sabor";
            this.dgvSaborBoli.Name = "dgvSaborBoli";
            // 
            // dgvCantidadBoli
            // 
            this.dgvCantidadBoli.HeaderText = "Cantidad";
            this.dgvCantidadBoli.Name = "dgvCantidadBoli";
            // 
            // dgvPrecioVenta
            // 
            this.dgvPrecioVenta.HeaderText = "Total";
            this.dgvPrecioVenta.Name = "dgvPrecioVenta";
            // 
            // txtCantidadBoli
            // 
            this.txtCantidadBoli.Location = new System.Drawing.Point(245, 409);
            this.txtCantidadBoli.Name = "txtCantidadBoli";
            this.txtCantidadBoli.Size = new System.Drawing.Size(200, 20);
            this.txtCantidadBoli.TabIndex = 17;
            this.txtCantidadBoli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadBoli_KeyPress);
            // 
            // txtPrecioTotalBoli
            // 
            this.txtPrecioTotalBoli.Location = new System.Drawing.Point(245, 487);
            this.txtPrecioTotalBoli.Name = "txtPrecioTotalBoli";
            this.txtPrecioTotalBoli.Size = new System.Drawing.Size(200, 20);
            this.txtPrecioTotalBoli.TabIndex = 16;
            // 
            // txtSaborBoli
            // 
            this.txtSaborBoli.Location = new System.Drawing.Point(245, 325);
            this.txtSaborBoli.Name = "txtSaborBoli";
            this.txtSaborBoli.Size = new System.Drawing.Size(200, 20);
            this.txtSaborBoli.TabIndex = 15;
            this.txtSaborBoli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaborBoli_KeyPress_1);
            // 
            // txtIdBoli
            // 
            this.txtIdBoli.Location = new System.Drawing.Point(245, 166);
            this.txtIdBoli.Name = "txtIdBoli";
            this.txtIdBoli.Size = new System.Drawing.Size(200, 20);
            this.txtIdBoli.TabIndex = 14;
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVenta.Location = new System.Drawing.Point(245, 244);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaVenta.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Cyan;
            this.label5.Location = new System.Drawing.Point(243, 459);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Precio Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(243, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cantidad de Bolis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cyan;
            this.label3.Location = new System.Drawing.Point(240, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sabor del Boli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(243, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fecha de Venta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(243, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Codigo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::GUI.Properties.Resources.inserte_moneda2;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(248, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(193, 125);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // btnInsertarVenta
            // 
            this.btnInsertarVenta.BackColor = System.Drawing.Color.DarkBlue;
            this.btnInsertarVenta.BackgroundImage = global::GUI.Properties.Resources.agregar_producto;
            this.btnInsertarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInsertarVenta.FlatAppearance.BorderSize = 0;
            this.btnInsertarVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnInsertarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btnInsertarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertarVenta.Location = new System.Drawing.Point(58, 37);
            this.btnInsertarVenta.Name = "btnInsertarVenta";
            this.btnInsertarVenta.Size = new System.Drawing.Size(120, 104);
            this.btnInsertarVenta.TabIndex = 5;
            this.btnInsertarVenta.UseVisualStyleBackColor = false;
            this.btnInsertarVenta.Click += new System.EventHandler(this.btnInsertarVenta_Click);
            // 
            // btnModificarVenta
            // 
            this.btnModificarVenta.BackColor = System.Drawing.Color.DarkBlue;
            this.btnModificarVenta.BackgroundImage = global::GUI.Properties.Resources.papel_escrito;
            this.btnModificarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModificarVenta.FlatAppearance.BorderSize = 0;
            this.btnModificarVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnModificarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btnModificarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarVenta.Location = new System.Drawing.Point(58, 161);
            this.btnModificarVenta.Name = "btnModificarVenta";
            this.btnModificarVenta.Size = new System.Drawing.Size(120, 104);
            this.btnModificarVenta.TabIndex = 4;
            this.btnModificarVenta.UseVisualStyleBackColor = false;
            this.btnModificarVenta.Click += new System.EventHandler(this.btnModificarVenta_Click);
            // 
            // btnEliminarVenta
            // 
            this.btnEliminarVenta.BackColor = System.Drawing.Color.DarkBlue;
            this.btnEliminarVenta.BackgroundImage = global::GUI.Properties.Resources.eliminar_producto;
            this.btnEliminarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminarVenta.FlatAppearance.BorderSize = 0;
            this.btnEliminarVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnEliminarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btnEliminarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarVenta.Location = new System.Drawing.Point(58, 280);
            this.btnEliminarVenta.Name = "btnEliminarVenta";
            this.btnEliminarVenta.Size = new System.Drawing.Size(120, 104);
            this.btnEliminarVenta.TabIndex = 3;
            this.btnEliminarVenta.UseVisualStyleBackColor = false;
            this.btnEliminarVenta.Click += new System.EventHandler(this.btnEliminarVenta_Click);
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.BackColor = System.Drawing.Color.DarkBlue;
            this.btnVolverMenu.BackgroundImage = global::GUI.Properties.Resources.devolver;
            this.btnVolverMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVolverMenu.FlatAppearance.BorderSize = 0;
            this.btnVolverMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnVolverMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btnVolverMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverMenu.Location = new System.Drawing.Point(58, 402);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(120, 104);
            this.btnVolverMenu.TabIndex = 2;
            this.btnVolverMenu.UseVisualStyleBackColor = false;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkBlue;
            this.pictureBox1.Location = new System.Drawing.Point(8, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 520);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(856, 484);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "JJCO10";
            // 
            // frmCrudVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 510);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCrudVentas";
            this.Text = "Gestion de Ventas";
            this.Load += new System.EventHandler(this.frmCrudVentas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnInsertarVenta;
        private System.Windows.Forms.Button btnModificarVenta;
        private System.Windows.Forms.Button btnEliminarVenta;
        private System.Windows.Forms.Button btnVolverMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidadBoli;
        private System.Windows.Forms.TextBox txtPrecioTotalBoli;
        private System.Windows.Forms.TextBox txtSaborBoli;
        private System.Windows.Forms.TextBox txtIdBoli;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvConsultaVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIdVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFechaVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSaborBoli;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCantidadBoli;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrecioVenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
    }
}