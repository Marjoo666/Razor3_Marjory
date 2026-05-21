using System;

using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace _1Guia5_19795362
{


    public partial class Form2 : Form
    {
        private SqlConnection conn;
        private SqlCommand insert1;
        private string sCn;

        public Form2()
        {
            InitializeComponent();
            conexion cn = new conexion();
            cn.conec();
            sCn = cn.cadena;
            conn = new SqlConnection(sCn);
        }

        private void btnIngresarC_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string insertCliente = "INSERT INTO CLIENTES (NombreCliente) ";
                insertCliente += "VALUES (@nombreCliente)";

                insert1 = new SqlCommand(insertCliente, conn);

                insert1.Parameters.Add(new SqlParameter("@nombreCliente", SqlDbType.VarChar));
                insert1.Parameters["@nombreCliente"].Value = txtCliente.Text;

                insert1.ExecuteNonQuery();

                txtCliente.Clear();
                MessageBox.Show("Registro ingresado...", "Ingresar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void btnVolverC_Click(object sender, EventArgs e)
        {
            Form1 formu1 = new Form1();
            formu1.Show();
            this.Hide();
        }

        private void btnLimpiarC_Click(object sender, EventArgs e)
        {
            txtCliente.Clear();
            //Para que regrese al textbox a escribir nuevamente
            txtCliente.Focus();
        }

        private void btnEliminarC_Click(object sender, EventArgs e)
        {
            try
            {
                //hace la validacion de que el textbox no este vacio
                if (string.IsNullOrWhiteSpace(txtCliente.Text))
                {
                    MessageBox.Show("Escriba el nombre del cliente que quieres eliminar.", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //ste es un mensaje que nos muestra si estamos seguros de eliminar el cliente, 
                DialogResult respuesta = MessageBox.Show("¿Estas seguro que quieres eliminar al cliente: " + txtCliente.Text + "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //si la respuesta es si, borrara eal cliente
                if (respuesta == DialogResult.Yes)
                {
                    conn.Open();
                    string sql = "DELETE FROM CLIENTES WHERE NombreCliente = @nombre";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@nombre", txtCliente.Text);

                    int filasAfec = cmd.ExecuteNonQuery();

                    if (filasAfec > 0)
                    {
                        MessageBox.Show("Registro eliminado correctamente.", "eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCliente.Clear();
                    }
                    else
                    {
                        MessageBox.Show("no se encontro a ningun cliente con ese nombre.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al eliminar: " + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
    }
}