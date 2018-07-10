namespace Sistema_Escola
{
    partial class Avaliação_do_Professor
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
            this.texto_nota = new System.Windows.Forms.TextBox();
            this.texto_bimestre = new System.Windows.Forms.TextBox();
            this.texto_ano = new System.Windows.Forms.TextBox();
            this.texto_id_professor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.texto_id_aluno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // texto_nota
            // 
            this.texto_nota.Location = new System.Drawing.Point(134, 149);
            this.texto_nota.Name = "texto_nota";
            this.texto_nota.Size = new System.Drawing.Size(100, 20);
            this.texto_nota.TabIndex = 21;
            // 
            // texto_bimestre
            // 
            this.texto_bimestre.Location = new System.Drawing.Point(134, 123);
            this.texto_bimestre.Name = "texto_bimestre";
            this.texto_bimestre.Size = new System.Drawing.Size(100, 20);
            this.texto_bimestre.TabIndex = 20;
            // 
            // texto_ano
            // 
            this.texto_ano.Location = new System.Drawing.Point(134, 97);
            this.texto_ano.Name = "texto_ano";
            this.texto_ano.Size = new System.Drawing.Size(100, 20);
            this.texto_ano.TabIndex = 19;
            // 
            // texto_id_professor
            // 
            this.texto_id_professor.Location = new System.Drawing.Point(134, 71);
            this.texto_id_professor.Name = "texto_id_professor";
            this.texto_id_professor.Size = new System.Drawing.Size(100, 20);
            this.texto_id_professor.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nota:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Biméstre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ano:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Id do professor:";
            // 
            // texto_id_aluno
            // 
            this.texto_id_aluno.Location = new System.Drawing.Point(134, 45);
            this.texto_id_aluno.Name = "texto_id_aluno";
            this.texto_id_aluno.Size = new System.Drawing.Size(100, 20);
            this.texto_id_aluno.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Id do aluno:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Enviar Avaliação";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Avaliação_do_Professor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 289);
            this.Controls.Add(this.texto_nota);
            this.Controls.Add(this.texto_bimestre);
            this.Controls.Add(this.texto_ano);
            this.Controls.Add(this.texto_id_professor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.texto_id_aluno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Avaliação_do_Professor";
            this.Text = "Avaliação_do_Professor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox texto_nota;
        private System.Windows.Forms.TextBox texto_bimestre;
        private System.Windows.Forms.TextBox texto_ano;
        private System.Windows.Forms.TextBox texto_id_professor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox texto_id_aluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}