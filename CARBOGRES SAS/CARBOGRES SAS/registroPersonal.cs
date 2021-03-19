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
    public partial class registroPersonal : Form
    {
       
        SqlConnection conn = new SqlConnection("data source = LAPTOP-R48K33BI\\SQLEXPRESS01 ; Initial catalog = CARBOGRES; integrated Security = true ");

        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable tb;
        int tblpersonas3;

        public registroPersonal()
        {

            InitializeComponent();
            displayData();


        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void displayData()
        {
            conn.Open();

            adpt = new SqlDataAdapter("Select * From TblRPersonal", conn);
            tb = new DataTable();
            adpt.Fill(tb);
            Data.DataSource = tb;
            conn.Close();



        }
        private void button4_Click(object sender, EventArgs e)
        {
            Menu atras = new Menu();
            atras.Show();
            this.Hide();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Personal Personal = new Personal();
            Personal.Nombre = (TXTNombre.Text);
            Personal.Apellido = (TXTApellido.Text);
            Personal.Cedula = (TXTCedula.Text);
            Personal.Cargo = (TXTcargo.Text);


            int resultado = PersonalDAL.Agregar1( Personal );

            if (resultado > 0)
            {
                MessageBox.Show("Datos Guardados Con Exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("NO Se Logro Guarda La Imformacion", "Error Al Guardar ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }




            TXTNombre.Clear();
            TXTApellido.Clear();
            TXTCedula.Clear();
            TXTcargo.Clear();
            displayData();

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("Delete From TblRPersonal  Where Cedula = '" + TXTCedula.Text + "'", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Datos Eliminados Con Exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
            displayData();
            TXTNombre.Clear();
            TXTApellido.Clear();
            TXTCedula.Clear();
            TXTcargo.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            {
                {
                    try
                    {
                        conn.Open();
                        cmd = new SqlCommand("update TblRPersonal set Nombre = '" + TXTNombre.Text + "',Apellido = '" + TXTApellido.Text + "',Cedula = '" + TXTCedula.Text + "',Cargo  = '" + TXTcargo.Text + "' where Cedula ='" + TXTCedula.Text + "'", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Datos Editados Con Exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        displayData();

                    }

                    catch (Exception)
                    {

                    }

                }
            }
            TXTNombre.Clear();
            TXTApellido.Clear();
            TXTCedula.Clear();
            TXTcargo.Clear();
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TXTNombre.Text = Data.Rows[e.RowIndex].Cells[0].Value.ToString();
            TXTApellido.Text = Data.Rows[e.RowIndex].Cells[1].Value.ToString();
            TXTCedula.Text = Data.Rows[e.RowIndex].Cells[2].Value.ToString();
            TXTcargo.Text = Data.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Data.DataSource = PersonalDAL.BuscarPersona(TXTBuscar.Text);
        }

        private void registroPersonal_Load(object sender, EventArgs e)
        {

        }
    }
    }

