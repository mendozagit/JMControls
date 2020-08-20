namespace Demo
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
            this.jmTextbox1 = new JMcontrols.JMTextbox(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.jmTextbox2 = new JMcontrols.JMTextbox(this.components);
            this.SuspendLayout();
            // 
            // jmTextbox1
            // 
            this.jmTextbox1.IsNumerical = true;
            this.jmTextbox1.Location = new System.Drawing.Point(22, 28);
            this.jmTextbox1.Name = "jmTextbox1";
            this.jmTextbox1.PosicionesDecimales = 2;
            this.jmTextbox1.Size = new System.Drawing.Size(100, 20);
            this.jmTextbox1.TabIndex = 0;
            this.jmTextbox1.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Get value";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // jmTextbox2
            // 
            this.jmTextbox2.Location = new System.Drawing.Point(63, 139);
            this.jmTextbox2.Name = "jmTextbox2";
            this.jmTextbox2.PosicionesDecimales = 0;
            this.jmTextbox2.Size = new System.Drawing.Size(100, 20);
            this.jmTextbox2.TabIndex = 2;
            this.jmTextbox2.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.jmTextbox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.jmTextbox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JMcontrols.JMTextbox jmTextbox1;
        private System.Windows.Forms.Button button1;
        private JMcontrols.JMTextbox jmTextbox2;
    }
}

