namespace pruebaLabelTextbox
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.labelTextbox1 = new NuevosComponentes.LabelTextbox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cambiar Posicion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(249, 297);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Introduce nueva separación";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(259, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Aceptar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelTextbox1
            // 
            this.labelTextbox1.Location = new System.Drawing.Point(178, 120);
            this.labelTextbox1.Name = "labelTextbox1";
            this.labelTextbox1.Posicion = NuevosComponentes.LabelTextbox.ePosicion.IZQUIERDA;
            this.labelTextbox1.PswChar = '*';
            this.labelTextbox1.Separacion = 12;
            this.labelTextbox1.Size = new System.Drawing.Size(222, 22);
            this.labelTextbox1.TabIndex = 0;
            this.labelTextbox1.TextLbl = "LabelTextbox";
            this.labelTextbox1.TextTxt = "";
            this.labelTextbox1.CambiaPosicion += new System.EventHandler(this.labelTextbox1_CambiaPosicion);
            this.labelTextbox1.CambiaSeparacion += new System.EventHandler(this.labelTextbox1_CambiaSeparacion);
            this.labelTextbox1.TxtChanged += new System.EventHandler(this.labelTextbox1_TxtChanged);
            this.labelTextbox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.labelTextbox1_KeyPress);
            this.labelTextbox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.labelTextbox1_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTextbox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NuevosComponentes.LabelTextbox labelTextbox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}

