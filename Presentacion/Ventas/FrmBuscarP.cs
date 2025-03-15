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
using Bunifu.UI.WinForms.Extensions;

namespace Bing_Bong_Factory.Presentacion.Ventas
{
    
    public partial class FrmBuscarP : Form
    {
        private DBconnection db = new DBconnection();
        public DataGridViewRow viewRow;

        private DataGridView Ventas_dvg;
        public FrmBuscarP(DataGridView Ventas)
        {
            Ventas_dvg = Ventas;

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
            if (Ventas_dvg.Rows.Count -1 == 0)
                return;

            foreach(DataGridViewRow row in Ventas_dvg.Rows)
            {
                for (int i = 0; i < dgvProductosB.Rows.Count; i++)
                {
                    int VproductID = Convert.ToInt32(row.Cells[0].Value);
                    int PproductID = Convert.ToInt32(dgvProductosB.Rows[i].Cells[0].Value);

                    if (VproductID == PproductID)
                    {
                        int actualQT = Convert.ToInt32(dgvProductosB.Rows[i].Cells[3].Value);
                        int newQT = Convert.ToInt32(row.Cells[3].Value);

                        dgvProductosB.Rows[i].Cells[3].Value = actualQT - newQT;
                    }
                }
            }
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            if (dgvProductosB.SelectedRows.Count > 0)
            {
                viewRow = dgvProductosB.SelectedRows[0];
                if (bunifuTextBox2.Text == "" || bunifuTextBox2.Text == "0")
                {
                    MessageBox.Show("Debe de colocar la cantidad de producto a vender");
                    return;
                }
                if (Convert.ToInt32(bunifuTextBox2.Text) > Convert.ToInt32(dgvProductosB.SelectedRows[0].Cells[3].Value))
                {
                    MessageBox.Show("No puede colocar mas cantidad que la disponible");
                    return;
                }
                viewRow.Cells[3].Value = bunifuTextBox2.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void FrmBuscarP_Load(object sender, EventArgs e)
        {

        }
    }
}
