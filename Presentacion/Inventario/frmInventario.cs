using Bing_Bong_Factory.Datos;
using Bing_Bong_Factory.Presentacion.Inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bing_Bong_Factory.Presentacion
{
    public partial class frmInventario : Form
    {
        private DBconnection db = new DBconnection();
        public frmInventario()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
           frmInsertar frm = new frmInsertar();
            frm.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> Data = db.GetProduct();

            foreach (DataGridViewRow row in Data) 
            { 
                dgvProductos.Rows.Add(row);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void lbProductos_Click(object sender, EventArgs e)
        {

        }
    }
}
