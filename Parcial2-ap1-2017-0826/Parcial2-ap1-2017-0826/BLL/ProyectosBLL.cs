using System;
using System.Collections.Generic;
using System.Text;
using Parcial2_ap1_2017_0826.Entidades;
using Parcial2_ap1_2017_0826.DAL;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Parcial2_ap1_2017_0826.BLL
{
    public class ProyectosBLL
    {
        public static bool Guardar(Proyectos proyecto)
        {
            if (!Existe(proyecto.ProyectoId))
                return insertar(proyecto);
            else
                return modificar(proyecto);
        }

        private static bool Existe( int id )
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                paso = contexto.Proyectos.Any(p => p.ProyectoId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool insertar(Proyectos proyecto)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            
            try
            {
                contexto.Proyectos.Add(proyecto);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static bool modificar(Proyectos proyecto)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Database.ExecuteSqlRaw($"Delete From ProyectosDetalle Where ProyectoId= {proyecto.ProyectoId}");

                foreach (var anterior in proyecto.ProyectoDetalle)
                {
                    contexto.Entry(anterior).State = EntityState.Added;
                }
                contexto.Entry(proyecto).State = EntityState.Modified;
                paso = (contexto.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static bool Eliminar(int id )
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            
            if (Existe(id))
            {
                try
                {
                    var eliminar = contexto.Proyectos.Find(id);
                    contexto.Entry(eliminar).State = EntityState.Deleted;

                    paso = (contexto.SaveChanges() > 0);
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    contexto.Dispose();
                }
            }
           
            return paso;
        }

        public static Proyectos Buscar(int id)
        {
            Proyectos proyectos = new Proyectos();
            Contexto contexto = new Contexto();

            try
            {
                proyectos = contexto.Proyectos.Include(p => p.ProyectoDetalle).Where(o => o.ProyectoId == id).SingleOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            
            return proyectos;
        }

        public static List<Proyectos> GetList(Expression<Func<Proyectos, bool>> proyecto)
        {
            List<Proyectos> lista = new List<Proyectos>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Proyectos.Where(proyecto).ToList();
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
        }

        public static List<Proyectos> GetProyectos()
        {
            List<Proyectos> proyectos = new List<Proyectos>();
            Contexto contexto = new Contexto();

            try
            {
                proyectos = contexto.Proyectos.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return proyectos;

        }

    }
}
