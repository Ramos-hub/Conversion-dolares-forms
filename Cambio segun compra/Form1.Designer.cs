namespace Cambio_segun_compra
{
    partial class frmCambio
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
            this.gbValores = new System.Windows.Forms.GroupBox();
            this.gbTotal = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblDinero = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtDinero = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gbValores.SuspendLayout();
            this.gbTotal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbValores
            // 
            this.gbValores.Controls.Add(this.lblError);
            this.gbValores.Controls.Add(this.txtDinero);
            this.gbValores.Controls.Add(this.txtCosto);
            this.gbValores.Controls.Add(this.lblDinero);
            this.gbValores.Controls.Add(this.lblCosto);
            this.gbValores.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbValores.Location = new System.Drawing.Point(1, 0);
            this.gbValores.Name = "gbValores";
            this.gbValores.Size = new System.Drawing.Size(580, 269);
            this.gbValores.TabIndex = 0;
            this.gbValores.TabStop = false;
            this.gbValores.Text = "Ingreso de valores";
            // 
            // gbTotal
            // 
            this.gbTotal.Controls.Add(this.txtTotal);
            this.gbTotal.Controls.Add(this.lblTotal);
            this.gbTotal.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTotal.Location = new System.Drawing.Point(1, 301);
            this.gbTotal.Name = "gbTotal";
            this.gbTotal.Size = new System.Drawing.Size(580, 137);
            this.gbTotal.TabIndex = 1;
            this.gbTotal.TabStop = false;
            this.gbTotal.Text = "Total";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnCalcular);
            this.panel1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(604, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 306);
            this.panel1.TabIndex = 5;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(11, 48);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(197, 20);
            this.lblCosto.TabIndex = 5;
            this.lblCosto.Text = "Costo del producto :";
            // 
            // lblDinero
            // 
            this.lblDinero.AutoSize = true;
            this.lblDinero.Location = new System.Drawing.Point(11, 166);
            this.lblDinero.Name = "lblDinero";
            this.lblDinero.Size = new System.Drawing.Size(185, 20);
            this.lblDinero.TabIndex = 6;
            this.lblDinero.Text = "Dinero a entregar :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(11, 68);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(196, 20);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total de la compra :";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(213, 45);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(248, 27);
            this.txtCosto.TabIndex = 7;
            // 
            // txtDinero
            // 
            this.txtDinero.Location = new System.Drawing.Point(213, 163);
            this.txtDinero.Name = "txtDinero";
            this.txtDinero.Size = new System.Drawing.Size(248, 27);
            this.txtDinero.TabIndex = 8;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(213, 65);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(248, 27);
            this.txtTotal.TabIndex = 9;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(11, 227);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(52, 20);
            this.lblError.TabIndex = 5;
            this.lblError.Text = "Error";
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.Image = global::Cambio_segun_compra.Properties.Resources.icons8_salida_321;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSalir.Location = new System.Drawing.Point(0, 232);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(131, 74);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = global::Cambio_segun_compra.Properties.Resources.icons8_escoba_32;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(0, 118);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(131, 81);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalcular.Image = global::Cambio_segun_compra.Properties.Resources.icons8_flecha_direccional_horizontal_32;
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCalcular.Location = new System.Drawing.Point(0, 0);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(131, 80);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbTotal);
            this.Controls.Add(this.gbValores);
            this.Name = "frmCambio";
            this.Text = "Cambio segun compra";
            this.gbValores.ResumeLayout(false);
            this.gbValores.PerformLayout();
            this.gbTotal.ResumeLayout(false);
            this.gbTotal.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbValores;
        private System.Windows.Forms.GroupBox gbTotal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDinero;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label lblDinero;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblError;
    }
}

