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
    public partial class FrmPrincipal : Form
    {
        int idusu;
        UsuarioController usController=new UsuarioController();
        UsuarioModelo usModelo=new UsuarioModelo();
        public FrmPrincipal(int codigo)
        {
            idusu = codigo;
            MessageBox.Show("Seja bem vindo Id" + codigo);
            InitializeComponent();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente usuario = new FrmCliente();
            usuario.MdiParent = this;
            usuario.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            usModelo = usController.CarregaUsuario(idusu);
            label1.Text = usModelo.nome;
            if(usModelo.idperfil==2)
            {
                usuarioToolStripMenuItem.Visible = false;
            }
            else
            {
                if(usModelo.idperfil==2)
                {
                    usuarioToolStripMenuItem.Visible = true;
                }
            }
        }

        private void informaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frmlistar = new FrmCliente();
            frmlistar.Show();   
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
