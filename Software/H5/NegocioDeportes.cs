using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.H5
{
    class NegocioDeportes
    {
        private Datos.PolancoEntities Conexion;

        public NegocioDeportes()
        {
            this.Conexion = Datos.ConexionSQL.GetInstance().Conexion;
        }

        public bool Actualizar(Datos.Deporte entidad)
        {
            try
            {
                Datos.Deporte original = this.Conexion.Deportes.Find(entidad.Id);
                if (original != null)
                {
                    original.Descripcion = entidad.Descripcion;
                }
                this.Conexion.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Datos.Deporte> Buscar(Datos.Deporte entidad)
        {
            try
            {
                String sql = Datos.GeneradorStringSQL.BuscarDeporte(entidad);
                IEnumerable<Datos.Deporte> resultados = Conexion.Database.SqlQuery<Datos.Deporte>(sql, new Object[0]);
                return resultados.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Eliminar(Datos.Deporte entidad)
        {
            try
            {
                Conexion.Deportes.Remove(entidad);
                Conexion.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Insertar(Datos.Deporte entidad)
        {
            try
            {
                Conexion.Deportes.Add(entidad);
                Conexion.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Datos.Deporte> ListarTodos()
        {
            return Conexion.Deportes.ToList<Datos.Deporte>();
        }

        public Int32 SiguienteCodigo()
        {
            var lista = ListarTodos();
            if (lista == null || lista.Count == 0)
            {
                return 1;
            }
            return lista.Last<Datos.Deporte>().Id + 1;
        }

        // Dejar siempre esta linea.
    }
}
