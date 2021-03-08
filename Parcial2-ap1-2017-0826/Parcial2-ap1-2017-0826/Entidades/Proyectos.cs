using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Parcial2_ap1_2017_0826.Entidades
{
    public class Proyectos
    {
        [Key]
        public int ProyectoId { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }

        [ForeignKey("ProyectoId")]
        public virtual List<ProyectosDetalle> ProyectoDetalle { get; set; }

        public Proyectos()
        {
            ProyectoId = 0;
            Fecha = DateTime.Now;
            Descripcion = string.Empty;

            ProyectoDetalle = new List<ProyectosDetalle>();
        }
    }
}
