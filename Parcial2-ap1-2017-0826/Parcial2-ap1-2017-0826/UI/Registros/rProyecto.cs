using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial2_ap1_2017_0826.Entidades;
using Parcial2_ap1_2017_0826.BLL;

namespace Parcial2_ap1_2017_0826.UI.Registros
{
    public partial class ProyectoForm : Form
    {
        public List<ProyectosDetalle> proyectoDetalle { get; set; }
        public ProyectoForm()
        {
            
            InitializeComponent();
        }

        
    }
}
