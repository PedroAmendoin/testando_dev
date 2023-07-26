using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Modelo;

namespace testando
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("olá");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //chamo a instancia de modelo usuario
            UsuarioModelo usmodelo = new UsuarioModelo();
            //populo os atributosdo modelo
            usmodelo.nome = Txtnome.Text;
            usmodelo.senha = Txtsenha.Text;
            UsuarioController uscontrole = new UsuarioController();
            if (uscontrole.cadastrar(usmodelo) == true)
            {
                MessageBox.Show("Usuário cadastrado com sucesso");
            }
            else
            {
                MessageBox.Show("Usuário não cadastrado " + Txtnome.Text);
            }
           // MessageBox.Show("nome " + Txtnome.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void conectar_Click(object sender, EventArgs e)
        {

            conexao conexao = new conexao();
            if(conexao.getConexao() == null)
            {
                MessageBox.Show("erro de conexão");
            }
            else
            {
                MessageBox.Show("Acessando o servidor");
            }
            
        }

    }
}
