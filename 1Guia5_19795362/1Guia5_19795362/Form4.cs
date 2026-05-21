using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _1Guia5_19795362
{
    public partial class Form4 : Form
    {
        private SqlConnection conn;
        private string sCn;
        public Form4()
        {
            InitializeComponent();
            conexion cn = new conexion();
            cn.conec();
            sCn = cn.cadena;
            conn = new SqlConnection(sCn);
        }

        private void btnVolverL_Click(object sender, EventArgs e)
        {
            Form1 formu1 = new Form1();
            formu1.Show();
            this.Hide();
        }

        private void btnIngresarL_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql = "INSERT INTO LIBROS (id_Libro, NombreLibro) VALUES (@id, @nombre)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", txtIdLibroL.Text);
                cmd.Parameters.AddWithValue("@nombre", txtNombreLibroL.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Libro registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiamos automáticamente
                txtIdLibroL.Clear();
                txtNombreLibroL.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        private void btnEliminarL_Click(object sender, EventArgs e)
        {
            try
            {
                //validamos que no este vacio el textbox
                if (string.IsNullOrWhiteSpace(txtIdLibroL.Text))
                {
                    MessageBox.Show("Por favor, ingrese el ID del libro que desea eliminar.");
                    return;
                }

                conn.Open();
                string sql = "DELETE FROM LIBROS WHERE id_Libro = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", txtIdLibroL.Text);

                int filas = cmd.ExecuteNonQuery();
                if (filas > 0)
                    MessageBox.Show("El libro ha sido eliminado.");
                else
                    MessageBox.Show("no hay ningún libro con ese ID.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al eliminar: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        private void btnLimpiarL_Click(object sender, EventArgs e)
        {
            txtIdLibroL.Clear();
            txtNombreLibroL.Clear();
            txtIdLibroL.Focus();
        }
    }
}