namespace GitTestManager
{
    partial class GitTestManagerForm
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
            this.br_generateRepository = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // br_generateRepository
            // 
            this.br_generateRepository.Location = new System.Drawing.Point(82, 12);
            this.br_generateRepository.Name = "br_generateRepository";
            this.br_generateRepository.Size = new System.Drawing.Size(120, 23);
            this.br_generateRepository.TabIndex = 0;
            this.br_generateRepository.Text = "Crear Repositorios";
            this.br_generateRepository.UseVisualStyleBackColor = true;
            this.br_generateRepository.Click += new System.EventHandler(this.br_generateRepository_Click);
            // 
            // GitTestManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.br_generateRepository);
            this.Name = "GitTestManagerForm";
            this.Text = "Git Test Manager 1.0";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button br_generateRepository;
    }
}

