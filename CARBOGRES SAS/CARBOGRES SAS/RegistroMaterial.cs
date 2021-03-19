using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CARBOGRES_SAS
{
    
    public partial class RegistroMaterial : Form
    {
        SqlConnection conn = new SqlConnection("data source = LAPTOP-R48K33BI\\SQLEXPRESS01 ; Initial catalog = CARBOGRES; integrated Security = true ");

        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable tb;
        int TblMaterial;
        private Timer ti;
        public RegistroMaterial()
        {
            

            ti = new Timer();
            ti.Tick += new EventHandler(eventoTimer);
            ti.Enabled = true;
            InitializeComponent();
            displayData();
           
        }
        private void eventoTimer(object ob, EventArgs evt)
        {
            DateTime hoy = DateTime.Now;
            TXTHora.Text = hoy.ToString("hh:mm:ss tt");

            DateTime hoy2 = DateTime.Now;
            TXTFecha.Text = hoy.ToString("dd/MM/yyyy");
        }
        public void displayData()
        {
            conn.Open();

            adpt = new SqlDataAdapter("Select * From TblMaterial", conn);
            tb = new DataTable();
            adpt.Fill(tb);
            Data.DataSource = tb;
            conn.Close();



        }
        private void RegistroMaterial_Load(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MMaterial atras = new MMaterial();
            atras.Show();
            this.Hide();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //aqui
            Material Material = new Material();
            Material.Fecha = (TXTFecha.Text);
            Material.Hora = (TXTHora.Text);
            Material.Materiales = (TXTMaterial.Text);
            Material.Cantidad = (Convert.ToInt32(TXTCantidad.Text));
            Material.Vehiculo = (TXTVEHICULO.Text);
            Material.Observaciones = (TXTObsevaciones.Text);


            int resultado = MaterialDAL.Agregar1(Material);

            if (resultado > 0)
            {
                MessageBox.Show("Datos Guardados Con Exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("NO Se Logro Guarda La Imformacion", "Error Al Guardar ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }




            TXTFecha.Clear();
            TXTHora.Clear();
            TXTMaterial.Clear();
            TXTCantidad.Clear();
            TXTVEHICULO.Clear();
            TXTObsevaciones.Clear();
            displayData();

        }

        private void dataEliminar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            BUSCARM atras = new BUSCARM();
            atras.Show();
            this.Hide();
        }
    }
    }

