using System;
using System.Collections.Generic;
using System.Text;
using Parcial2_ap1_2017_0826.Entidades;
using Parcial2_ap1_2017_0826.DAL;
using System.Linq;

namespace Parcial2_ap1_2017_0826.BLL
{
    public class TiposTareaBLL
    {
        public static List<TiposTarea> GetTiposTarea()
        {
            List<TiposTarea> lista = new List<TiposTarea>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.TiposTarea.ToList();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {

            }

            return lista;
        }

        public static TiposTarea Buscar(int id)
        {
            TiposTarea tipoTarea = new TiposTarea();
            Contexto contexto = new Contexto();

            try
            {
                tipoTarea = contexto.TiposTarea.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return tipoTarea;
        }

    }
}
