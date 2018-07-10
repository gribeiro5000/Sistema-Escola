namespace Sistema_Escola
{
    partial class Homepage_Prof
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
            this.bt_emissaoboletim = new System.Windows.Forms.Button();
            this.bt_lançamentodenotas = new System.Windows.Forms.Button();
            this.bt_cfa = new System.Windows.Forms.Button();
            this.avaliaçao_aluno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_emissaoboletim
            // 
            this.bt_emissaoboletim.Location = new System.Drawing.Point(86, 47);
            this.bt_emissaoboletim.Name = "bt_emissaoboletim";
            this.bt_emissaoboletim.Size = new System.Drawing.Size(123, 23);
            this.bt_emissaoboletim.TabIndex = 0;
            this.bt_emissaoboletim.Text = "Emissão de boletins";
            this.bt_emissaoboletim.UseVisualStyleBackColor = true;
            this.bt_emissaoboletim.Click += new System.EventHandler(this.bt_emissaoboletim_Click);
            // 
            // bt_lançamentodenotas
            // 
            this.bt_lançamentodenotas.Location = new System.Drawing.Point(86, 87);
            this.bt_lançamentodenotas.Name = "bt_lançamentodenotas";
            this.bt_lançamentodenotas.Size = new System.Drawing.Size(125, 23);
            this.bt_lançamentodenotas.TabIndex = 1;
            this.bt_lançamentodenotas.Text = "Lançamento de notas";
            this.bt_lançamentodenotas.UseVisualStyleBackColor = true;
            this.bt_lançamentodenotas.Click += new System.EventHandler(this.bt_lançamentodenotas_Click);
            // 
            // bt_cfa
            // 
            this.bt_cfa.Location = new System.Drawing.Point(86, 129);
            this.bt_cfa.Name = "bt_cfa";
            this.bt_cfa.Size = new System.Drawing.Size(125, 39);
            this.bt_cfa.TabIndex = 2;
            this.bt_cfa.Text = "Controle de frequência de alunos";
            this.bt_cfa.UseVisualStyleBackColor = true;
            this.bt_cfa.Click += new System.EventHandler(this.bt_cfa_Click);
            // 
            // avaliaçao_aluno
            // 
            this.avaliaçao_aluno.Location = new System.Drawing.Point(86, 186);
            this.avaliaçao_aluno.Name = "avaliaçao_aluno";
            this.avaliaçao_aluno.Size = new System.Drawing.Size(125, 23);
            this.avaliaçao_aluno.TabIndex = 3;
            this.avaliaçao_aluno.Text = "Avaliação do Aluno";
            this.avaliaçao_aluno.UseVisualStyleBackColor = true;
            this.avaliaçao_aluno.Click += new System.EventHandler(this.avaliaçao_aluno_Click);
            // 
            // Homepage_Prof
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 250);
            this.Controls.Add(this.avaliaçao_aluno);
            this.Controls.Add(this.bt_cfa);
            this.Controls.Add(this.bt_lançamentodenotas);
            this.Controls.Add(this.bt_emissaoboletim);
            this.Name = "Homepage_Prof";
            this.Text = "Homepage_Prof";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_emissaoboletim;
        private System.Windows.Forms.Button bt_lançamentodenotas;
        private System.Windows.Forms.Button bt_cfa;
        private System.Windows.Forms.Button avaliaçao_aluno;
    }
}