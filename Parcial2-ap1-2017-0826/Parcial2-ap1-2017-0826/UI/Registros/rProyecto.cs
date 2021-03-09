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
            TiempoTotalTextBox.Clear();

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
        private bool ValidarAgregar()
        {
            bool paso = true;

            MyErrorProvider.Clear();

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
            
            return paso;
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

            if (ProyectoIdNumericUpDown.Value == 0)
            {
                MyErrorProvider.SetError(ProyectoIdNumericUpDown, "El campo id No puede estar con valor 0");
                ProyectoIdNumericUpDown.Focus();
                paso = false;
            }

            if (this.Detalle.Count == 0)
            {
                MyErrorProvider.SetError(ProyectoDetalleGroupBox, "Debe agregar una tarea a realizar");
                ProyectoDetalleGroupBox.Focus();
                paso = false;
            }


            return paso;
        }

        private int LLenarTiempoTotal()
        {
            int tiempoTotal = 0;

            foreach (var dato in Detalle)
            {
                tiempoTotal += dato.Minutos;
            }
            return tiempoTotal;

        }

        private void ProyectoForm_Load(object sender, EventArgs e)
        {
            TipoTareaComboBox.DataSource = TiposTareaBLL.GetTiposTarea();
            TipoTareaComboBox.DisplayMember = "Nombre";
            TipoTareaComboBox.ValueMember = "TareaId";
        }
        
        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Proyectos proyectos = ProyectosBLL.Buscar((int)ProyectoIdNumericUpDown.Value);

            if (proyectos != null)
            {
                LlenarCampos(proyectos);
                CargarGrid();
            }
            else
                MessageBox.Show("Usuario No existe.", "Fallo", MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Proyectos proyectos;

            if (!Validar())
                return;

            proyectos = LLenarClase();

            bool paso = ProyectosBLL.Guardar(proyectos);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Transsaccion exitosa!.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Transsaccion fallida.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {

            if (ProyectosBLL.Eliminar((int)ProyectoIdNumericUpDown.Value))
            {
                Limpiar();
                MessageBox.Show("Eliminacion de usuario exitosa!.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Eliminacion de usuario fallida.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void AgregarButton_Click(object sender, EventArgs e)
        {
            if (! ValidarAgregar())
                return;

            if (ProyectoDetalleDataGridView.DataSource != null)
                this.Detalle = (List<ProyectosDetalle>)ProyectoDetalleDataGridView.DataSource;

            this.Detalle.Add(new ProyectosDetalle
                (
                    id: 0,
                    proyectoId: (int)ProyectoIdNumericUpDown.Value,
                    tipoTareaId: (int)TipoTareaComboBox.SelectedIndex + 1,
                    descripcion: RequerimientoTextBox.Text,
                    minutos: Convert.ToInt32(TiempoTextBox.Text)
                )
           ) ;

            TiempoTotalTextBox.Text = LLenarTiempoTotal().ToString() ;

            CargarGrid();
        }
        
        private void RemoverButton_Click(object sender, EventArgs e)
        {
            if (ProyectoDetalleDataGridView.Rows.Count > 0 || ProyectoDetalleDataGridView.CurrentRow != null)
            {
                Detalle.RemoveAt(ProyectoDetalleDataGridView.CurrentRow.Index);
                TiempoTotalTextBox.Text =LLenarTiempoTotal().ToString();
                CargarGrid();
            }
        }
    }
}
