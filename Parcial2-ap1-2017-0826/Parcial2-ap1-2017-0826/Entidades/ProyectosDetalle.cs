using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Parcial2_ap1_2017_0826.Entidades
{
    public class ProyectosDetalle
    {
        [Key]
        public int Id { get; set; }
        public int ProyectoId { get; set; }
        public string TipoTareaId { get; set; }
        public string Descripcion { get; set; }
        public int Minutos { get; set; }

        public ProyectosDetalle()
        {
            Id = 0;
            ProyectoId = 0;
            TipoTareaId = string.Empty;
            Descripcion = string.Empty;
            Minutos = 0;
        }

        public ProyectosDetalle(int id,int proyectoId,string tipoTareaId, string descripcion, int minutos)
        {
            Id = id;
            ProyectoId = proyectoId;
            TipoTareaId = tipoTareaId;
            Descripcion = descripcion;
            Minutos = minutos;

        }


    }
}
