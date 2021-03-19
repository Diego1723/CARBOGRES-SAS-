using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CARBOGRES_SAS
{
    public partial class registro : Form
    {
        public registro()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Bienvenida atras = new Bienvenida();
            atras.Show();
            this.Hide();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (TxtContraseña.Text == TxtConfirmarCotraseña.Text)
            {

                if (usuarioDAL.CrearUsuario(TxtUsuario.Text, TxtContraseña.Text) > 0)
                {
                    MessageBox.Show("El Usuario Se Creo Con Exito");
                }

                else
                    MessageBox.Show("Error En El Registro");

            }
            else
                MessageBox.Show("Las Contraseñas No Coinciden ");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void registro_Load(object sender, EventArgs e)
        {

        }
    }
    }

