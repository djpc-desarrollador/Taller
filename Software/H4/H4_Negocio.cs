using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.H4
{
    class H4_Negocio
    {
        private Datos.PolancoEntities Conexion;

        public H4_Negocio()
        {
            this.Conexion = Datos.ConexionSQL.GetInstance().Conexion;
        }

        public bool Actualizar(Datos.Profesor entidad)
        {
            try
            {
                Datos.Profesor original = this.Conexion.Profesors.Find(entidad.Id);
                if (original != null)
                {
                    original.Apellido1 = entidad.Apellido1;
                    original.Apellido2 = entidad.Apellido2;
                    original.Nombres = entidad.Nombres;
                    original.Ci = entidad.Ci;
                    original.Telefono = entidad.Telefono;
                }
                this.Conexion.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Datos.Profesor> Buscar(Datos.Profesor entidad)
        {
            try
            {
                String sql = Datos.GeneradorStringSQL.BuscarProfesor(entidad);
                IEnumerable<Datos.Profesor> resultados = Conexion.Database.SqlQuery<Datos.Profesor>(sql, new Object[0]);
                return resultados.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Eliminar(Datos.Profesor entidad)
        {
            try
            {
                Conexion.Profesors.Remove(entidad);
                Conexion.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Insertar(Datos.Profesor entidad)
        {
            try
            {
                Conexion.Profesors.Add(entidad);
                Conexion.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Datos.Profesor> ListarTodos()
        {
            return Conexion.Profesors.ToList<Datos.Profesor>();
        }

        public Int32 SiguienteCodigo()
        {
            var lista = ListarTodos();
            if (lista == null || lista.Count == 0)
            {
                return 1;
            }
            return lista.Last<Datos.Profesor>().Id + 1;
        }
    }
}
