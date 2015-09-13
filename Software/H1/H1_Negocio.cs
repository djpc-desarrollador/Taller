using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.H1
{
    class H1_Negocio
    {
        private Datos.PolancoEntities conexion;
        private string nombreTabla;

        public H1_Negocio()
        {
            this.conexion = Datos.ConexionSQL.GetInstance().Conexion;
            this.nombreTabla = "TipoArea";
        }

        public bool Eliminar(Datos.TipoArea entidad)
        {
            try
            {
                conexion.TipoAreas.Remove(entidad);
                conexion.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Int32 SiguienteCodigoGenerado()
        {
            List<Datos.TipoArea> lista = conexion.TipoAreas.ToList();
            if (lista == null || lista.Count == 0)
            {
                return 1;
            }

            Datos.TipoArea item = lista.Last();

            if (item == null)
            {
                return 1;
            }
            else
            {
                return item.Codigo++;
            }
        }

        public bool Insertar(Datos.TipoArea entidad)
        {
            try
            {
                conexion.TipoAreas.Add(entidad);
                conexion.SaveChanges();
                return true;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}
