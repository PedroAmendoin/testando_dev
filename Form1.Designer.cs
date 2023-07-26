namespace testando
{
    partial class FrmCliente
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.avançar = new System.Windows.Forms.Button();
            this.Txtnome = new System.Windows.Forms.TextBox();
            this.cadastro = new System.Windows.Forms.Label();
            this.conectar = new System.Windows.Forms.Button();
            this.Txtsenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // avançar
            // 
            this.avançar.Location = new System.Drawing.Point(172, 212);
            this.avançar.Name = "avançar";
            this.avançar.Size = new System.Drawing.Size(440, 32);
            this.avançar.TabIndex = 0;
            this.avançar.Text = "go";
            this.avançar.UseVisualStyleBackColor = true;
            this.avançar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Txtnome
            // 
            this.Txtnome.Location = new System.Drawing.Point(172, 132);
            this.Txtnome.Name = "Txtnome";
            this.Txtnome.Size = new System.Drawing.Size(440, 20);
            this.Txtnome.TabIndex = 1;
            this.Txtnome.Text = "digite seu nome...";
            this.Txtnome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cadastro
            // 
            this.cadastro.AutoSize = true;
            this.cadastro.Location = new System.Drawing.Point(138, 132);
            this.cadastro.Name = "cadastro";
            this.cadastro.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cadastro.Size = new System.Drawing.Size(27, 13);
            this.cadastro.TabIndex = 2;
            this.cadastro.Text = "nom";
            this.cadastro.Click += new System.EventHandler(this.label1_Click);
            // 
            // conectar
            // 
            this.conectar.Location = new System.Drawing.Point(360, 286);
            this.conectar.Name = "conectar";
            this.conectar.Size = new System.Drawing.Size(75, 23);
            this.conectar.TabIndex = 3;
            this.conectar.Text = "conec";
            this.conectar.UseVisualStyleBackColor = true;
            this.conectar.Click += new System.EventHandler(this.conectar_Click);
            // 
            // Txtsenha
            // 
            this.Txtsenha.Location = new System.Drawing.Point(172, 176);
            this.Txtsenha.Name = "Txtsenha";
            this.Txtsenha.Size = new System.Drawing.Size(440, 20);
            this.Txtsenha.TabIndex = 4;
            this.Txtsenha.Text = "digite a senha...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "senha";
            // 
            // FrmCliente
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txtsenha);
            this.Controls.Add(this.conectar);
            this.Controls.Add(this.cadastro);
            this.Controls.Add(this.Txtnome);
            this.Controls.Add(this.avançar);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCliente";
            this.Text = "eae";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button avançar;
        private System.Windows.Forms.TextBox Txtnome;
        private System.Windows.Forms.Label cadastro;
        private System.Windows.Forms.Button conectar;
        private System.Windows.Forms.TextBox Txtsenha;
        private System.Windows.Forms.Label label1;
    }
}

