namespace Sistema_Escola
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bemvindo = new System.Windows.Forms.Label();
            this.bt_professor = new System.Windows.Forms.Button();
            this.bt_aluno = new System.Windows.Forms.Button();
            this.bt_atendimento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // bemvindo
            // 
            this.bemvindo.AutoSize = true;
            this.bemvindo.Location = new System.Drawing.Point(142, 43);
            this.bemvindo.Name = "bemvindo";
            this.bemvindo.Size = new System.Drawing.Size(56, 13);
            this.bemvindo.TabIndex = 0;
            this.bemvindo.Text = "bem vindo";
            // 
            // bt_professor
            // 
            this.bt_professor.Location = new System.Drawing.Point(133, 92);
            this.bt_professor.Name = "bt_professor";
            this.bt_professor.Size = new System.Drawing.Size(75, 23);
            this.bt_professor.TabIndex = 1;
            this.bt_professor.Text = "Professor";
            this.bt_professor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_professor.UseVisualStyleBackColor = true;
            this.bt_professor.Click += new System.EventHandler(this.bt_professor_Click);
            // 
            // bt_aluno
            // 
            this.bt_aluno.Location = new System.Drawing.Point(133, 122);
            this.bt_aluno.Name = "bt_aluno";
            this.bt_aluno.Size = new System.Drawing.Size(75, 23);
            this.bt_aluno.TabIndex = 2;
            this.bt_aluno.Text = "Aluno";
            this.bt_aluno.UseVisualStyleBackColor = true;
            this.bt_aluno.Click += new System.EventHandler(this.bt_aluno_Click);
            // 
            // bt_atendimento
            // 
            this.bt_atendimento.Location = new System.Drawing.Point(133, 152);
            this.bt_atendimento.Name = "bt_atendimento";
            this.bt_atendimento.Size = new System.Drawing.Size(75, 23);
            this.bt_atendimento.TabIndex = 3;
            this.bt_atendimento.Text = "Atendimento";
            this.bt_atendimento.UseVisualStyleBackColor = true;
            this.bt_atendimento.Click += new System.EventHandler(this.bt_atendimento_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 292);
            this.Controls.Add(this.bt_atendimento);
            this.Controls.Add(this.bt_aluno);
            this.Controls.Add(this.bt_professor);
            this.Controls.Add(this.bemvindo);
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button bt_atendimento;
        private System.Windows.Forms.Button bt_aluno;
        private System.Windows.Forms.Button bt_professor;
        private System.Windows.Forms.Label bemvindo;
    }
}