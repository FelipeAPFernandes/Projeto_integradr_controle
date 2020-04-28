using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Projeto1
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                //chamar banco de dados 
                MySqlConnection con = new MySqlConnection("server=localhost;port=3307;User Id=root; database=login;passaword=usbw");
                con.Open();  //abrir banco de dados 
                MessageBox.Show("Conectado");
                con.Close();

            }
            catch
            {
                MessageBox.Show("deu ruim");
            }

            this.Hide();
            Form f = new mPrincipal();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkcadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmcadastro frm = new frmcadastro();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }
    }
}
