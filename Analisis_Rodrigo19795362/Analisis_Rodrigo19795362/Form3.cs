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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
        }
        private void CargarEmpleados()
        {
            try
            {
                OleDbConnection cnn = Conexion.ConexionACCESS();
                string query = "SELECT * FROM Employee";
                OleDbDataAdapter da = new OleDbDataAdapter(query, cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvEmpleados.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show("Error al cargar: " + ex.Message); }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmployeeID.Text) || !int.TryParse(txtEmployeeID.Text, out _))
            {
                MessageBox.Show("Ingresa un ID válido para buscar.", "Validación");
                return;
            }

            try
            {
                OleDbConnection cnn = Conexion.ConexionACCESS();
                string query = "SELECT * FROM Employee WHERE EmployeeID = @id";
                OleDbCommand cmd = new OleDbCommand(query, cnn);
                cmd.Parameters.AddWithValue("@id", txtEmployeeID.Text);

                cnn.Open();
                OleDbDataReader lector = cmd.ExecuteReader();

                if (lector.Read())
                {
                    txtLastName.Text = lector["LastName"].ToString();
                    txtFirstName.Text = lector["FirstName"].ToString();
                    txtMiddleInitial.Text = lector["MiddleInitial"].ToString();
                    txtAddress.Text = lector["Addres"].ToString();
                    txtCity.Text = lector["City"].ToString();
                    txtState.Text = lector["State"].ToString();
                    txtZipCode.Text = lector["ZipCode"].ToString();
                    txtPhone.Text = lector["Phone"].ToString();
                    txtEmailAddress.Text = lector["EmailAddress"].ToString();
                    txtPassword.Text = lector["Password"].ToString();
                    txtStatus.Text = lector["Status"].ToString();
                }
                else { MessageBox.Show("Empleado no registrado."); }
                cnn.Close();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("El Nombre y Apellido son requeridos.", "Validación");
                return;
            }

            try
            {
                OleDbConnection cnn = Conexion.ConexionACCESS();
                string query = "INSERT INTO Employee (LastName, FirstName, MiddleInitial, Addres, City, State, ZipCode, Phone, EmailAddress, [Password], Status) " +
               "VALUES (@last, @first, @mid, @addr, @city, @state, @zip, @phone, @email, @pass, @status)";
                OleDbCommand cmd = new OleDbCommand(query, cnn);

                cmd.Parameters.AddWithValue("@last", txtLastName.Text.Trim());
                cmd.Parameters.AddWithValue("@first", txtFirstName.Text.Trim());
                cmd.Parameters.AddWithValue("@mid", txtMiddleInitial.Text.Trim());
                cmd.Parameters.AddWithValue("@addr", txtAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@city", txtCity.Text.Trim());
                cmd.Parameters.AddWithValue("@state", txtState.Text.Trim());
                cmd.Parameters.AddWithValue("@zip", txtZipCode.Text.Trim());
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                cmd.Parameters.AddWithValue("@email", txtEmailAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim());
                cmd.Parameters.AddWithValue("@status", txtStatus.Text.Trim());

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();

                MessageBox.Show("Empleado guardado con éxito.");
                LimpiarCampos();
                CargarEmpleados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmployeeID.Text) || !int.TryParse(txtEmployeeID.Text, out _))
            {
                MessageBox.Show("Se requiere el ID para actualizar al empleado.", "Validación");
                return;
            }

            try
            {
                OleDbConnection cnn = Conexion.ConexionACCESS();
                string query = "UPDATE Employee SET LastName=@last, FirstName=@first, MiddleInitial=@mid, Addres=@addr, City=@city, " +
               "State=@state, ZipCode=@zip, Phone=@phone, EmailAddress=@email, [Password]=@pass, Status=@status WHERE EmployeeID=@id";
                OleDbCommand cmd = new OleDbCommand(query, cnn);

                cmd.Parameters.AddWithValue("@last", txtLastName.Text.Trim());
                cmd.Parameters.AddWithValue("@first", txtFirstName.Text.Trim());
                cmd.Parameters.AddWithValue("@mid", txtMiddleInitial.Text.Trim());
                cmd.Parameters.AddWithValue("@addr", txtAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@city", txtCity.Text.Trim());
                cmd.Parameters.AddWithValue("@state", txtState.Text.Trim());
                cmd.Parameters.AddWithValue("@zip", txtZipCode.Text.Trim());
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                cmd.Parameters.AddWithValue("@email", txtEmailAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim());
                cmd.Parameters.AddWithValue("@status", txtStatus.Text.Trim());
                cmd.Parameters.AddWithValue("@id", txtEmployeeID.Text);

                cnn.Open();
                int filas = cmd.ExecuteNonQuery();
                cnn.Close();

                if (filas > 0) MessageBox.Show("Empleado actualizado.");
                else MessageBox.Show("ID no encontrado.");

                LimpiarCampos();
                CargarEmpleados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmployeeID.Text) || !int.TryParse(txtEmployeeID.Text, out _)) return;

            DialogResult res = MessageBox.Show("¿Seguro de dar de baja a este empleado?", "Confirmación", MessageBoxButtons.YesNo);
            if (res == DialogResult.No) return;

            try
            {
                OleDbConnection cnn = Conexion.ConexionACCESS();
                string query = "DELETE FROM Employee WHERE EmployeeID = @id";
                OleDbCommand cmd = new OleDbCommand(query, cnn);
                cmd.Parameters.AddWithValue("@id", txtEmployeeID.Text);

                cnn.Open();
                int filas = cmd.ExecuteNonQuery();
                cnn.Close();

                if (filas > 0) MessageBox.Show("Empleado eliminado.");
                else MessageBox.Show("ID no encontrado.");

                LimpiarCampos();
                CargarEmpleados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LimpiarCampos()
        {
            txtEmployeeID.Clear(); txtLastName.Clear(); txtFirstName.Clear(); txtMiddleInitial.Clear();
            txtAddress.Clear(); txtCity.Clear(); txtState.Clear(); txtZipCode.Clear();
            txtPhone.Clear(); txtEmailAddress.Clear(); txtPassword.Clear(); txtStatus.Clear();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }
    }
}