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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnInsertarVenta = new System.Windows.Forms.Button();
            this.btnModificarVenta = new System.Windows.Forms.Button();
            this.btnEliminarVenta = new System.Windows.Forms.Button();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MidnightBlue;
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
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkBlue;
            this.btnBuscar.BackgroundImage = global::GUI.Properties.Resources.buscarVenta;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
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
            this.btnInsertarVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInsertarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
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
            this.btnModificarVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnModificarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
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
            this.btnEliminarVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEliminarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
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
            this.btnVolverMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVolverMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVolverMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverMenu.Location = new System.Drawing.Point(58, 414);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(106, 92);
            this.btnVolverMenu.TabIndex = 2;
            this.btnVolverMenu.UseVisualStyleBackColor = false;
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
            // frmCrudVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 510);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCrudVentas";
            this.Text = "Gestion de Ventas";
            this.groupBox1.ResumeLayout(false);
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
    }
}