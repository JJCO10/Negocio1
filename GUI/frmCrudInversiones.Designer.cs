namespace GUI
{
    partial class frmCrudInversiones
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvConsultaInversiones = new System.Windows.Forms.DataGridView();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtIdInversion = new System.Windows.Forms.TextBox();
            this.dtpFechaInversion = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvIdInversion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFechaInversion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrecioInversion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnInsertarInversion = new System.Windows.Forms.Button();
            this.btnModificarInversion = new System.Windows.Forms.Button();
            this.btnEliminarInversion = new System.Windows.Forms.Button();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaInversiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnInsertarInversion);
            this.groupBox1.Controls.Add(this.btnModificarInversion);
            this.groupBox1.Controls.Add(this.btnEliminarInversion);
            this.groupBox1.Controls.Add(this.btnVolverMenu);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtProducto);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtIdInversion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpFechaInversion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(-2, -8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(967, 525);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvConsultaInversiones);
            this.groupBox2.Location = new System.Drawing.Point(452, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 340);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // dgvConsultaInversiones
            // 
            this.dgvConsultaInversiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaInversiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvIdInversion,
            this.dgvFechaInversion,
            this.dgvProducto,
            this.dgvPrecioInversion});
            this.dgvConsultaInversiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConsultaInversiones.Location = new System.Drawing.Point(3, 16);
            this.dgvConsultaInversiones.Name = "dgvConsultaInversiones";
            this.dgvConsultaInversiones.Size = new System.Drawing.Size(508, 321);
            this.dgvConsultaInversiones.TabIndex = 0;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(234, 409);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(200, 20);
            this.txtPrecio.TabIndex = 25;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(234, 325);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(200, 20);
            this.txtProducto.TabIndex = 24;
            // 
            // txtIdInversion
            // 
            this.txtIdInversion.Location = new System.Drawing.Point(234, 166);
            this.txtIdInversion.Name = "txtIdInversion";
            this.txtIdInversion.Size = new System.Drawing.Size(200, 20);
            this.txtIdInversion.TabIndex = 23;
            // 
            // dtpFechaInversion
            // 
            this.dtpFechaInversion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInversion.Location = new System.Drawing.Point(234, 244);
            this.dtpFechaInversion.Name = "dtpFechaInversion";
            this.dtpFechaInversion.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInversion.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(232, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Precio Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cyan;
            this.label3.Location = new System.Drawing.Point(229, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(232, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Fecha Inversion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(232, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Codigo";
            // 
            // dgvIdInversion
            // 
            this.dgvIdInversion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dgvIdInversion.HeaderText = "ID";
            this.dgvIdInversion.Name = "dgvIdInversion";
            this.dgvIdInversion.Width = 21;
            // 
            // dgvFechaInversion
            // 
            this.dgvFechaInversion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvFechaInversion.HeaderText = "Fecha Inversion";
            this.dgvFechaInversion.Name = "dgvFechaInversion";
            // 
            // dgvProducto
            // 
            this.dgvProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProducto.HeaderText = "Producto";
            this.dgvProducto.Name = "dgvProducto";
            // 
            // dgvPrecioInversion
            // 
            this.dgvPrecioInversion.HeaderText = "Total";
            this.dgvPrecioInversion.Name = "dgvPrecioInversion";
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
            this.label6.TabIndex = 27;
            this.label6.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(619, 92);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(200, 20);
            this.txtBuscar.TabIndex = 26;
            // 
            // btnInsertarInversion
            // 
            this.btnInsertarInversion.BackColor = System.Drawing.Color.DarkBlue;
            this.btnInsertarInversion.BackgroundImage = global::GUI.Properties.Resources.agregar_producto;
            this.btnInsertarInversion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInsertarInversion.FlatAppearance.BorderSize = 0;
            this.btnInsertarInversion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnInsertarInversion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btnInsertarInversion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertarInversion.Location = new System.Drawing.Point(58, 37);
            this.btnInsertarInversion.Name = "btnInsertarInversion";
            this.btnInsertarInversion.Size = new System.Drawing.Size(120, 104);
            this.btnInsertarInversion.TabIndex = 31;
            this.btnInsertarInversion.UseVisualStyleBackColor = false;
            // 
            // btnModificarInversion
            // 
            this.btnModificarInversion.BackColor = System.Drawing.Color.DarkBlue;
            this.btnModificarInversion.BackgroundImage = global::GUI.Properties.Resources.papel_escrito;
            this.btnModificarInversion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModificarInversion.FlatAppearance.BorderSize = 0;
            this.btnModificarInversion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnModificarInversion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btnModificarInversion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarInversion.Location = new System.Drawing.Point(58, 161);
            this.btnModificarInversion.Name = "btnModificarInversion";
            this.btnModificarInversion.Size = new System.Drawing.Size(120, 104);
            this.btnModificarInversion.TabIndex = 30;
            this.btnModificarInversion.UseVisualStyleBackColor = false;
            // 
            // btnEliminarInversion
            // 
            this.btnEliminarInversion.BackColor = System.Drawing.Color.DarkBlue;
            this.btnEliminarInversion.BackgroundImage = global::GUI.Properties.Resources.eliminar_producto;
            this.btnEliminarInversion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminarInversion.FlatAppearance.BorderSize = 0;
            this.btnEliminarInversion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnEliminarInversion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btnEliminarInversion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarInversion.Location = new System.Drawing.Point(58, 280);
            this.btnEliminarInversion.Name = "btnEliminarInversion";
            this.btnEliminarInversion.Size = new System.Drawing.Size(120, 104);
            this.btnEliminarInversion.TabIndex = 29;
            this.btnEliminarInversion.UseVisualStyleBackColor = false;
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
            this.btnVolverMenu.TabIndex = 28;
            this.btnVolverMenu.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkBlue;
            this.pictureBox1.Location = new System.Drawing.Point(0, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 520);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.label7.TabIndex = 32;
            this.label7.Text = "JJCO10";
            // 
            // frmCrudInversiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 510);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCrudInversiones";
            this.Text = "Gestion de Inversiones";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaInversiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvConsultaInversiones;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtIdInversion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaInversion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIdInversion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFechaInversion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrecioInversion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnInsertarInversion;
        private System.Windows.Forms.Button btnModificarInversion;
        private System.Windows.Forms.Button btnEliminarInversion;
        private System.Windows.Forms.Button btnVolverMenu;
        private System.Windows.Forms.Label label7;
    }
}