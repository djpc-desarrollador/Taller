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
        public static String BuscarArea(Area entidad)
        {
            String a = "SELECT * FROM " + entidad.GetType().Name + " WHERE ";
            bool b = false;
            if (entidad.Id != null && entidad.Id > -1)
            {
                if (b)
                {
                    a += " AND ";
                    b = false;
                }

                b = true;
                a += "Id=" + entidad.Id;
            }

            if (!String.IsNullOrEmpty(entidad.Descripcion))
            {
                if (b)
                {
                    a += " AND ";
                    b = false;
                }

                b = true;
                a += "Descripcion LIKE '%" + entidad.Descripcion + "%'";
            }

            if (entidad.IdTipoArea != null && entidad.IdTipoArea > -1)
            {
                if (b)
                {
                    a += " AND ";
                    b = false;
                }

                b = true;
                a += "IdTipoArea=" + entidad.IdTipoArea;
            }

            return a;
        }
    }
}
