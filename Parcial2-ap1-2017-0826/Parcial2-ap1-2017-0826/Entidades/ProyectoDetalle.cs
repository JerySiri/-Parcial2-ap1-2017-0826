using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Parcial2_ap1_2017_0826.Entidades
{
    class ProyectoDetalle
    {
        [Key]
        public int Id { get; set; }
        public int TipoTareaId { get; set; }
        public string Descripcion { get; set; }
        public int Minutos { get; set; }

        public ProyectoDetalle()
        {
            Id = 0;
            TipoTareaId = 0;
            Descripcion = string.Empty;
            Minutos = 0;

        }

        public ProyectoDetalle(int id, int tipoTareaId, string descripcion, int minutos)
        {
            Id = id;
            TipoTareaId = tipoTareaId;
            Descripcion = descripcion;
            Minutos = minutos;

        }

    }
}
