namespace Sistema_Escola
{
    partial class Homepage_Aluno
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
            this.bt_emissaoboleto = new System.Windows.Forms.Button();
            this.avaliaçao_professor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_emissaoboleto
            // 
            this.bt_emissaoboleto.Location = new System.Drawing.Point(99, 63);
            this.bt_emissaoboleto.Name = "bt_emissaoboleto";
            this.bt_emissaoboleto.Size = new System.Drawing.Size(125, 23);
            this.bt_emissaoboleto.TabIndex = 0;
            this.bt_emissaoboleto.Text = "Emissão de Boleto";
            this.bt_emissaoboleto.UseVisualStyleBackColor = true;
            this.bt_emissaoboleto.Click += new System.EventHandler(this.bt_emissaoboleto_Click);
            // 
            // avaliaçao_professor
            // 
            this.avaliaçao_professor.Location = new System.Drawing.Point(99, 122);
            this.avaliaçao_professor.Name = "avaliaçao_professor";
            this.avaliaçao_professor.Size = new System.Drawing.Size(125, 23);
            this.avaliaçao_professor.TabIndex = 4;
            this.avaliaçao_professor.Text = "Avaliação do Professor";
            this.avaliaçao_professor.UseVisualStyleBackColor = true;
            this.avaliaçao_professor.Click += new System.EventHandler(this.avaliaçao_professor_Click);
            // 
            // Homepage_Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 301);
            this.Controls.Add(this.avaliaçao_professor);
            this.Controls.Add(this.bt_emissaoboleto);
            this.Name = "Homepage_Aluno";
            this.Text = "Homepage_Aluno";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_emissaoboleto;
        private System.Windows.Forms.Button avaliaçao_professor;
    }
}