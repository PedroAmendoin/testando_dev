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
            this.dtUsuario = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnListarUsuario = new System.Windows.Forms.Button();
            this.cboPerfil = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // avançar
            // 
            this.avançar.BackColor = System.Drawing.Color.White;
            this.avançar.Location = new System.Drawing.Point(172, 199);
            this.avançar.Name = "avançar";
            this.avançar.Size = new System.Drawing.Size(440, 32);
            this.avançar.TabIndex = 0;
            this.avançar.Text = "go";
            this.avançar.UseVisualStyleBackColor = false;
            this.avançar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Txtnome
            // 
            this.Txtnome.Location = new System.Drawing.Point(172, 90);
            this.Txtnome.Name = "Txtnome";
            this.Txtnome.Size = new System.Drawing.Size(440, 20);
            this.Txtnome.TabIndex = 1;
            this.Txtnome.Text = "digite seu nome...";
            this.Txtnome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cadastro
            // 
            this.cadastro.AutoSize = true;
            this.cadastro.Location = new System.Drawing.Point(134, 93);
            this.cadastro.Name = "cadastro";
            this.cadastro.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cadastro.Size = new System.Drawing.Size(27, 13);
            this.cadastro.TabIndex = 2;
            this.cadastro.Text = "nom";
            this.cadastro.Click += new System.EventHandler(this.label1_Click);
            // 
            // conectar
            // 
            this.conectar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.conectar.Location = new System.Drawing.Point(357, 253);
            this.conectar.Name = "conectar";
            this.conectar.Size = new System.Drawing.Size(75, 23);
            this.conectar.TabIndex = 3;
            this.conectar.Text = "conec";
            this.conectar.UseVisualStyleBackColor = false;
            this.conectar.Click += new System.EventHandler(this.conectar_Click);
            // 
            // Txtsenha
            // 
            this.Txtsenha.Location = new System.Drawing.Point(172, 147);
            this.Txtsenha.Name = "Txtsenha";
            this.Txtsenha.Size = new System.Drawing.Size(440, 20);
            this.Txtsenha.TabIndex = 4;
            this.Txtsenha.Text = "digite a senha...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "senha";
            // 
            // dtUsuario
            // 
            this.dtUsuario.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtUsuario.Location = new System.Drawing.Point(172, 288);
            this.dtUsuario.Name = "dtUsuario";
            this.dtUsuario.Size = new System.Drawing.Size(440, 150);
            this.dtUsuario.TabIndex = 6;
            this.dtUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtUsuario_CellClick);
            this.dtUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(477, 252);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(585, 252);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "atualizar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnListarUsuario
            // 
            this.btnListarUsuario.Location = new System.Drawing.Point(643, 376);
            this.btnListarUsuario.Name = "btnListarUsuario";
            this.btnListarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnListarUsuario.TabIndex = 9;
            this.btnListarUsuario.Text = "avançar";
            this.btnListarUsuario.UseVisualStyleBackColor = true;
            this.btnListarUsuario.Click += new System.EventHandler(this.btnListarUsuario_Click);
            // 
            // cboPerfil
            // 
            this.cboPerfil.FormattingEnabled = true;
            this.cboPerfil.Location = new System.Drawing.Point(172, 48);
            this.cboPerfil.Name = "cboPerfil";
            this.cboPerfil.Size = new System.Drawing.Size(440, 21);
            this.cboPerfil.TabIndex = 10;
            this.cboPerfil.SelectedIndexChanged += new System.EventHandler(this.cboPerfil_SelectedIndexChanged);
            // 
            // FrmCliente
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.cboPerfil);
            this.Controls.Add(this.btnListarUsuario);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dtUsuario);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eae";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DpiChangedAfterParent += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtUsuario)).EndInit();
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
        private System.Windows.Forms.DataGridView dtUsuario;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnListarUsuario;
        private System.Windows.Forms.ComboBox cboPerfil;
    }
}

