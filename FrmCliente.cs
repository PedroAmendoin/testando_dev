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
            UsuarioController usControle = new UsuarioController();
            dtUsuario.DataSource = usControle.ObterDados("select * from usuario");
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
            //se campos diferente de vazio entao
            if (usmodelo.nome != "" && usmodelo.senha != "")
            {
                if (uscontrole.cadastrar(usmodelo) == true)
                {
                    MessageBox.Show("Usuário cadastrado com sucesso" + Txtnome.Text);
                }
                else
                {
                    MessageBox.Show("Usuário não cadastrado");
                }
                // MessageBox.Show("nome " + Txtnome.Text);
            }
            else
            {
                MessageBox.Show("Campos estão vazios");
            }
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {//convertendo a 1 celula em inteiro
            int codigo = Convert.ToInt32(dtUsuario.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            //converte o inteiro para string; row é linha, column é coluna e cell é a celula atravessada pela linhae coluna
            MessageBox.Show("Usuario selecionado :" + codigo.ToString());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
