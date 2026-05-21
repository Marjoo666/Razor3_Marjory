using System;
using System.Data;
using System.Data.OleDb;
using System.Web.UI;

namespace CRUDASPCS19795362
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\rodri\OneDrive\Documentos\INDELCS19795362.accdb");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            RadioButtonList1.SelectedIndex = -1; //para que e limpie el radiobutton
            TextBox3.Text = "";
            TextBox4.Text = "";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string consulta = "INSERT INTO Estudiantes VALUES ('" + TextBox1.Text + "','" + TextBox2.Text + "','" +
                               RadioButtonList1.SelectedItem.Text + "','" + TextBox3.Text + "', '" +
                               TextBox4.Text + "')";

            OleDbDataAdapter da = new OleDbDataAdapter(consulta, con);
            DataSet ds = new DataSet();

            da.Fill(ds);

            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Datos Guardados')", true);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("DELETE FROM Estudiantes WHERE Id ='" + TextBox1.Text + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Student Deleted')", true);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Estudiantes", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            bool temp = false;
            con.Open();

            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Estudiantes WHERE Id='" + TextBox1.Text.Trim() + "'", con);

            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                TextBox2.Text = dr.GetValue(1).ToString();
                RadioButtonList1.SelectedValue = dr.GetValue(2).ToString();
                TextBox3.Text = dr.GetValue(3).ToString();
                TextBox4.Text = dr.GetValue(4).ToString();
                temp = true;
            }

            if (temp == false)
            {
                Label1.Text = "Student not found";
            }

            con.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("UPDATE Estudiantes SET Nombre='" + TextBox2.Text + "',Genero='" + RadioButtonList1.Text + "',Email='" + TextBox3.Text + "',Ciudad='" + TextBox4.Text + "' WHERE Id='" + TextBox1.Text + "'", con);

            DataSet ds = new DataSet();
            da.Fill(ds);

            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Student Updated')", true);
        }
    }
}
   