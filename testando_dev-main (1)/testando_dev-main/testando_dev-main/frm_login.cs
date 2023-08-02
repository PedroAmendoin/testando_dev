using Controller;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testando
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void senha_TextChanged(object sender, EventArgs e)//usuario
        {

        }

        private void senha_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            UsuarioModelo us=new UsuarioModelo();
            UsuarioController uscontrole=new UsuarioController();
            us.nome = usuario.Text;
            us.senha = senha.Text;
            if(string.IsNullOrEmpty(us.nome))
            {
                MessageBox.Show("Nome Vazio");
                usuario.Focus();
            }
            if(string.IsNullOrEmpty(us.senha))
            {
                MessageBox.Show("Senha Vazio");
                usuario.Focus();
            }
            if(uscontrole.logar(us)==true)
            {
                FrmPrincipal principal= new FrmPrincipal();
                principal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario e senha invalidos");
            }
        }
    }
}
