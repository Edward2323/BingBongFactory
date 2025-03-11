using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bing_Bong_Factory.Datos;

namespace Bing_Bong_Factory.Presentacion.Ventas
{
    
    public partial class FrmBuscarP : Form
    {
        private DBconnection db = new DBconnection();
        public FrmBuscarP()
        {
            InitializeComponent();
            loadData();
            
        }

        private void btnCancelarB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadData()
        {

            List<DataGridViewRow> DataProducts = db.GetProduct();

            dgvProductosB.Rows.Clear();

            foreach (DataGridViewRow row in DataProducts)
            {
                dgvProductosB.Rows.Add(row);
            }
        }
    }
}
