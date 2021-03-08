using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Parcial2_ap1_2017_0826.Entidades
{
    class TipoTarea
    {
        [Key]
        public int TareaId { get; set; }
        public string Nombre { get; set; }

        public TipoTarea()
        {
            TareaId = 0;
            Nombre = string.Empty;
        }
    }
}
