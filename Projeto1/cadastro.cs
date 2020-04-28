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
    public partial class frmcadastro : Form
    {
        public frmcadastro()
        {
            InitializeComponent();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastro efetuado com sucesso");
            
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            //TextBox clear code
            txtnomedaempresa.Text = "";
            txtrepetir.Text = "";
            txtsenhacadastro.Text = "";

        }
    }
}
