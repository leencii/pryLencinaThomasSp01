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
        int intentos = 0;//contador de intentos
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((txtBoxUser.Text == "Administrador" && txtBoxPassword.Text == "admin" ) ||(txtBoxUser.Text == "Operario" && txtBoxPassword.Text == "Operador"))

            {
                this.Hide();//oculta el formulario
                frmInicio1 f = new frmInicio1();//crea el frmInicio
                f.Text = txtBoxUser.Text;//asigna el texto de titulo
                f.ShowDialog();//visualiza y ejecuta el frmInicio
                this.Show();//visualiza nuevamente este frm
            }
            else
            {
                MessageBox.Show("Datos Incorrectos.Acceso Denegado");
                intentos++;//incrementa el contador de intentos fallidos
                if (intentos == 3)//si es 3 se cierra el frm
                {
                    this.Close();
                }
            }
        }
        //evento Click del boton "btnCancelar"
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
