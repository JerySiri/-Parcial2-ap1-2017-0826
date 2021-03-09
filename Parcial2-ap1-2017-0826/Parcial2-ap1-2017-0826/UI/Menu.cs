using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial2_ap1_2017_0826.UI.Registros;
using Parcial2_ap1_2017_0826.UI.Consultas;

namespace Parcial2_ap1_2017_0826.UI
{
    public partial class MenuMain : Form
    {
        public MenuMain()
        {
            InitializeComponent();
            this.rProyectosToolStripMenuItem1.Click += new EventHandler(this.rProyectosToolStripMenuItem1_ItemClicked);
            this.cProyectosToolStripMenuItem1.Click += new EventHandler(this.cProyectosToolStripMenuItem1_ItemClicked);
        }
        private void rProyectosToolStripMenuItem1_ItemClicked(object sender, EventArgs e)
        {
            var rProyecto = new ProyectoForm();
            rProyecto.MdiParent = this;
            rProyecto.Show();
        }

        private void cProyectosToolStripMenuItem1_ItemClicked(object sender, EventArgs e)
        {
            var cProyecto = new cProyectoForm();
            cProyecto.MdiParent = this;
            cProyecto.Show();
        }

    }
}
