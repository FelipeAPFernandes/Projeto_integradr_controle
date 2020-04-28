using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1
{
    public partial class mPrincipal : Form
    {
        public mPrincipal()
        {
            InitializeComponent();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        internal static void show()
        {
  
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
         
            this.Hide();
            Form f = new frmLogin();
            f.Closed += (s, args) => this.Close();
            f.Show();

        }

        private void novoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblName.Visible = true;
            txtName.Visible = true;
            lblcod.Visible = true;
            txtcod.Visible = true;
            btnsalvar.Visible = true;
            btncan.Visible = true;
            btnDel.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncan_Click(object sender, EventArgs e)
        {
            lblName.Visible = false;
            txtName.Visible = false;
            lblcod.Visible = false;
            txtcod.Visible = false;
            btnsalvar.Visible = false;
            btncan.Visible = false;
            btnDel.Visible = false;
        }

        private void editarEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblName.Visible = true;
            txtName.Visible = true;
            lblcod.Visible = true;
            txtcod.Visible = true;
            btnsalvar.Visible = true;
            btncan.Visible = true;
            btnDel.Visible = true;
        }

        private void despacheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblName.Visible = true;
            txtName.Visible = true;
            lblcod.Visible = true;
            txtcod.Visible = true;
            btnsalvar.Visible = false;
            btncan.Visible = true;
            btnDel.Visible = true;
        }
    }
}
