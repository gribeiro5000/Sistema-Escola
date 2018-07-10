namespace Sistema_Escola
{
    partial class Controle_de_inadimplencia
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
            this.botao_inadimplencia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.texto_ano = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.texto_bimestre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // botao_inadimplencia
            // 
            this.botao_inadimplencia.Location = new System.Drawing.Point(97, 178);
            this.botao_inadimplencia.Name = "botao_inadimplencia";
            this.botao_inadimplencia.Size = new System.Drawing.Size(122, 23);
            this.botao_inadimplencia.TabIndex = 0;
            this.botao_inadimplencia.Text = "cê qué vê essa porra";
            this.botao_inadimplencia.UseVisualStyleBackColor = true;
            this.botao_inadimplencia.Click += new System.EventHandler(this.botao_inadimplencia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ano:";
            // 
            // texto_ano
            // 
            this.texto_ano.Location = new System.Drawing.Point(137, 41);
            this.texto_ano.Name = "texto_ano";
            this.texto_ano.Size = new System.Drawing.Size(100, 20);
            this.texto_ano.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Biméstre:";
            // 
            // texto_bimestre
            // 
            this.texto_bimestre.Location = new System.Drawing.Point(137, 67);
            this.texto_bimestre.Name = "texto_bimestre";
            this.texto_bimestre.Size = new System.Drawing.Size(100, 20);
            this.texto_bimestre.TabIndex = 4;
            // 
            // Controle_de_inadimplencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 246);
            this.Controls.Add(this.texto_bimestre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.texto_ano);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botao_inadimplencia);
            this.Name = "Controle_de_inadimplencia";
            this.Text = "Controle_de_inadimplencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botao_inadimplencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox texto_ano;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox texto_bimestre;
    }
}