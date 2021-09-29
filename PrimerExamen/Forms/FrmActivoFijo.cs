using Domain;
using Domain.Enums;
using Infraestructura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerExamen.Forms
{
    public partial class FrmActivoFijo : Form
    {
        public FrmActivoFijo()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            int count = 0;
            count++;
            ActivoFijo act = new ActivoFijo()
            {
                Id = count,
                NombreActivo = txtName.Text,
                CodigoActivo = txtId.Text,
                Descripcion = txtDescrip.Text,
                ValorActivo = numValor.Value,
                FechaAdquisicion = dtpFecha.Value,
                TipoActivoFijo = (TipoActivoFijo)cmbTipo.SelectedIndex,
                MetodoDeDepreciacion = (MetodoDeDepreciacion)cmbMet.SelectedIndex,
        };
            richTextBox.Text = ActivoModel.GetActivosJson();
        }
    }
}
