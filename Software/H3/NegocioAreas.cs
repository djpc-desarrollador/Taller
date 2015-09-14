using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.H3
{
    class NegocioAreas
    {
        private Datos.PolancoEntities conexion;

        public NegocioAreas()
        {
            this.conexion = Datos.ConexionSQL.GetInstance().Conexion;
        }

        public bool Actualizar(Datos.Area entidad)
        {
            try
            {
                Datos.Area original = conexion.Areas.Find(entidad.Id);
                if (original != null)
                {
                    original.Descripcion = entidad.Descripcion;
                    original.TipoArea = entidad.TipoArea;
                }
                conexion.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Datos.Area> Buscar(Datos.Area entidad)
        {
            try
            {
                var resultados = conexion.Database.SqlQuery<Datos.Area>(Datos.GeneradorStringSQL.BuscarArea(entidad), new Object[0]);
                return resultados.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Eliminar(Datos.Area entidad)
        {
            try
            {
                conexion.Areas.Remove(entidad);
                conexion.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Insertar(Datos.Area entidad)
        {
            try
            {
                conexion.Areas.Add(entidad);
                conexion.SaveChanges();
                return true;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public List<Datos.Area> ListarTodos()
        {
            return this.conexion.Areas.ToList();
        }

        public Int32 SiguienteCodigoGenerado()
        {
            List<Datos.Area> lista = ListarTodos();
            if (lista == null || lista.Count == 0)
            {
                return 1;
            }

            Datos.Area item = lista.Last();

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
