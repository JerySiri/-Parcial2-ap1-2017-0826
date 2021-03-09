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

namespace Parcial2_ap1_2017_0826.UI
{
    public partial class MenuMain : Form
    {
        public MenuMain()
        {
            InitializeComponent();
            this.rProyectosToolStripMenuItem1.Click += new EventHandler(this.rProyectosToolStripMenuItem1_ItemClicked);
        }
        private void rProyectosToolStripMenuItem1_ItemClicked(object sender, EventArgs e)
        {
            var rProyecto = new ProyectoForm();
            rProyecto.MdiParent = this;
            rProyecto.Show();
        }

    }
}
