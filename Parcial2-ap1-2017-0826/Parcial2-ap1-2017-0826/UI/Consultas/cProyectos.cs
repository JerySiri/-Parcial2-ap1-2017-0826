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

namespace Parcial2_ap1_2017_0826.UI.Consultas
{
    public partial class cProyectoForm : Form
    {
        public cProyectoForm()
        {
            InitializeComponent();
        }

        private void BucarButton_Click(object sender, EventArgs e)
        {
            List<Proyectos> lista = new List<Proyectos>();

            if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0: //Id
                        lista = ProyectosBLL.GetList(p => p.ProyectoId == Utilidades.ToInt(CriterioTextBox.Text));
                        break;
                    case 1: // descripcion
                        lista = ProyectosBLL.GetList(p => p.Descripcion.Contains(CriterioTextBox.Text));
                        break;
                }

            }
            else
                lista = ProyectosBLL.GetList(p => true);

            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = lista;
        }
    }
}
