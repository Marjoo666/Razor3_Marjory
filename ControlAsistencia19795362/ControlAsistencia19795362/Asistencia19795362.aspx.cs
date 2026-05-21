using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlAsistencia19795362
{
    public partial class Asistencia19795362 : System.Web.UI.Page
    {
        string conexion = "Server=localhost; Database=ControlAsistencia19795362; Integrated Security=True;";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MostrarDatos();
            }
        }

        void MostrarDatos()
        {
            using (SqlConnection con = new SqlConnection(conexion))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Alumnos", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                gvAlumnos.DataSource = dt;
                gvAlumnos.DataBind();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conexion))
            {
                string query = "INSERT INTO Alumnos (NombreAlumno, Fecha, Estado) VALUES (@NombreAlumno, @Fecha, @Estado)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@NombreAlumno", txtAlumno.Text);
                cmd.Parameters.AddWithValue("@Fecha", txtFecha.Text);
                cmd.Parameters.AddWithValue("@Estado", ddlEstado.SelectedValue);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            txtAlumno.Text = "";
            txtFecha.Text = "";
            ddlEstado.SelectedIndex = 0;

            MostrarDatos();
        }


        //estaparte se ejecuta cuandole damos en aztualizar
        protected void gvAlumnos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvAlumnos.EditIndex = e.NewEditIndex;
            MostrarDatos();
        }

        //se ejeciuta cuando le damos en cancelar
        protected void gvAlumnos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvAlumnos.EditIndex = -1; 
            MostrarDatos(); //refresca la tabla
        }

        //esta parte se ejecuta cuando le damos en actualizar
        protected void gvAlumnos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            int id = Convert.ToInt32(gvAlumnos.DataKeys[e.RowIndex].Value);

            string nuevoNombre = ((TextBox)gvAlumnos.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
            string nuevaFecha = ((TextBox)gvAlumnos.Rows[e.RowIndex].Cells[2].Controls[0]).Text;
            string nuevoEstado = ((TextBox)gvAlumnos.Rows[e.RowIndex].Cells[3].Controls[0]).Text;

            using (SqlConnection con = new SqlConnection(conexion))
            {
                string query = "UPDATE Alumnos SET NombreAlumno = @Nombre, Fecha = @Fecha, Estado = @Estado WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Nombre", nuevoNombre);
                cmd.Parameters.AddWithValue("@Fecha", nuevaFecha);
                cmd.Parameters.AddWithValue("@Estado", nuevoEstado);
                cmd.Parameters.AddWithValue("@Id", id);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            gvAlumnos.EditIndex = -1; //aqui salimos del modo edicion
            MostrarDatos();
        }

        protected void gvAlumnos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(gvAlumnos.DataKeys[e.RowIndex].Value);

            using (SqlConnection con = new SqlConnection(conexion))
            {
                string query = "DELETE FROM Alumnos WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", id);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MostrarDatos();
        }
    }
}