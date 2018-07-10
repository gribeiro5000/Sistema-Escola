namespace Sistema_Escola
{
    partial class Login_Aluno
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
            this.bt_login = new System.Windows.Forms.Button();
            this.textbox_senha = new System.Windows.Forms.TextBox();
            this.textbox_usuario = new System.Windows.Forms.TextBox();
            this.label_senha = new System.Windows.Forms.Label();
            this.label_usuario = new System.Windows.Forms.Label();
            this.bt_cadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_login
            // 
            this.bt_login.Location = new System.Drawing.Point(138, 148);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(75, 23);
            this.bt_login.TabIndex = 9;
            this.bt_login.Text = "Login";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // textbox_senha
            // 
            this.textbox_senha.Location = new System.Drawing.Point(138, 85);
            this.textbox_senha.Name = "textbox_senha";
            this.textbox_senha.Size = new System.Drawing.Size(100, 20);
            this.textbox_senha.TabIndex = 8;
            // 
            // textbox_usuario
            // 
            this.textbox_usuario.Location = new System.Drawing.Point(138, 59);
            this.textbox_usuario.Name = "textbox_usuario";
            this.textbox_usuario.Size = new System.Drawing.Size(100, 20);
            this.textbox_usuario.TabIndex = 7;
            // 
            // label_senha
            // 
            this.label_senha.AutoSize = true;
            this.label_senha.Location = new System.Drawing.Point(91, 89);
            this.label_senha.Name = "label_senha";
            this.label_senha.Size = new System.Drawing.Size(41, 13);
            this.label_senha.TabIndex = 6;
            this.label_senha.Text = "Senha:";
            // 
            // label_usuario
            // 
            this.label_usuario.AutoSize = true;
            this.label_usuario.Location = new System.Drawing.Point(86, 62);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(46, 13);
            this.label_usuario.TabIndex = 5;
            this.label_usuario.Text = "Usuário:";
            // 
            // bt_cadastro
            // 
            this.bt_cadastro.Location = new System.Drawing.Point(138, 178);
            this.bt_cadastro.Name = "bt_cadastro";
            this.bt_cadastro.Size = new System.Drawing.Size(75, 23);
            this.bt_cadastro.TabIndex = 10;
            this.bt_cadastro.Text = "Cadastro";
            this.bt_cadastro.UseVisualStyleBackColor = true;
            this.bt_cadastro.Click += new System.EventHandler(this.bt_cadastro_Click);
            // 
            // Login_Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 306);
            this.Controls.Add(this.bt_cadastro);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.textbox_senha);
            this.Controls.Add(this.textbox_usuario);
            this.Controls.Add(this.label_senha);
            this.Controls.Add(this.label_usuario);
            this.Name = "Login_Aluno";
            this.Text = "Login_Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.TextBox textbox_senha;
        private System.Windows.Forms.TextBox textbox_usuario;
        private System.Windows.Forms.Label label_senha;
        private System.Windows.Forms.Label label_usuario;
        private System.Windows.Forms.Button bt_cadastro;
    }
}