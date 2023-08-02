namespace testando
{
    partial class frm_login
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
            this.usuario = new System.Windows.Forms.TextBox();
            this.senha = new System.Windows.Forms.TextBox();
            this.btn_logar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(275, 167);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(218, 20);
            this.usuario.TabIndex = 0;
            this.usuario.Text = "digite o usuario...";
            this.usuario.TextChanged += new System.EventHandler(this.senha_TextChanged);
            // 
            // senha
            // 
            this.senha.Location = new System.Drawing.Point(275, 227);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(218, 20);
            this.senha.TabIndex = 1;
            this.senha.Text = "digite a senha...";
            this.senha.TextChanged += new System.EventHandler(this.senha_TextChanged_1);
            // 
            // btn_logar
            // 
            this.btn_logar.Location = new System.Drawing.Point(275, 282);
            this.btn_logar.Name = "btn_logar";
            this.btn_logar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_logar.Size = new System.Drawing.Size(75, 23);
            this.btn_logar.TabIndex = 2;
            this.btn_logar.Text = "logar";
            this.btn_logar.UseVisualStyleBackColor = true;
            this.btn_logar.Click += new System.EventHandler(this.btn_logar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(418, 282);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 2;
            this.btn_cancelar.Text = "cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_logar);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.usuario);
            this.Name = "frm_login";
            this.Text = "frm_login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.TextBox senha;
        private System.Windows.Forms.Button btn_logar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}