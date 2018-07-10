namespace Sistema_Escola
{
    partial class Controle_de_Fluxo_de_Caixa
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
            this.button1 = new System.Windows.Forms.Button();
            this.texto_ano = new System.Windows.Forms.TextBox();
            this.texto_bimestre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gerar Valor do Lucro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // texto_ano
            // 
            this.texto_ano.Location = new System.Drawing.Point(139, 46);
            this.texto_ano.Name = "texto_ano";
            this.texto_ano.Size = new System.Drawing.Size(100, 20);
            this.texto_ano.TabIndex = 1;
            // 
            // texto_bimestre
            // 
            this.texto_bimestre.Location = new System.Drawing.Point(139, 72);
            this.texto_bimestre.Name = "texto_bimestre";
            this.texto_bimestre.Size = new System.Drawing.Size(100, 20);
            this.texto_bimestre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ano:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bimestre:";
            // 
            // Controle_de_Fluxo_de_Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.texto_bimestre);
            this.Controls.Add(this.texto_ano);
            this.Controls.Add(this.button1);
            this.Name = "Controle_de_Fluxo_de_Caixa";
            this.Text = "Controle_de_Fluxo_de_Caixa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox texto_ano;
        private System.Windows.Forms.TextBox texto_bimestre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}