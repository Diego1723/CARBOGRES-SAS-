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
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bienvenida atras = new Bienvenida();
            atras.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (usuarioDAL.autentificar(TxtNomUsuario.Text, TxtContrasena.Text) > 0)
            {
                this.Hide();

                Menu fr = new Menu();
                fr.ShowDialog();
            }
            else
                MessageBox.Show("Error En Los Datos Del Usuario ");
        }

    }
}

