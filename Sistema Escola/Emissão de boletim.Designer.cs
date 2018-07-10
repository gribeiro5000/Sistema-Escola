namespace Sistema_Escola
{
    partial class Emissão_de_boletim
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
            this.label1 = new System.Windows.Forms.Label();
            this.texto_id_aluno = new System.Windows.Forms.TextBox();
            this.botão_emitirboletim = new System.Windows.Forms.Button();
            this.texto_ano = new System.Windows.Forms.TextBox();
            this.texto_bimestre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id do Aluno:";
            // 
            // texto_id_aluno
            // 
            this.texto_id_aluno.Location = new System.Drawing.Point(150, 42);
            this.texto_id_aluno.Name = "texto_id_aluno";
            this.texto_id_aluno.Size = new System.Drawing.Size(100, 20);
            this.texto_id_aluno.TabIndex = 1;
            // 
            // botão_emitirboletim
            // 
            this.botão_emitirboletim.Location = new System.Drawing.Point(133, 174);
            this.botão_emitirboletim.Name = "botão_emitirboletim";
            this.botão_emitirboletim.Size = new System.Drawing.Size(100, 23);
            this.botão_emitirboletim.TabIndex = 2;
            this.botão_emitirboletim.Text = "Emitir Boletim";
            this.botão_emitirboletim.UseVisualStyleBackColor = true;
            this.botão_emitirboletim.Click += new System.EventHandler(this.botão_emitirboletim_Click);
            // 
            // texto_ano
            // 
            this.texto_ano.Location = new System.Drawing.Point(150, 68);
            this.texto_ano.Name = "texto_ano";
            this.texto_ano.Size = new System.Drawing.Size(100, 20);
            this.texto_ano.TabIndex = 3;
            // 
            // texto_bimestre
            // 
            this.texto_bimestre.Location = new System.Drawing.Point(150, 94);
            this.texto_bimestre.Name = "texto_bimestre";
            this.texto_bimestre.Size = new System.Drawing.Size(100, 20);
            this.texto_bimestre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ano:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Biméstre:";
            // 
            // Emissão_de_boletim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 278);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.texto_bimestre);
            this.Controls.Add(this.texto_ano);
            this.Controls.Add(this.botão_emitirboletim);
            this.Controls.Add(this.texto_id_aluno);
            this.Controls.Add(this.label1);
            this.Name = "Emissão_de_boletim";
            this.Text = "Emissão_de_boletim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox texto_id_aluno;
        private System.Windows.Forms.Button botão_emitirboletim;
        private System.Windows.Forms.TextBox texto_ano;
        private System.Windows.Forms.TextBox texto_bimestre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}