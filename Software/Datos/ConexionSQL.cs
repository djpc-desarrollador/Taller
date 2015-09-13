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

        public static String BuscarProfesor(Profesor entidad)
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
                a += "Id=" + entidad.Id;
                b = true;
            }

            if (!String.IsNullOrEmpty(entidad.Apellido1))
            {
                if (b)
                {
                    a += " AND ";
                    b = false;
                }
                a += "Apellido1 LIKE '%" + entidad.Apellido1 + "%'";
                b = true;
            }

            if (!String.IsNullOrEmpty(entidad.Apellido2))
            {
                if (b)
                {
                    a += " AND ";
                    b = false;
                }
                a += "Apellido2 LIKE '%" + entidad.Apellido2 + "%'";
                b = true;
            }

            if (!String.IsNullOrEmpty(entidad.Nombres))
            {
                if (b)
                {
                    a += " AND ";
                    b = false;
                }
                a += "Nombres LIKE '%" + entidad.Nombres + "%'";
                b = true;
            }
            if (!String.IsNullOrEmpty(entidad.Ci))
            {
                if (b)
                {
                    a += " AND ";
                    b = false;
                }
                a += "Ci LIKE '%" + entidad.Ci + "%'";
                b = true;
            }
            if (!String.IsNullOrEmpty(entidad.Telefono))
            {
                if (b)
                {
                    a += " AND ";
                    b = false;
                }
                a += "Telefono LIKE '%" + entidad.Telefono + "%'";
                b = true;
            }
            return a;
        }
    }
}
