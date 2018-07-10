namespace Sistema_Escola
{
    partial class Homepage_Atendimento
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
            this.bt_controlematricula = new System.Windows.Forms.Button();
            this.bt_controleinadimplencia = new System.Windows.Forms.Button();
            this.bt_cfc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_controlematricula
            // 
            this.bt_controlematricula.Location = new System.Drawing.Point(66, 47);
            this.bt_controlematricula.Name = "bt_controlematricula";
            this.bt_controlematricula.Size = new System.Drawing.Size(168, 23);
            this.bt_controlematricula.TabIndex = 0;
            this.bt_controlematricula.Text = "Cancelamento de Matrícula";
            this.bt_controlematricula.UseVisualStyleBackColor = true;
            this.bt_controlematricula.Click += new System.EventHandler(this.bt_controlematricula_Click);
            // 
            // bt_controleinadimplencia
            // 
            this.bt_controleinadimplencia.Location = new System.Drawing.Point(77, 86);
            this.bt_controleinadimplencia.Name = "bt_controleinadimplencia";
            this.bt_controleinadimplencia.Size = new System.Drawing.Size(143, 23);
            this.bt_controleinadimplencia.TabIndex = 1;
            this.bt_controleinadimplencia.Text = "Controle de Inadimplência";
            this.bt_controleinadimplencia.UseVisualStyleBackColor = true;
            this.bt_controleinadimplencia.Click += new System.EventHandler(this.bt_controleinadimplencia_Click);
            // 
            // bt_cfc
            // 
            this.bt_cfc.Location = new System.Drawing.Point(77, 126);
            this.bt_cfc.Name = "bt_cfc";
            this.bt_cfc.Size = new System.Drawing.Size(143, 23);
            this.bt_cfc.TabIndex = 2;
            this.bt_cfc.Text = "Controle de Fluxo de Caixa";
            this.bt_cfc.UseVisualStyleBackColor = true;
            this.bt_cfc.Click += new System.EventHandler(this.bt_cfc_Click);
            // 
            // Homepage_Atendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 281);
            this.Controls.Add(this.bt_cfc);
            this.Controls.Add(this.bt_controleinadimplencia);
            this.Controls.Add(this.bt_controlematricula);
            this.Name = "Homepage_Atendimento";
            this.Text = "Homepage_Atendimento";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_controlematricula;
        private System.Windows.Forms.Button bt_controleinadimplencia;
        private System.Windows.Forms.Button bt_cfc;
    }
}