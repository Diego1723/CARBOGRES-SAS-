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
    public partial class RmaterialSAL : Form
    {

        SqlConnection conn = new SqlConnection("data source = LAPTOP-R48K33BI\\SQLEXPRESS01 ; Initial catalog = CARBOGRES; integrated Security = true ");

        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable tb;
        int TblMaterial;
        private Timer ti;
        public RmaterialSAL()
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

            adpt = new SqlDataAdapter("Select * From TblMaterialSAL", conn);
            tb = new DataTable();
            adpt.Fill(tb);
            Data.DataSource = tb;
            conn.Close();



        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //aqui
            SALIDA SALIDA = new SALIDA();
            SALIDA.Fecha = (TXTFecha.Text);
            SALIDA.Hora = (TXTHora.Text);
            SALIDA.Materiales = (TXTMaterial.Text);
            SALIDA.Cantidad = (Convert.ToInt32(TXTCantidad.Text));
            SALIDA.Vehiculo = (TXTVEHICULO.Text);
            SALIDA.Observaciones = (TXTObsevaciones.Text);
            SALIDA.Obras = (TXTObras.Text);


            int resultado = SalidaDAL.Agregar1(SALIDA);

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
            TXTObras.Clear();
                displayData();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MENUSALIDA atras = new MENUSALIDA();
            atras.Show();
            this.Hide();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            editarSalida atras = new editarSalida();
            atras.Show();
            this.Hide();
        }

        private void Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TXTFecha.Text = Data.Rows[e.RowIndex].Cells[0].Value.ToString();
            TXTHora.Text = Data.Rows[e.RowIndex].Cells[1].Value.ToString();
            TXTMaterial.Text = Data.Rows[e.RowIndex].Cells[2].Value.ToString();
            TXTCantidad.Text = Data.Rows[e.RowIndex].Cells[3].Value.ToString();
            TXTVEHICULO.Text = Data.Rows[e.RowIndex].Cells[4].Value.ToString();
            TXTObsevaciones.Text = Data.Rows[e.RowIndex].Cells[5].Value.ToString();
            TXTObras.Text = Data.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void RmaterialSAL_Load(object sender, EventArgs e)
        {

        }
    }
    }

