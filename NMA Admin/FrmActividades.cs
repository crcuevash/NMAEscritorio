using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMA_Admin
{
    public partial class FrmActividades : Form
    {
        public FrmActividades()
        {
            InitializeComponent();
        }

        private void FrmActividades_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'actividades.ACTIVIDAD' Puede moverla o quitarla según sea necesario.
            this.aCTIVIDADTableAdapter.Fill(this.actividades.ACTIVIDAD);

        }
    }
}
