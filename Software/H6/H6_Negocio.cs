using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.H6
{
    class H6_Negocio
    {
        private Datos.PolancoEntities Conexion;

        public H6_Negocio()
        {
            this.Conexion = Datos.ConexionSQL.GetInstance().Conexion;
        }

        public bool Actualizar(Datos.Curso entidad)
        {
            try
            {
                Datos.Curso original = this.Conexion.Cursoes.Find(entidad.Id);
                if (original != null)
                {
                    original.IdDeporte = entidad.IdDeporte;
                    original.Deporte = entidad.Deporte;
                    original.IdProfesor = entidad.IdDeporte;
                    original.Profesor = entidad.Profesor;
                    original.Nombre = entidad.Nombre;
                    original.Observacion = entidad.Observacion;
                    original.Duracion = entidad.Duracion;
                    original.FechaInicio = entidad.FechaInicio;
                    original.FechaFin = entidad.FechaFin;
                    original.HoraFin = entidad.HoraFin;
                    original.HoraInicio = entidad.HoraInicio;
                }
                this.Conexion.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Datos.Curso> Buscar(Datos.Curso entidad)
        {
            try
            {
                String sql = Datos.GeneradorStringSQL.BuscarCurso(entidad);
                IEnumerable<Datos.Curso> resultados = Conexion.Database.SqlQuery<Datos.Curso>(sql, new Object[0]);
                return resultados.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Eliminar(Datos.Curso entidad)
        {
            try
            {
                this.Conexion.Cursoes.Remove(entidad);
                this.Conexion.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Insertar(Datos.Curso entidad)
        {
            try
            {
                this.Conexion.Cursoes.Add(entidad);
                this.Conexion.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Datos.Curso> ListarTodos()
        {
            return Conexion.Cursoes.ToList<Datos.Curso>();
        }

        public Int32 SiguienteCodigo()
        {
            var lista = ListarTodos();
            if (lista == null || lista.Count == 0)
            {
                return 1;
            }
            return lista.Last<Datos.Curso>().Id + 1;
        }

        // Dejar siempre esta linea.
    }
}
