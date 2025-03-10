using Bing_Bong_Factory.Datos;
using Bing_Bong_Factory.Presentacion;
using Bing_Bong_Factory.Presentacion.Inventario;
using Bing_Bong_Factory.Presentacion.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Bing_Bong_Factory
{
    public partial class Dashboard_form : Form
    {
        private DBconnection db = new DBconnection();
        public Dashboard_form()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            List<DataGridViewRow> Data = db.GetProduct();

            dgvProductos.Rows.Clear();

            foreach (DataGridViewRow row in Data)
            {
                dgvProductos.Rows.Add(row);
            }


        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            PestañasV.SetPage(0);
        }

        private void Btn_Inventario_Click(object sender, EventArgs e)
        {
            PestañasV.SetPage(1);
        }

        private void Btn_historial_Click(object sender, EventArgs e)
        {
            PestañasV.SetPage(2);
        }

        private void Btn_configuracion_Click(object sender, EventArgs e)
        {
            PestañasV.SetPage(3);
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            PestañasV.SetPage(4);
        }

        private void Dashboard_form_Load(object sender, EventArgs e)
        {
            int current_hour = DateTime.Now.Hour;

            if (current_hour >= 6 && current_hour < 12)
            {
                Salute_lbl.Text = "Buenos dias!";
            }
            else if (current_hour >= 12 && current_hour < 18)
            {
                Salute_lbl.Text = "Buenas tardes!";
            }
            else
            {
                Salute_lbl.Text = "Buenas noches!";
            }
        }

        private void Hora_y_Fecha_Tick(object sender, EventArgs e)
        {
            hour_lbl.Text = DateTime.Now.ToShortTimeString();
            Date_lbl.Text = DateTime.Now.ToShortDateString();
        }

        private void Btn_venta_Click(object sender, EventArgs e)
        {
            PestañasV.SetPage(5);
        }



        private void Minimize_login(object sender, EventArgs e)
        {

        }

        private void Close_pnl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_pnl_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            ShowInTaskbar = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void Empleados_btn_Click(object sender, EventArgs e)
        {
            PestañasV.SetPage(6);
        }

        private void Home_btn_pnl_Click(object sender, EventArgs e)
        {
            PestañasV.SetPage(0);
        }

        private void Inv_btn_pnl_Click(object sender, EventArgs e)
        {
            PestañasV.SetPage(1);
        }

        private void Ven_btn_pnl_Click(object sender, EventArgs e)
        {
            PestañasV.SetPage(5);
        }

        private void His_btn_pnl_Click(object sender, EventArgs e)
        {
            PestañasV.SetPage(2);
        }

        private void Emp_btn_pnl_Click(object sender, EventArgs e)
        {
            PestañasV.SetPage(6);
        }

        private void DltProduct_btn_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0) // Verifica si hay una fila seleccionada
            {
                
                int productID = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells[0].Value); //tomar el valor de la primera columna seleccionada

                db.DeleteProduct(productID);

                dgvProductos.Rows.RemoveAt(dgvProductos.SelectedRows[0].Index); // Elimina la fila del DataGridView
            }
            else
            {
                MessageBox.Show("Seleccione un producto para eliminar.");
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            frmInsertar frmInsertar = new frmInsertar();
            frmInsertar.Show();
        }

        private void EdtProduct_btn_Click(object sender, EventArgs e)
        {
            FrmEditar frmEditar = new FrmEditar();
            frmEditar.Show();
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            FrmBuscarP frmBuscarP = new FrmBuscarP();
            frmBuscarP.Show();
        }

        private void Print_btm_Click(object sender, EventArgs e)
        {
            if (Venta_dgv.SelectedRows.Count > 0) { }
        }

        private void NC_btn_Click(object sender, EventArgs e)
        {
            NC_frm nC_Frm = new NC_frm();
            nC_Frm.Show();
        }

        private void Remove_btn_Click(object sender, EventArgs e)
        {
            if (Venta_dgv.SelectedRows.Count > 0)
            {

            }
            else
            {
                MessageBox.Show("Seleccione el producto que desea eliminar");
            }
        }
    }
}