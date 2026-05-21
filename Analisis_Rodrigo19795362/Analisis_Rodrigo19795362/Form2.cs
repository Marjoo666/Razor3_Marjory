using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analisis_Rodrigo19795362
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }
        private void CargarProductos()
        {
            try
            {
                OleDbConnection cnn = Conexion.ConexionACCESS();
                string query = "SELECT * FROM Product";
                OleDbDataAdapter da = new OleDbDataAdapter(query, cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProductos.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show("Error al cargar: " + ex.Message); }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductID.Text) || !int.TryParse(txtProductID.Text, out _))
            {
                MessageBox.Show("Escribe un ID numérico válido para buscar.", "Validación");
                return;
            }

            try
            {
                OleDbConnection cnn = Conexion.ConexionACCESS();
                string query = "SELECT * FROM Product WHERE ProductID = @id";
                OleDbCommand cmd = new OleDbCommand(query, cnn);
                cmd.Parameters.AddWithValue("@id", txtProductID.Text);

                cnn.Open();
                OleDbDataReader lector = cmd.ExecuteReader();

                if (lector.Read())
                {
                    txtCategoryID.Text = lector["CategoryID"].ToString();
                    txtSupplierID.Text = lector["SupplierID"].ToString();
                    txtProduct.Text = lector["Product"].ToString();
                    txtDescription.Text = lector["Description"].ToString();
                    txtImage.Text = lector["Image"].ToString();
                    txtPrice.Text = lector["Price"].ToString();
                    txtNumberInStock.Text = lector["NumberInStock"].ToString();
                    txtNumberOnOrder.Text = lector["NumberOnOrder"].ToString();
                    txtReorderLevel.Text = lector["ReorderLevel"].ToString();
                }
                else { MessageBox.Show("No se encontró ningún producto con ese ID.", "Aviso"); }
                cnn.Close();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProduct.Text))
            {
                MessageBox.Show("El nombre del producto es obligatorio.", "Validación");
                return;
            }

            try
            {
                OleDbConnection cnn = Conexion.ConexionACCESS();
                string query = "INSERT INTO Product (CategoryID, SupplierID, [Product], Description, [Image], Price, NumberInStock, NumberOnOrder, ReorderLevel) " +
               "VALUES (@cat, @sup, @prod, @desc, @img, @price, @stock, @order, @reorder)";
                OleDbCommand cmd = new OleDbCommand(query, cnn);

                cmd.Parameters.AddWithValue("@cat", string.IsNullOrWhiteSpace(txtCategoryID.Text) ? (object)DBNull.Value : Convert.ToInt32(txtCategoryID.Text));
                cmd.Parameters.AddWithValue("@sup", string.IsNullOrWhiteSpace(txtSupplierID.Text) ? (object)DBNull.Value : Convert.ToInt32(txtSupplierID.Text));
                cmd.Parameters.AddWithValue("@prod", txtProduct.Text.Trim());
                cmd.Parameters.AddWithValue("@desc", txtDescription.Text.Trim());
                cmd.Parameters.AddWithValue("@img", txtImage.Text.Trim());
                cmd.Parameters.AddWithValue("@price", string.IsNullOrWhiteSpace(txtPrice.Text) ? (object)DBNull.Value : Convert.ToDecimal(txtPrice.Text));
                cmd.Parameters.AddWithValue("@stock", string.IsNullOrWhiteSpace(txtNumberInStock.Text) ? (object)DBNull.Value : Convert.ToInt32(txtNumberInStock.Text));
                cmd.Parameters.AddWithValue("@order", string.IsNullOrWhiteSpace(txtNumberOnOrder.Text) ? (object)DBNull.Value : Convert.ToInt32(txtNumberOnOrder.Text));
                cmd.Parameters.AddWithValue("@reorder", string.IsNullOrWhiteSpace(txtReorderLevel.Text) ? (object)DBNull.Value : Convert.ToInt32(txtReorderLevel.Text));

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();

                MessageBox.Show("Producto insertado con éxito.");
                LimpiarCampos();
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }
        private void LimpiarCampos()
        {
            txtProductID.Clear(); txtCategoryID.Clear(); txtSupplierID.Clear(); txtProduct.Clear();
            txtDescription.Clear(); txtImage.Clear(); txtPrice.Clear(); txtNumberInStock.Clear();
            txtNumberOnOrder.Clear(); txtReorderLevel.Clear();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductID.Text) || !int.TryParse(txtProductID.Text, out _))
            {
                MessageBox.Show("Escribe el ID del producto a eliminar.", "Validación");
                return;
            }

            DialogResult res = MessageBox.Show("¿Seguro de eliminar este producto?", "Confirmar", MessageBoxButtons.YesNo);
            if (res == DialogResult.No) return;

            try
            {
                OleDbConnection cnn = Conexion.ConexionACCESS();
                string query = "DELETE FROM Product WHERE ProductID = @id";
                OleDbCommand cmd = new OleDbCommand(query, cnn);
                cmd.Parameters.AddWithValue("@id", txtProductID.Text);

                cnn.Open();
                int filas = cmd.ExecuteNonQuery();
                cnn.Close();

                if (filas > 0) MessageBox.Show("Producto eliminado.");
                else MessageBox.Show("ID no encontrado.");

                LimpiarCampos();
                CargarProductos();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); 
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductID.Text) || !int.TryParse(txtProductID.Text, out _))
            {
                MessageBox.Show("Se requiere el ID del producto para actualizar.", "Validación");
                return;
            }

            try
            {
                OleDbConnection cnn = Conexion.ConexionACCESS();
                string query = "UPDATE Product SET CategoryID=@cat, SupplierID=@sup, [Product]=@prod, Description=@desc, [Image]=@img, " +
               "Price=@price, NumberInStock=@stock, NumberOnOrder=@order, ReorderLevel=@reorder WHERE ProductID=@id";
                OleDbCommand cmd = new OleDbCommand(query, cnn);

                cmd.Parameters.AddWithValue("@cat", string.IsNullOrWhiteSpace(txtCategoryID.Text) ? (object)DBNull.Value : Convert.ToInt32(txtCategoryID.Text));
                cmd.Parameters.AddWithValue("@sup", string.IsNullOrWhiteSpace(txtSupplierID.Text) ? (object)DBNull.Value : Convert.ToInt32(txtSupplierID.Text));
                cmd.Parameters.AddWithValue("@prod", txtProduct.Text.Trim());
                cmd.Parameters.AddWithValue("@desc", txtDescription.Text.Trim());
                cmd.Parameters.AddWithValue("@img", txtImage.Text.Trim());
                cmd.Parameters.AddWithValue("@price", string.IsNullOrWhiteSpace(txtPrice.Text) ? (object)DBNull.Value : Convert.ToDecimal(txtPrice.Text));
                cmd.Parameters.AddWithValue("@stock", string.IsNullOrWhiteSpace(txtNumberInStock.Text) ? (object)DBNull.Value : Convert.ToInt32(txtNumberInStock.Text));
                cmd.Parameters.AddWithValue("@order", string.IsNullOrWhiteSpace(txtNumberOnOrder.Text) ? (object)DBNull.Value : Convert.ToInt32(txtNumberOnOrder.Text));
                cmd.Parameters.AddWithValue("@reorder", string.IsNullOrWhiteSpace(txtReorderLevel.Text) ? (object)DBNull.Value : Convert.ToInt32(txtReorderLevel.Text));
                cmd.Parameters.AddWithValue("@id", txtProductID.Text);

                cnn.Open();
                int filas = cmd.ExecuteNonQuery();
                cnn.Close();

                if (filas > 0) MessageBox.Show("Producto actualizado correctamente.");
                else MessageBox.Show("No se encontró el ID.");

                LimpiarCampos();
                CargarProductos();
            }
            catch (Exception ex) { MessageBox.Show("Error al actualizar: " + ex.Message); }
        }
    }
}