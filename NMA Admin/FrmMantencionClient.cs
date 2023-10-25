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
    public partial class FrmMantencionClient : Form
    {
        public FrmMantencionClient()
        {
            InitializeComponent();
        }

        private void btnNuevoClient_Click(object sender, EventArgs e)
        {

        }

        private void FrmMantencionClient_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'clientes.CLIENTE' Puede moverla o quitarla según sea necesario.
            this.cLIENTETableAdapter.Fill(this.clientes.CLIENTE);

        }
    }
}
