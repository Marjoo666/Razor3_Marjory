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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Form2 formu1 = new Form2();
            formu1.Show();
            this.Hide();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(
        "Server=" + "localhost" + "; " + "database=master; integrated security=yes");

            //voy a agregarle el (IF NOT EXISTS...) porque unos procesos ya estan realizados
            //entonces para que salte todos los procesos que ya serealizaron  y se cree la tabla que agregue
            string CrearDB = "IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'Libreria_19795362') " +
                             "CREATE DATABASE Libreria_19795362";

            string tClientes = "USE Libreria_19795362; " +
                "IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='CLIENTES' AND xtype='U') " +
                "CREATE TABLE CLIENTES(" +
                "id_Cliente int IDENTITY(1,1)," +
                "NombreCliente varchar(40)," +
                "CONSTRAINT PK_cliente PRIMARY KEY (id_Cliente))";

            string tPedidos = "USE Libreria_19795362; " +
                "IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='PEDIDOS' AND xtype='U') " +
                "CREATE TABLE PEDIDOS(" +
                "id_Pedido int IDENTITY (1,1)," +
                "id_Cliente int NOT NULL," +
                "CantidadPedido int," +
                "FechaPedido varchar (70)," +
                "CONSTRAINT PK_pedido PRIMARY KEY(id_Pedido)," +
                "CONSTRAINT FK_Cliente FOREIGN KEY(id_Cliente)" +
                "REFERENCES CLIENTES(id_Cliente));";

            //tabla agregada como se nos pide en el ejercicio complementario
            string tLibros = "USE Libreria_19795362; " +
                "IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='LIBROS' AND xtype='U') " +
                "CREATE TABLE LIBROS(" +
                "id_Libro int NOT NULL," +
                "NombreLibro varchar(100)," +
                "CONSTRAINT PK_libro PRIMARY KEY (id_Libro))";

            SqlCommand cmd = new SqlCommand(CrearDB, cnn);
            SqlCommand cmd1 = new SqlCommand(tClientes, cnn);
            SqlCommand cmd2 = new SqlCommand(tPedidos, cnn);
            SqlCommand cmd3 = new SqlCommand(tLibros, cnn); //se agrego para la tabla LIBROS

            try
            {
                cnn.Open();

                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery(); //para que se ejecute la ultima tabla creada, en este caso la tabla de LIBROS

                cnn.Close();

                MessageBox.Show("Base de datos y Tablas" +
                    "\nListas para usar...", "Generar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error al crear la base de Datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                if (cnn.State == ConnectionState.Open) cnn.Close();
            }
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            Form3 formu1 = new Form3();
            formu1.Show();
            this.Hide();
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            Form4 formu4 = new Form4();
            formu4.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
    