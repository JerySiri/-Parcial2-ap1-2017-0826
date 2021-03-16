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
using Parcial2_ap1_2017_0826.UI.Registros;
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

                    case 3: // descripcion
                        lista = ProyectosBLL.GetList(p => true);
                        break;
                }

            }
            else
                lista = ProyectosBLL.GetList(p => true);

            ConsultaDataGridView.DataSource = null;
            VerColumn.Text = "Ver";
            VerColumn.UseColumnTextForButtonValue = true;
            ConsultaDataGridView.DataSource = lista;
        }

        private void ConsultaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ConsultaDataGridView.CurrentCell.ColumnIndex == 0)
            {
                abrirRegistroProyecto();
                BucarButton_Click(sender,e);
            }
        }

        private void abrirRegistroProyecto()
        {
            var rProyecto = new ProyectoForm();
            var row = ConsultaDataGridView.CurrentRow;
            rProyecto.LlenarCampos(ProyectosBLL.Buscar((int)row.Cells[1].Value));
            rProyecto.CargarGrid();
            rProyecto.ShowDialog();
        }


    }
}
