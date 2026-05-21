using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Guia5_19795362
{
    class conexion
    {
        public string servidor, db;
        public string cadena;


        public void conec()
        {
            servidor = "localhost";
            db = "Libreria_19795362";
            cadena = @"Data Source=localhost;Initial Catalog=Libreria_19795362;Integrated Security=True";
    }
    }
}
