using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analisis_Rodrigo19795362
{
    class Conexion
    {
        public static OleDbConnection ConexionACCESS()
        {
            string cadena = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\rodri\OneDrive\Documentos\Analisis_Rodrigo.accdb";

            OleDbConnection cnn = new OleDbConnection(cadena);
            return cnn;
        }
    }
}
