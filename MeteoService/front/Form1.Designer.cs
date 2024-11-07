namespace front
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCiudad = new System.Windows.Forms.TextBox();
            this.buttonSolicitar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelWind = new System.Windows.Forms.Label();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ciudad";
            // 
            // textBoxCiudad
            // 
            this.textBoxCiudad.Location = new System.Drawing.Point(58, 39);
            this.textBoxCiudad.Name = "textBoxCiudad";
            this.textBoxCiudad.Size = new System.Drawing.Size(131, 20);
            this.textBoxCiudad.TabIndex = 1;
            // 
            // buttonSolicitar
            // 
            this.buttonSolicitar.Location = new System.Drawing.Point(12, 65);
            this.buttonSolicitar.Name = "buttonSolicitar";
            this.buttonSolicitar.Size = new System.Drawing.Size(177, 23);
            this.buttonSolicitar.TabIndex = 2;
            this.buttonSolicitar.Text = "Solicitar Condiciones Actuales";
            this.buttonSolicitar.UseVisualStyleBackColor = true;
            this.buttonSolicitar.Click += new System.EventHandler(this.buttonSolicitar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelTemperature);
            this.groupBox1.Controls.Add(this.labelWind);
            this.groupBox1.Controls.Add(this.labelDescription);
            this.groupBox1.Location = new System.Drawing.Point(15, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(6, 16);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 0;
            this.labelDescription.Text = "Description";
            // 
            // labelWind
            // 
            this.labelWind.AutoSize = true;
            this.labelWind.Location = new System.Drawing.Point(6, 64);
            this.labelWind.Name = "labelWind";
            this.labelWind.Size = new System.Drawing.Size(32, 13);
            this.labelWind.TabIndex = 1;
            this.labelWind.Text = "Wind";
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Location = new System.Drawing.Point(6, 42);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(67, 13);
            this.labelTemperature.TabIndex = 2;
            this.labelTemperature.Text = "Temperature";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 244);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSolicitar);
            this.Controls.Add(this.textBoxCiudad);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCiudad;
        private System.Windows.Forms.Button buttonSolicitar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.Label labelWind;
    }
}

