﻿namespace GUI
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnInsertarVenta = new System.Windows.Forms.Button();
            this.btnModificarVenta = new System.Windows.Forms.Button();
            this.btnEliminarVenta = new System.Windows.Forms.Button();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.txtIdBoli = new System.Windows.Forms.TextBox();
            this.txtSaborBoli = new System.Windows.Forms.TextBox();
            this.txtPrecioTotalBoli = new System.Windows.Forms.TextBox();
            this.txtCantidadBoli = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MidnightBlue;
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
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.btnBuscar);
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
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::GUI.Properties.Resources.inserte_moneda1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(499, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(456, 488);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkBlue;
            this.btnBuscar.BackgroundImage = global::GUI.Properties.Resources.buscarVenta;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(58, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(106, 92);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.UseVisualStyleBackColor = false;
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
            this.btnInsertarVenta.Location = new System.Drawing.Point(58, 120);
            this.btnInsertarVenta.Name = "btnInsertarVenta";
            this.btnInsertarVenta.Size = new System.Drawing.Size(106, 92);
            this.btnInsertarVenta.TabIndex = 5;
            this.btnInsertarVenta.UseVisualStyleBackColor = false;
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
            this.btnModificarVenta.Location = new System.Drawing.Point(58, 218);
            this.btnModificarVenta.Name = "btnModificarVenta";
            this.btnModificarVenta.Size = new System.Drawing.Size(106, 92);
            this.btnModificarVenta.TabIndex = 4;
            this.btnModificarVenta.UseVisualStyleBackColor = false;
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
            this.btnEliminarVenta.Location = new System.Drawing.Point(58, 316);
            this.btnEliminarVenta.Name = "btnEliminarVenta";
            this.btnEliminarVenta.Size = new System.Drawing.Size(106, 92);
            this.btnEliminarVenta.TabIndex = 3;
            this.btnEliminarVenta.UseVisualStyleBackColor = false;
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
            this.btnVolverMenu.Location = new System.Drawing.Point(58, 414);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(106, 92);
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(264, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Codigo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(264, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fecha de Venta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cyan;
            this.label3.Location = new System.Drawing.Point(264, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sabor del Boli";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(264, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cantidad de Bolis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Cyan;
            this.label5.Location = new System.Drawing.Point(264, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Precio Total";
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Location = new System.Drawing.Point(269, 172);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaVenta.TabIndex = 13;
            // 
            // txtIdBoli
            // 
            this.txtIdBoli.Location = new System.Drawing.Point(269, 73);
            this.txtIdBoli.Name = "txtIdBoli";
            this.txtIdBoli.Size = new System.Drawing.Size(200, 20);
            this.txtIdBoli.TabIndex = 14;
            // 
            // txtSaborBoli
            // 
            this.txtSaborBoli.Location = new System.Drawing.Point(269, 279);
            this.txtSaborBoli.Name = "txtSaborBoli";
            this.txtSaborBoli.Size = new System.Drawing.Size(200, 20);
            this.txtSaborBoli.TabIndex = 15;
            // 
            // txtPrecioTotalBoli
            // 
            this.txtPrecioTotalBoli.Location = new System.Drawing.Point(269, 486);
            this.txtPrecioTotalBoli.Name = "txtPrecioTotalBoli";
            this.txtPrecioTotalBoli.Size = new System.Drawing.Size(200, 20);
            this.txtPrecioTotalBoli.TabIndex = 16;
            // 
            // txtCantidadBoli
            // 
            this.txtCantidadBoli.Location = new System.Drawing.Point(269, 386);
            this.txtCantidadBoli.Name = "txtCantidadBoli";
            this.txtCantidadBoli.Size = new System.Drawing.Size(200, 20);
            this.txtCantidadBoli.TabIndex = 17;
            // 
            // frmCrudVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 510);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCrudVentas";
            this.Text = "Gestion de Ventas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnInsertarVenta;
        private System.Windows.Forms.Button btnModificarVenta;
        private System.Windows.Forms.Button btnEliminarVenta;
        private System.Windows.Forms.Button btnVolverMenu;
        private System.Windows.Forms.PictureBox pictureBox2;
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
    }
}