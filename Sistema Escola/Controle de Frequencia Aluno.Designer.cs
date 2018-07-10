namespace Sistema_Escola
{
    partial class Controle_de_Frequencia_Aluno
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
            this.label1 = new System.Windows.Forms.Label();
            this.texto_id_aluno = new System.Windows.Forms.TextBox();
            this.texto_ano = new System.Windows.Forms.TextBox();
            this.texto_mes = new System.Windows.Forms.TextBox();
            this.texto_dia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Enviar Presença";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id do Aluno:";
            // 
            // texto_id_aluno
            // 
            this.texto_id_aluno.Location = new System.Drawing.Point(132, 21);
            this.texto_id_aluno.Name = "texto_id_aluno";
            this.texto_id_aluno.Size = new System.Drawing.Size(100, 20);
            this.texto_id_aluno.TabIndex = 2;
            // 
            // texto_ano
            // 
            this.texto_ano.Location = new System.Drawing.Point(132, 47);
            this.texto_ano.Name = "texto_ano";
            this.texto_ano.Size = new System.Drawing.Size(100, 20);
            this.texto_ano.TabIndex = 3;
            // 
            // texto_mes
            // 
            this.texto_mes.Location = new System.Drawing.Point(132, 73);
            this.texto_mes.Name = "texto_mes";
            this.texto_mes.Size = new System.Drawing.Size(100, 20);
            this.texto_mes.TabIndex = 4;
            // 
            // texto_dia
            // 
            this.texto_dia.Location = new System.Drawing.Point(132, 99);
            this.texto_dia.Name = "texto_dia";
            this.texto_dia.Size = new System.Drawing.Size(100, 20);
            this.texto_dia.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mês:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ano:";
            // 
            // Controle_de_Frequencia_Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 239);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.texto_dia);
            this.Controls.Add(this.texto_mes);
            this.Controls.Add(this.texto_ano);
            this.Controls.Add(this.texto_id_aluno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Controle_de_Frequencia_Aluno";
            this.Text = "Controle_de_Frequencia_Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox texto_id_aluno;
        private System.Windows.Forms.TextBox texto_ano;
        private System.Windows.Forms.TextBox texto_mes;
        private System.Windows.Forms.TextBox texto_dia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}