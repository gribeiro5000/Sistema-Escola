﻿namespace Sistema_Escola
{
    partial class Cadastro_Professor
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
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.label_sexo = new System.Windows.Forms.Label();
            this.textbox_idade = new System.Windows.Forms.TextBox();
            this.label_idade = new System.Windows.Forms.Label();
            this.textbox_nome = new System.Windows.Forms.TextBox();
            this.label_Nome = new System.Windows.Forms.Label();
            this.textbox_senha = new System.Windows.Forms.TextBox();
            this.label_Senha = new System.Windows.Forms.Label();
            this.textbox_usuario = new System.Windows.Forms.TextBox();
            this.label_usuario = new System.Windows.Forms.Label();
            this.combobox_sexo = new System.Windows.Forms.ComboBox();
            this.combobox_materia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.Location = new System.Drawing.Point(142, 230);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.bt_cadastrar.TabIndex = 21;
            this.bt_cadastrar.Text = "cadastrar";
            this.bt_cadastrar.UseVisualStyleBackColor = true;
            this.bt_cadastrar.Click += new System.EventHandler(this.bt_cadastrar_Click);
            // 
            // label_sexo
            // 
            this.label_sexo.AutoSize = true;
            this.label_sexo.Location = new System.Drawing.Point(92, 158);
            this.label_sexo.Name = "label_sexo";
            this.label_sexo.Size = new System.Drawing.Size(34, 13);
            this.label_sexo.TabIndex = 19;
            this.label_sexo.Text = "Sexo:";
            // 
            // textbox_idade
            // 
            this.textbox_idade.Location = new System.Drawing.Point(142, 127);
            this.textbox_idade.Name = "textbox_idade";
            this.textbox_idade.Size = new System.Drawing.Size(100, 20);
            this.textbox_idade.TabIndex = 18;
            // 
            // label_idade
            // 
            this.label_idade.AutoSize = true;
            this.label_idade.Location = new System.Drawing.Point(92, 130);
            this.label_idade.Name = "label_idade";
            this.label_idade.Size = new System.Drawing.Size(37, 13);
            this.label_idade.TabIndex = 17;
            this.label_idade.Text = "Idade:";
            // 
            // textbox_nome
            // 
            this.textbox_nome.Location = new System.Drawing.Point(142, 101);
            this.textbox_nome.Name = "textbox_nome";
            this.textbox_nome.Size = new System.Drawing.Size(100, 20);
            this.textbox_nome.TabIndex = 16;
            // 
            // label_Nome
            // 
            this.label_Nome.AutoSize = true;
            this.label_Nome.Location = new System.Drawing.Point(92, 104);
            this.label_Nome.Name = "label_Nome";
            this.label_Nome.Size = new System.Drawing.Size(38, 13);
            this.label_Nome.TabIndex = 15;
            this.label_Nome.Text = "Nome:";
            // 
            // textbox_senha
            // 
            this.textbox_senha.Location = new System.Drawing.Point(142, 75);
            this.textbox_senha.Name = "textbox_senha";
            this.textbox_senha.Size = new System.Drawing.Size(100, 20);
            this.textbox_senha.TabIndex = 14;
            // 
            // label_Senha
            // 
            this.label_Senha.AutoSize = true;
            this.label_Senha.Location = new System.Drawing.Point(92, 78);
            this.label_Senha.Name = "label_Senha";
            this.label_Senha.Size = new System.Drawing.Size(41, 13);
            this.label_Senha.TabIndex = 13;
            this.label_Senha.Text = "Senha:";
            // 
            // textbox_usuario
            // 
            this.textbox_usuario.Location = new System.Drawing.Point(142, 47);
            this.textbox_usuario.Name = "textbox_usuario";
            this.textbox_usuario.Size = new System.Drawing.Size(100, 20);
            this.textbox_usuario.TabIndex = 12;
            // 
            // label_usuario
            // 
            this.label_usuario.AutoSize = true;
            this.label_usuario.Location = new System.Drawing.Point(92, 50);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(46, 13);
            this.label_usuario.TabIndex = 11;
            this.label_usuario.Text = "Usuário:";
            // 
            // combobox_sexo
            // 
            this.combobox_sexo.FormattingEnabled = true;
            this.combobox_sexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.combobox_sexo.Location = new System.Drawing.Point(142, 155);
            this.combobox_sexo.Name = "combobox_sexo";
            this.combobox_sexo.Size = new System.Drawing.Size(100, 21);
            this.combobox_sexo.TabIndex = 22;
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
            this.combobox_materia.Location = new System.Drawing.Point(142, 182);
            this.combobox_materia.Name = "combobox_materia";
            this.combobox_materia.Size = new System.Drawing.Size(100, 21);
            this.combobox_materia.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Matéria:";
            // 
            // Cadastro_Professor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 301);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combobox_materia);
            this.Controls.Add(this.combobox_sexo);
            this.Controls.Add(this.bt_cadastrar);
            this.Controls.Add(this.label_sexo);
            this.Controls.Add(this.textbox_idade);
            this.Controls.Add(this.label_idade);
            this.Controls.Add(this.textbox_nome);
            this.Controls.Add(this.label_Nome);
            this.Controls.Add(this.textbox_senha);
            this.Controls.Add(this.label_Senha);
            this.Controls.Add(this.textbox_usuario);
            this.Controls.Add(this.label_usuario);
            this.Name = "Cadastro_Professor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_cadastrar;
        private System.Windows.Forms.Label label_sexo;
        private System.Windows.Forms.TextBox textbox_idade;
        private System.Windows.Forms.Label label_idade;
        private System.Windows.Forms.TextBox textbox_nome;
        private System.Windows.Forms.Label label_Nome;
        private System.Windows.Forms.TextBox textbox_senha;
        private System.Windows.Forms.Label label_Senha;
        private System.Windows.Forms.TextBox textbox_usuario;
        private System.Windows.Forms.Label label_usuario;
        private System.Windows.Forms.ComboBox combobox_sexo;
        private System.Windows.Forms.ComboBox combobox_materia;
        private System.Windows.Forms.Label label1;
    }
}