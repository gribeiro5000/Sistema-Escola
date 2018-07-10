namespace Sistema_Escola
{
    partial class Lançamento_de_Notas
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
            this.texto_idaluno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.texto_ano = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combobox_materia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.texto_bimestre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.texto_nota = new System.Windows.Forms.TextBox();
            this.botão_lançamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // texto_idaluno
            // 
            this.texto_idaluno.Location = new System.Drawing.Point(147, 40);
            this.texto_idaluno.Name = "texto_idaluno";
            this.texto_idaluno.Size = new System.Drawing.Size(100, 20);
            this.texto_idaluno.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id Aluno:";
            // 
            // texto_ano
            // 
            this.texto_ano.Location = new System.Drawing.Point(146, 93);
            this.texto_ano.Name = "texto_ano";
            this.texto_ano.Size = new System.Drawing.Size(100, 20);
            this.texto_ano.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Matéria:";
            // 
            // combobox_materia
            // 
            this.combobox_materia.FormattingEnabled = true;
            this.combobox_materia.Items.AddRange(new object[] {
            "Português",
            "Matemática",
            "Biologia",
            "Geografia",
            "História"});
            this.combobox_materia.Location = new System.Drawing.Point(146, 66);
            this.combobox_materia.Name = "combobox_materia";
            this.combobox_materia.Size = new System.Drawing.Size(100, 21);
            this.combobox_materia.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ano:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Biméstre:";
            // 
            // texto_bimestre
            // 
            this.texto_bimestre.Location = new System.Drawing.Point(146, 119);
            this.texto_bimestre.Name = "texto_bimestre";
            this.texto_bimestre.Size = new System.Drawing.Size(100, 20);
            this.texto_bimestre.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nota:";
            // 
            // texto_nota
            // 
            this.texto_nota.Location = new System.Drawing.Point(146, 146);
            this.texto_nota.Name = "texto_nota";
            this.texto_nota.Size = new System.Drawing.Size(100, 20);
            this.texto_nota.TabIndex = 9;
            // 
            // botão_lançamento
            // 
            this.botão_lançamento.Location = new System.Drawing.Point(162, 215);
            this.botão_lançamento.Name = "botão_lançamento";
            this.botão_lançamento.Size = new System.Drawing.Size(75, 23);
            this.botão_lançamento.TabIndex = 10;
            this.botão_lançamento.Text = "Lançar Nota";
            this.botão_lançamento.UseVisualStyleBackColor = true;
            this.botão_lançamento.Click += new System.EventHandler(this.botão_lançamento_Click);
            // 
            // Lançamento_de_Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 288);
            this.Controls.Add(this.botão_lançamento);
            this.Controls.Add(this.texto_nota);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.texto_bimestre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combobox_materia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.texto_ano);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.texto_idaluno);
            this.Name = "Lançamento_de_Notas";
            this.Text = "Lançamento_de_Notas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox texto_idaluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox texto_ano;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combobox_materia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox texto_bimestre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox texto_nota;
        private System.Windows.Forms.Button botão_lançamento;
    }
}