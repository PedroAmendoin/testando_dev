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
        public FrmPrincipal()
        {
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

        }

        private void informaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frmlistar = new FrmCliente();
            frmlistar.Show();   
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
