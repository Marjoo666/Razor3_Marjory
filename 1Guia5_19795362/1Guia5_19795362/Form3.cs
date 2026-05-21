using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _1Guia5_19795362
{
    public partial class Form3 : Form
    {
        private SqlConnection conn;
        private string sCn;
        private SqlDataAdapter da1;
        private SqlDataReader dr1;
        private SqlCommand insert1;

        public Form3()
        {
            InitializeComponent();
            conexion cn = new conexion();
            cn.conec();
            sCn = cn.cadena;
            conn = new SqlConnection(sCn);
        }

        public void llenar()
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("SELECT id_Cliente FROM CLIENTES", conn);
                da.Fill(ds, "CLIENTES");
                cbCliente.DataSource = ds.Tables["CLIENTES"];
                cbCliente.ValueMember = "id_Cliente";
                cbCliente.DisplayMember = "id_Cliente";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar combo: " + ex.Message);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            llenar();
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num1;
            if (!Int32.TryParse(this.cbCliente.Text, out num1))
            {

            }
            else
            {
                try
                {
                    conn.Open();

                    num1 = int.Parse(cbCliente.Text);
                    string seleccion;
                    seleccion = "SELECT * FROM CLIENTES WHERE id_Cliente = " + num1;

                    da1 = new SqlDataAdapter(seleccion, conn);
                    SqlParameter prm = new SqlParameter("id_Cliente", SqlDbType.Int);
                    prm.Value = num1;
                    da1.SelectCommand.Parameters.Add(prm);


                    dr1 = da1.SelectCommand.ExecuteReader();

                    while (dr1.Read())
                    {
                        lbNombreC.Visible = true;
                        lbNombreC.Text = dr1["NombreCliente"].ToString().Trim();
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "");
                }

                if (dr1 != null)
                {
                    dr1.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cbCliente.Text = "";
            nUDcant.Value = 0;
            dTime1.Text = "";
            lbNombreC.Text = "";
        }

        private void btnIngresarP_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string insertPedido;
                insertPedido = "INSERT INTO PEDIDOS(id_Cliente, CantidadPedido, FechaPedido) ";
                insertPedido += "VALUES (@id_Cliente, @CantidadPedido, @FechaPedido)";

                insert1 = new SqlCommand(insertPedido, conn);

                insert1.Parameters.Add(new SqlParameter("@id_Cliente", SqlDbType.Int));
                insert1.Parameters["@id_Cliente"].Value = cbCliente.Text;

                insert1.Parameters.Add(new SqlParameter("@CantidadPedido", SqlDbType.Int));
                insert1.Parameters["@CantidadPedido"].Value = nUDcant.Value;

                insert1.Parameters.Add(new SqlParameter("@FechaPedido", SqlDbType.VarChar, 200));
                insert1.Parameters["@FechaPedido"].Value = dTime1.Text;

                insert1.ExecuteNonQuery();

                cbCliente.Text = "";
                nUDcant.Value = 0;
                dTime1.Text = "";

                MessageBox.Show("Registro agregado...", "Pedido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                conn.Close();
            }
            catch
            {
                MessageBox.Show("El registro no fue agregado...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolverP_Click(object sender, EventArgs e)
        {
            Form1 formu = new Form1();
            formu.Show();
            this.Hide();
        }

        private void btnEliminarP_Click(object sender, EventArgs e)
        {
            try
            {
                //se verifica que el comboBox no este vacio
                if (string.IsNullOrWhiteSpace(cbCliente.Text))
                {
                    MessageBox.Show("Seleccione el ID del cliente para eliminar sus pedidos.", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //le preguntamos si esta seguro de eliminar el registro
                DialogResult respuesta = MessageBox.Show("estas seguro que desea eliminar los pedidos del cliente ID: " + cbCliente.Text + "?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    conn.Open();

                    string Eliminar = "DELETE FROM PEDIDOS WHERE id_Cliente = @id_Cliente";

                    SqlCommand cmd = new SqlCommand(Eliminar, conn);
                    cmd.Parameters.AddWithValue("@id_Cliente", cbCliente.Text);

                    int filasAfec = cmd.ExecuteNonQuery();

                    if (filasAfec > 0)
                    {
                        MessageBox.Show("se eliminaron " + filasAfec + " pedido(s) correctamente.", "eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //esto es para que se limpie todo despues de haber borrado los pedidos
                        cbCliente.Text = "";
                        nUDcant.Value = 0;
                        dTime1.Text = "";
                        lbNombreC.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("no se encontraron pedidos para este cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al eliminar pedido: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}