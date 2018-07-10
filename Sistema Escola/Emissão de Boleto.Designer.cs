namespace Sistema_Escola
{
    partial class Emissão_de_Boleto
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
            this.botao_emitirboleto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.texto_id_aluno = new System.Windows.Forms.TextBox();
            this.texto_bimestre = new System.Windows.Forms.TextBox();
            this.texto_ano = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.texto_numeroboleto = new System.Windows.Forms.TextBox();
            this.texto_valor = new System.Windows.Forms.TextBox();
            this.botao_pagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botao_emitirboleto
            // 
            this.botao_emitirboleto.Location = new System.Drawing.Point(144, 108);
            this.botao_emitirboleto.Name = "botao_emitirboleto";
            this.botao_emitirboleto.Size = new System.Drawing.Size(75, 23);
            this.botao_emitirboleto.TabIndex = 0;
            this.botao_emitirboleto.Text = "Emitir Boleto";
            this.botao_emitirboleto.UseVisualStyleBackColor = true;
            this.botao_emitirboleto.Click += new System.EventHandler(this.botao_emitirboleto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id do Aluno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Biméstre:";
            // 
            // texto_id_aluno
            // 
            this.texto_id_aluno.Location = new System.Drawing.Point(145, 27);
            this.texto_id_aluno.Name = "texto_id_aluno";
            this.texto_id_aluno.Size = new System.Drawing.Size(100, 20);
            this.texto_id_aluno.TabIndex = 3;
            // 
            // texto_bimestre
            // 
            this.texto_bimestre.Location = new System.Drawing.Point(145, 53);
            this.texto_bimestre.Name = "texto_bimestre";
            this.texto_bimestre.Size = new System.Drawing.Size(100, 20);
            this.texto_bimestre.TabIndex = 4;
            // 
            // texto_ano
            // 
            this.texto_ano.Location = new System.Drawing.Point(145, 82);
            this.texto_ano.Name = "texto_ano";
            this.texto_ano.Size = new System.Drawing.Size(100, 20);
            this.texto_ano.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ano:";
            // 
            // texto_numeroboleto
            // 
            this.texto_numeroboleto.Location = new System.Drawing.Point(82, 152);
            this.texto_numeroboleto.Name = "texto_numeroboleto";
            this.texto_numeroboleto.Size = new System.Drawing.Size(201, 20);
            this.texto_numeroboleto.TabIndex = 7;
            // 
            // texto_valor
            // 
            this.texto_valor.Location = new System.Drawing.Point(145, 178);
            this.texto_valor.Name = "texto_valor";
            this.texto_valor.Size = new System.Drawing.Size(74, 20);
            this.texto_valor.TabIndex = 8;
            // 
            // botao_pagar
            // 
            this.botao_pagar.Location = new System.Drawing.Point(145, 204);
            this.botao_pagar.Name = "botao_pagar";
            this.botao_pagar.Size = new System.Drawing.Size(75, 23);
            this.botao_pagar.TabIndex = 9;
            this.botao_pagar.Text = "Pagar";
            this.botao_pagar.UseVisualStyleBackColor = true;
            this.botao_pagar.Click += new System.EventHandler(this.botao_pagar_Click);
            // 
            // Emissão_de_Boleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 260);
            this.Controls.Add(this.botao_pagar);
            this.Controls.Add(this.texto_valor);
            this.Controls.Add(this.texto_numeroboleto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.texto_ano);
            this.Controls.Add(this.texto_bimestre);
            this.Controls.Add(this.texto_id_aluno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botao_emitirboleto);
            this.Name = "Emissão_de_Boleto";
            this.Text = "Emissão_de_Boleto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botao_emitirboleto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox texto_id_aluno;
        private System.Windows.Forms.TextBox texto_bimestre;
        private System.Windows.Forms.TextBox texto_ano;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox texto_numeroboleto;
        private System.Windows.Forms.TextBox texto_valor;
        private System.Windows.Forms.Button botao_pagar;
    }
}