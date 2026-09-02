using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySP01
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        int intentos = 0;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((txtBoxUser.Text == "Administrador" && txtBoxPassword.Text == "admin" ) ||(txtBoxUser.Text == "Operario" && txtBoxPassword.Text == "Operador"))

            {
                this.Hide();
                frmInicio1 f = new frmInicio1();
                f.Text = txtBoxUser.Text;
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Datos Incorrectos.Acceso Denegado");
                intentos++;
                if (intentos == 3)
                {
                    this.Close();
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
