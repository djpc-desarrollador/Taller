using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.H2
{
    class H2_Negocio
    {
        private Datos.PolancoEntities conexion;

        public H2_Negocio()
        {
            this.conexion = Datos.ConexionSQL.GetInstance().Conexion;
        }

        public bool Actualizar(Datos.TipoAsociado entidad)
        {
            try
            {
                Datos.TipoAsociado original = conexion.TipoAsociadoes.Find(entidad.Id);
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

        public List<Datos.TipoAsociado> Buscar(Datos.TipoAsociado entidad)
        {
            try
            {
                var resultados =
                    from a in conexion.TipoAsociadoes
                    where a.Descripcion.Contains(entidad.Descripcion)
                    select a;
                return resultados.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Eliminar(Datos.TipoAsociado entidad)
        {
            try
            {
                conexion.TipoAsociadoes.Remove(entidad);
                conexion.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Insertar(Datos.TipoAsociado entidad)
        {
            try
            {
                conexion.TipoAsociadoes.Add(entidad);
                conexion.SaveChanges();
                return true;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public List<Datos.TipoAsociado> ListarTodos()
        {
            return this.conexion.TipoAsociadoes.ToList();
        }

        public Int32 SiguienteCodigoGenerado()
        {
            List<Datos.TipoAsociado> lista = ListarTodos();
            if (lista == null || lista.Count == 0)
            {
                return 1;
            }

            Datos.TipoAsociado item = lista.Last();

            if (item == null)
            {
                return 1;
            }
            else
            {
                return item.Id + 1;
            }
        }
    }
}
