using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Software.Datos;

namespace Software.Datos
{
    class ConexionSQL
    {
        public PolancoEntities Conexion { private set; get; }

        private ConexionSQL()
        {
            this.Conexion = new PolancoEntities();
        }

        private static ConexionSQL INSTANCE;

        public static ConexionSQL GetInstance()
        {
            if (ConexionSQL.INSTANCE == null)
            {
                ConexionSQL.INSTANCE = new ConexionSQL();
            }
            return ConexionSQL.INSTANCE;
        }
    }

    class GeneradorStringSQL
    {
        public static string SiguienteCodigo(string nombreTabla, string nombreColumnaPrimaria)
        {
            string sql = "SELECT TOP(1) * FROM {0} ORDER BY {1} DESC";
            return string.Format(sql,nombreTabla,nombreColumnaPrimaria);
        }

        public static string InsertTipoArea(TipoArea entidad)
        {
            string sql = "INSERT INTO {0}(Descripcion) VALUES ('{1}')";
            return string.Format(sql, entidad.GetType().Name, entidad.Descripcion);
        }
    }
}
