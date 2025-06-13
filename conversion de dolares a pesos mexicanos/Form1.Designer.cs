namespace conversion_de_dolares_a_pesos_mexicanos
{
    partial class frmConversion
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
            this.gbIngreso = new System.Windows.Forms.GroupBox();
            this.txtDolares = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblDolares = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnConver = new System.Windows.Forms.Button();
            this.gbIngreso.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbIngreso
            // 
            this.gbIngreso.Controls.Add(this.txtDolares);
            this.gbIngreso.Controls.Add(this.txtResultado);
            this.gbIngreso.Controls.Add(this.lblResultado);
            this.gbIngreso.Controls.Add(this.lblError);
            this.gbIngreso.Controls.Add(this.lblDolares);
            this.gbIngreso.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIngreso.Location = new System.Drawing.Point(0, 0);
            this.gbIngreso.Name = "gbIngreso";
            this.gbIngreso.Size = new System.Drawing.Size(446, 290);
            this.gbIngreso.TabIndex = 0;
            this.gbIngreso.TabStop = false;
            this.gbIngreso.Text = "Ingreso de datos";
            // 
            // txtDolares
            // 
            this.txtDolares.Location = new System.Drawing.Point(111, 57);
            this.txtDolares.Name = "txtDolares";
            this.txtDolares.Size = new System.Drawing.Size(203, 27);
            this.txtDolares.TabIndex = 4;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(122, 167);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(203, 27);
            this.txtResultado.TabIndex = 3;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 170);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(115, 20);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Resultado :";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.SystemColors.Control;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(12, 258);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(52, 20);
            this.lblError.TabIndex = 1;
            this.lblError.Text = "Error";
            // 
            // lblDolares
            // 
            this.lblDolares.AutoSize = true;
            this.lblDolares.Location = new System.Drawing.Point(12, 60);
            this.lblDolares.Name = "lblDolares";
            this.lblDolares.Size = new System.Drawing.Size(93, 20);
            this.lblDolares.TabIndex = 0;
            this.lblDolares.Text = "Dólares :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnConver);
            this.panel1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(549, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 290);
            this.panel1.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.Image = global::conversion_de_dolares_a_pesos_mexicanos.Properties.Resources.icons8_salida_32;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(0, 211);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(168, 79);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = global::conversion_de_dolares_a_pesos_mexicanos.Properties.Resources.icons8_escoba_321;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(0, 104);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(168, 76);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnConver
            // 
            this.btnConver.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConver.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConver.Image = global::conversion_de_dolares_a_pesos_mexicanos.Properties.Resources.icons8_flecha_direccional_horizontal_32;
            this.btnConver.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConver.Location = new System.Drawing.Point(0, 0);
            this.btnConver.Name = "btnConver";
            this.btnConver.Size = new System.Drawing.Size(168, 80);
            this.btnConver.TabIndex = 0;
            this.btnConver.Text = "Conversión";
            this.btnConver.UseVisualStyleBackColor = true;
            this.btnConver.Click += new System.EventHandler(this.btnConver_Click);
            // 
            // frmConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbIngreso);
            this.Name = "frmConversion";
            this.Text = "Conversion de dólares a pesos mexicanos";
            this.gbIngreso.ResumeLayout(false);
            this.gbIngreso.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbIngreso;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblDolares;
        private System.Windows.Forms.TextBox txtDolares;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnConver;
    }
}

