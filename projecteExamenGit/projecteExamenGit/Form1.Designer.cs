namespace projecteExamenGit
{
    partial class frmMain
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
            this.btAnimal = new System.Windows.Forms.Button();
            this.btViatge = new System.Windows.Forms.Button();
            this.btMenjar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAnimal
            // 
            this.btAnimal.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btAnimal.ForeColor = System.Drawing.Color.Chocolate;
            this.btAnimal.Location = new System.Drawing.Point(93, 88);
            this.btAnimal.Name = "btAnimal";
            this.btAnimal.Size = new System.Drawing.Size(75, 23);
            this.btAnimal.TabIndex = 0;
            this.btAnimal.Text = "Animal";
            this.btAnimal.UseVisualStyleBackColor = false;
            this.btAnimal.Click += new System.EventHandler(this.btAnimal_Click);
            // 
            // btViatge
            // 
            this.btViatge.BackColor = System.Drawing.Color.Tomato;
            this.btViatge.ForeColor = System.Drawing.Color.Gold;
            this.btViatge.Location = new System.Drawing.Point(195, 88);
            this.btViatge.Name = "btViatge";
            this.btViatge.Size = new System.Drawing.Size(75, 23);
            this.btViatge.TabIndex = 1;
            this.btViatge.Text = "Viatge";
            this.btViatge.UseVisualStyleBackColor = false;
            this.btViatge.Click += new System.EventHandler(this.btViatge_Click);
            // 
            // btMenjar
            // 
            this.btMenjar.BackColor = System.Drawing.Color.GreenYellow;
            this.btMenjar.ForeColor = System.Drawing.Color.Gold;
            this.btMenjar.Location = new System.Drawing.Point(147, 135);
            this.btMenjar.Name = "btMenjar";
            this.btMenjar.Size = new System.Drawing.Size(75, 23);
            this.btMenjar.TabIndex = 2;
            this.btMenjar.Text = "Menjar";
            this.btMenjar.UseVisualStyleBackColor = false;
            this.btMenjar.Click += new System.EventHandler(this.btMenjar_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 192);
            this.Controls.Add(this.btMenjar);
            this.Controls.Add(this.btViatge);
            this.Controls.Add(this.btAnimal);
            this.Name = "frmMain";
            this.Text = "main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAnimal;
        private System.Windows.Forms.Button btViatge;
        private System.Windows.Forms.Button btMenjar;
    }
}

