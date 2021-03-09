
namespace Parcial2_ap1_2017_0826.UI.Registros
{
    partial class ProyectoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProyectoForm));
            this.ProyectoIdLabel = new System.Windows.Forms.Label();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.DescripcionLabel = new System.Windows.Forms.Label();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.ProyectoDetalleGroupBox = new System.Windows.Forms.GroupBox();
            this.RemoverButton = new System.Windows.Forms.Button();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.ProyectoDetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.TiempoTextBox = new System.Windows.Forms.TextBox();
            this.TiempoLabel = new System.Windows.Forms.Label();
            this.RequerimientoTextBox = new System.Windows.Forms.TextBox();
            this.RequerimientoLabel = new System.Windows.Forms.Label();
            this.TipoTareaComboBox = new System.Windows.Forms.ComboBox();
            this.TipoTareaLabel = new System.Windows.Forms.Label();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.TiempoTotalTextBox = new System.Windows.Forms.TextBox();
            this.TiempoTotalLabel = new System.Windows.Forms.Label();
            this.ProyectoIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ProyectoDetalleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProyectoDetalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProyectoIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ProyectoIdLabel
            // 
            this.ProyectoIdLabel.AutoSize = true;
            this.ProyectoIdLabel.Location = new System.Drawing.Point(13, 13);
            this.ProyectoIdLabel.Name = "ProyectoIdLabel";
            this.ProyectoIdLabel.Size = new System.Drawing.Size(67, 15);
            this.ProyectoIdLabel.TabIndex = 0;
            this.ProyectoIdLabel.Text = "Proyecto Id";
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(13, 82);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(107, 23);
            this.FechaDateTimePicker.TabIndex = 2;
            // 
            // FechaLabel
            // 
            this.FechaLabel.AutoSize = true;
            this.FechaLabel.Location = new System.Drawing.Point(12, 64);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(38, 15);
            this.FechaLabel.TabIndex = 3;
            this.FechaLabel.Text = "Fecha";
            // 
            // DescripcionLabel
            // 
            this.DescripcionLabel.AutoSize = true;
            this.DescripcionLabel.Location = new System.Drawing.Point(13, 115);
            this.DescripcionLabel.Name = "DescripcionLabel";
            this.DescripcionLabel.Size = new System.Drawing.Size(69, 15);
            this.DescripcionLabel.TabIndex = 4;
            this.DescripcionLabel.Text = "Descripcion";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(13, 133);
            this.DescripcionTextBox.Multiline = true;
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(611, 62);
            this.DescripcionTextBox.TabIndex = 5;
            // 
            // ProyectoDetalleGroupBox
            // 
            this.ProyectoDetalleGroupBox.Controls.Add(this.RemoverButton);
            this.ProyectoDetalleGroupBox.Controls.Add(this.AgregarButton);
            this.ProyectoDetalleGroupBox.Controls.Add(this.ProyectoDetalleDataGridView);
            this.ProyectoDetalleGroupBox.Controls.Add(this.TiempoTextBox);
            this.ProyectoDetalleGroupBox.Controls.Add(this.TiempoLabel);
            this.ProyectoDetalleGroupBox.Controls.Add(this.RequerimientoTextBox);
            this.ProyectoDetalleGroupBox.Controls.Add(this.RequerimientoLabel);
            this.ProyectoDetalleGroupBox.Controls.Add(this.TipoTareaComboBox);
            this.ProyectoDetalleGroupBox.Controls.Add(this.TipoTareaLabel);
            this.ProyectoDetalleGroupBox.Location = new System.Drawing.Point(13, 202);
            this.ProyectoDetalleGroupBox.Name = "ProyectoDetalleGroupBox";
            this.ProyectoDetalleGroupBox.Size = new System.Drawing.Size(611, 263);
            this.ProyectoDetalleGroupBox.TabIndex = 6;
            this.ProyectoDetalleGroupBox.TabStop = false;
            this.ProyectoDetalleGroupBox.Text = "Detalles De La Tarea A Realizar";
            // 
            // RemoverButton
            // 
            this.RemoverButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoverButton.Image")));
            this.RemoverButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoverButton.Location = new System.Drawing.Point(6, 228);
            this.RemoverButton.Name = "RemoverButton";
            this.RemoverButton.Size = new System.Drawing.Size(77, 23);
            this.RemoverButton.TabIndex = 8;
            this.RemoverButton.Text = "Eliminar";
            this.RemoverButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoverButton.UseVisualStyleBackColor = true;
            // 
            // AgregarButton
            // 
            this.AgregarButton.Image = ((System.Drawing.Image)(resources.GetObject("AgregarButton.Image")));
            this.AgregarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AgregarButton.Location = new System.Drawing.Point(524, 42);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(77, 23);
            this.AgregarButton.TabIndex = 7;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AgregarButton.UseVisualStyleBackColor = true;
            // 
            // ProyectoDetalleDataGridView
            // 
            this.ProyectoDetalleDataGridView.AllowUserToAddRows = false;
            this.ProyectoDetalleDataGridView.AllowUserToDeleteRows = false;
            this.ProyectoDetalleDataGridView.AllowUserToOrderColumns = true;
            this.ProyectoDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProyectoDetalleDataGridView.Location = new System.Drawing.Point(7, 72);
            this.ProyectoDetalleDataGridView.Name = "ProyectoDetalleDataGridView";
            this.ProyectoDetalleDataGridView.ReadOnly = true;
            this.ProyectoDetalleDataGridView.RowTemplate.Height = 25;
            this.ProyectoDetalleDataGridView.Size = new System.Drawing.Size(598, 150);
            this.ProyectoDetalleDataGridView.TabIndex = 6;
            // 
            // TiempoTextBox
            // 
            this.TiempoTextBox.Location = new System.Drawing.Point(393, 43);
            this.TiempoTextBox.Name = "TiempoTextBox";
            this.TiempoTextBox.Size = new System.Drawing.Size(125, 23);
            this.TiempoTextBox.TabIndex = 5;
            // 
            // TiempoLabel
            // 
            this.TiempoLabel.AutoSize = true;
            this.TiempoLabel.Location = new System.Drawing.Point(391, 22);
            this.TiempoLabel.Name = "TiempoLabel";
            this.TiempoLabel.Size = new System.Drawing.Size(102, 15);
            this.TiempoLabel.TabIndex = 4;
            this.TiempoLabel.Text = "Tiempo (Minutos)";
            // 
            // RequerimientoTextBox
            // 
            this.RequerimientoTextBox.Location = new System.Drawing.Point(160, 43);
            this.RequerimientoTextBox.Name = "RequerimientoTextBox";
            this.RequerimientoTextBox.Size = new System.Drawing.Size(225, 23);
            this.RequerimientoTextBox.TabIndex = 3;
            // 
            // RequerimientoLabel
            // 
            this.RequerimientoLabel.AutoSize = true;
            this.RequerimientoLabel.Location = new System.Drawing.Point(158, 22);
            this.RequerimientoLabel.Name = "RequerimientoLabel";
            this.RequerimientoLabel.Size = new System.Drawing.Size(152, 15);
            this.RequerimientoLabel.TabIndex = 2;
            this.RequerimientoLabel.Text = "Requerimiento De La Tareas";
            // 
            // TipoTareaComboBox
            // 
            this.TipoTareaComboBox.FormattingEnabled = true;
            this.TipoTareaComboBox.Location = new System.Drawing.Point(7, 43);
            this.TipoTareaComboBox.Name = "TipoTareaComboBox";
            this.TipoTareaComboBox.Size = new System.Drawing.Size(147, 23);
            this.TipoTareaComboBox.TabIndex = 1;
            // 
            // TipoTareaLabel
            // 
            this.TipoTareaLabel.AutoSize = true;
            this.TipoTareaLabel.Location = new System.Drawing.Point(5, 22);
            this.TipoTareaLabel.Name = "TipoTareaLabel";
            this.TipoTareaLabel.Size = new System.Drawing.Size(77, 15);
            this.TipoTareaLabel.TabIndex = 0;
            this.TipoTareaLabel.Text = "Tipo De Tarea";
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.Location = new System.Drawing.Point(12, 471);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 52);
            this.NuevoButton.TabIndex = 7;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(174, 471);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 52);
            this.EliminarButton.TabIndex = 8;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(93, 471);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 52);
            this.GuardarButton.TabIndex = 9;
            this.GuardarButton.Text = "Buscar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // TiempoTotalTextBox
            // 
            this.TiempoTotalTextBox.Enabled = false;
            this.TiempoTotalTextBox.Location = new System.Drawing.Point(496, 471);
            this.TiempoTotalTextBox.Name = "TiempoTotalTextBox";
            this.TiempoTotalTextBox.Size = new System.Drawing.Size(128, 23);
            this.TiempoTotalTextBox.TabIndex = 10;
            // 
            // TiempoTotalLabel
            // 
            this.TiempoTotalLabel.AutoSize = true;
            this.TiempoTotalLabel.Location = new System.Drawing.Point(415, 475);
            this.TiempoTotalLabel.Name = "TiempoTotalLabel";
            this.TiempoTotalLabel.Size = new System.Drawing.Size(75, 15);
            this.TiempoTotalLabel.TabIndex = 11;
            this.TiempoTotalLabel.Text = "Tiempo Total";
            // 
            // ProyectoIdNumericUpDown
            // 
            this.ProyectoIdNumericUpDown.Location = new System.Drawing.Point(13, 32);
            this.ProyectoIdNumericUpDown.Name = "ProyectoIdNumericUpDown";
            this.ProyectoIdNumericUpDown.Size = new System.Drawing.Size(107, 23);
            this.ProyectoIdNumericUpDown.TabIndex = 12;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(126, 32);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(69, 23);
            this.BuscarButton.TabIndex = 13;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // ProyectoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 538);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.ProyectoIdNumericUpDown);
            this.Controls.Add(this.TiempoTotalLabel);
            this.Controls.Add(this.TiempoTotalTextBox);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.ProyectoDetalleGroupBox);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.DescripcionLabel);
            this.Controls.Add(this.FechaLabel);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.ProyectoIdLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(649, 577);
            this.MinimumSize = new System.Drawing.Size(649, 577);
            this.Name = "ProyectoForm";
            this.Text = "Registro De Proyectos";
            this.Load += new System.EventHandler(this.ProyectoForm_Load);
            this.ProyectoDetalleGroupBox.ResumeLayout(false);
            this.ProyectoDetalleGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProyectoDetalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProyectoIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProyectoIdLabel;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label FechaLabel;
        private System.Windows.Forms.Label DescripcionLabel;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.GroupBox ProyectoDetalleGroupBox;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.DataGridView ProyectoDetalleDataGridView;
        private System.Windows.Forms.TextBox TiempoTextBox;
        private System.Windows.Forms.Label TiempoLabel;
        private System.Windows.Forms.TextBox RequerimientoTextBox;
        private System.Windows.Forms.Label RequerimientoLabel;
        private System.Windows.Forms.ComboBox TipoTareaComboBox;
        private System.Windows.Forms.Label TipoTareaLabel;
        private System.Windows.Forms.Button RemoverButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.TextBox TiempoTotalTextBox;
        private System.Windows.Forms.Label TiempoTotalLabel;
        private System.Windows.Forms.NumericUpDown ProyectoIdNumericUpDown;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}