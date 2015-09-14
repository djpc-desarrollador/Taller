using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.H1
{
    class NegocioTipoAreas
    {
        private Datos.PolancoEntities conexion;
        private string nombreTabla;

        public NegocioTipoAreas()
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

        public bool Actualizar(Datos.TipoArea entidad)
        {
            try
            {
                Datos.TipoArea original = conexion.TipoAreas.Find(entidad.Codigo);
                if (original != null)
                {
                    original.Descripcion = entidad.Descripcion;
                }
                conexion.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
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

        public List<Datos.TipoArea> ListarTodos()
        {
            return this.conexion.TipoAreas.ToList();
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
                return item.Codigo + 1;
            }
        }

        public List<Datos.TipoArea> Buscar(Datos.TipoArea entidad)
        {
            try
            {
                var resultados = 
                    from a in conexion.TipoAreas 
                    where a.Descripcion.Contains(entidad.Descripcion) 
                    select a ;
                return resultados.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
