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
        public List<ProyectosDetalle> Detalle { get; set; }
        public ProyectoForm()
        {
            InitializeComponent();
            this.Detalle = new List<ProyectosDetalle>();
        }
        private void Limpiar()
        {
            // Proyecto
            ProyectoIdNumericUpDown.Value = 0;
            FechaDateTimePicker.Value = DateTime.Now;
            DescripcionTextBox.Clear();

            //DetalleProyecto
            TipoTareaComboBox.SelectedIndex = 0;
            RequerimientoTextBox.Clear();
            TiempoTextBox.Clear();

            this.Detalle = new List<ProyectosDetalle>();
            CargarGrid();
            
        }
        private void CargarGrid()
        {
            ProyectoDetalleDataGridView.DataSource = null;
            ProyectoDetalleDataGridView.DataSource = this.Detalle;
        }

        private Proyectos LLenarClase()
        {
            Proyectos proyectos = new Proyectos();
            proyectos.ProyectoId = (int) ProyectoIdNumericUpDown.Value;
            proyectos.Fecha = FechaDateTimePicker.Value;
            proyectos.Descripcion = DescripcionTextBox.Text;

            proyectos.ProyectoDetalle = this.Detalle;

            return proyectos;
        }

        private void LlenarCampos(Proyectos proyectos)
        {
            ProyectoIdNumericUpDown.Value = proyectos.ProyectoId;
            FechaDateTimePicker.Value = proyectos.Fecha;
            DescripcionTextBox.Text = proyectos.Descripcion;

            this.Detalle = proyectos.ProyectoDetalle;
        }

        private bool Validar()
        {
            bool paso = true;

            MyErrorProvider.Clear();

            if (String.IsNullOrWhiteSpace(DescripcionTextBox.Text))
            {
                MyErrorProvider.SetError(DescripcionTextBox, "El campo No puede estar vacio");
                DescripcionTextBox.Focus();
                paso = false;
            }

            if (String.IsNullOrWhiteSpace(RequerimientoTextBox.Text))
            {
                MyErrorProvider.SetError(RequerimientoTextBox, "El campo No puede estar vacio");
                RequerimientoTextBox.Focus();
                paso = false;
            }

            if (String.IsNullOrWhiteSpace(TiempoTextBox.Text))
            {
                MyErrorProvider.SetError(TiempoTextBox, "El campo No puede estar vacio");
                TiempoTextBox.Focus();
                paso = false;
            }

            if (ProyectoIdNumericUpDown.Value == 0)
            {
                MyErrorProvider.SetError(ProyectoIdNumericUpDown, "El campo id No puede estar con valor 0");
                ProyectoIdNumericUpDown.Focus();
                paso = false;
            }

            return paso;
        }

        private void ProyectoForm_Load(object sender, EventArgs e)
        {
            TipoTareaComboBox.DataSource = TiposTareaBLL.GetTiposTarea();
            TipoTareaComboBox.DisplayMember = "Nombre";
            TipoTareaComboBox.ValueMember = "TareaId";
        }
    }
}
