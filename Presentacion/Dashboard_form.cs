using Bing_Bong_Factory.Datos;
using Bing_Bong_Factory.Presentacion;
using Bing_Bong_Factory.Presentacion.Inventario;
using Bing_Bong_Factory.Presentacion.Registro;
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
        private string UserGmail;
        private string UserRol;
        public Dashboard_form(string userGmail, string userRol)
        {
            UserGmail = userGmail;
            UserRol = userRol;
            InitializeComponent();
            loadData();

            if (userRol == "Empleado")
            {
                Btn_historial.Enabled = false;
                Btn_historial.Visible = false;
                Empleados_btn.Enabled = false;
                Empleados_btn.Visible = false;
                Inv_btn_pnl.Enabled = false;
                Inv_btn_pnl.Visible = false;
                Emp_btn_pnl.Enabled = false;
                Emp_btn_pnl.Visible = false;
            }
        }

        public void loadData()
        {
            List<DataGridViewRow> DataProducts = db.GetProduct();

            dgvProductos.Rows.Clear();

            foreach (DataGridViewRow row in DataProducts)
            {
                dgvProductos.Rows.Add(row);
            }

            List<DataGridViewRow> DataUsers = db.GetUserLogin();

            EmpleadosDataGridView.Rows.Clear();

            foreach (DataGridViewRow row in DataUsers)
            {
                string password = row.Cells[5].Value.ToString();
                row.Cells[5].Value = new string('●', password.Length);

                EmpleadosDataGridView.Rows.Add(row);
            }

            bunifuLabel1.Text = UserGmail;
            bunifuLabel2.Text = UserRol;
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

            if (dgvProductos.SelectedRows.Count > 0) // Verifica si hay una fila seleccionada
            {

                int productID = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells[0].Value); //tomar el valor de la primera columna seleccionada

                FrmEditar frmEditar = new FrmEditar(dgvProductos.SelectedRows[0].Cells[0].Value.ToString(), dgvProductos.SelectedRows[0].Cells[1].Value.ToString(),
                                                    dgvProductos.SelectedRows[0].Cells[2].Value.ToString(), dgvProductos.SelectedRows[0].Cells[3].Value.ToString());
                frmEditar.Show();

            }
            else
            {
                MessageBox.Show("Seleccione un producto para actualizar.");
            }


        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            using (FrmBuscarP frmBuscarP = new FrmBuscarP(Venta_dgv))
            {
                if (frmBuscarP.ShowDialog() == DialogResult.OK) 
                {
                    if (frmBuscarP.viewRow != null)
                    {
                        foreach (DataGridViewRow row in Venta_dgv.Rows)
                        {
                            if (row.Cells[0].Value?.ToString() == frmBuscarP.viewRow.Cells[0].Value?.ToString())
                            {
                                int actualqt = Convert.ToInt32(row.Cells[3].Value);
                                int newqt = Convert.ToInt32(frmBuscarP.viewRow.Cells[3].Value);
                                row.Cells[3].Value = actualqt + newqt;

                                int Priceunt = Convert.ToInt32(row.Cells[2].Value);

                                row.Cells["Subtotal"].Value = (actualqt + newqt) * Priceunt;

                                Actualizarsubtotal();

                                return;
                            }
                        }
                        
                        DataGridViewRow newRow = (DataGridViewRow)frmBuscarP.viewRow.Clone();

                        for (int i = 0; i < frmBuscarP.viewRow.Cells.Count; i++)
                        {
                            newRow.Cells[i].Value = frmBuscarP.viewRow.Cells[i].Value;
                        }

                        int quantity = Convert.ToInt32(newRow.Cells[2].Value); 
                        int priceUnit = Convert.ToInt32(newRow.Cells[3].Value); 
                        int subtotal = quantity * priceUnit;

                        newRow.Cells.Add(new DataGridViewTextBoxCell());

                        newRow.Cells[4].Value = subtotal;

                        Venta_dgv.Rows.Add(newRow);

                        Actualizarsubtotal();
                    }
                }
            }
        }

        private void Print_btm_Click(object sender, EventArgs e)
        {
            try
            {
                if (Venta_dgv.Rows.Count <= 0)
                {
                    MessageBox.Show("Debe de añadir productos a la factura");
                    return;
                }
                int OrderID = db.AddOrders(bunifuLabel1.Text);

                for (int i = 0; i < Venta_dgv.Rows.Count - 1; i++)
                {
                    int productID = Convert.ToInt32(Venta_dgv.Rows[i].Cells[0].Value);
                    int Quantity = Convert.ToInt32(Venta_dgv.Rows[i].Cells[3].Value);
                    db.AddOrderDetails(OrderID, productID, Quantity);
                }

                MessageBox.Show("Se ha guardado correta la factura");

                Venta_dgv.Rows.Clear();

                Actualizarsubtotal();
            }
            catch (Exception)
            {

                throw;
            }
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
                Venta_dgv.Rows.RemoveAt(Venta_dgv.SelectedRows[0].Index);

                Actualizarsubtotal();
            }
            else
            {
                MessageBox.Show("Seleccione el producto que desea eliminar");
            }
        }

        private void bunifuButton27_Click(object sender, EventArgs e)
        {
            Sign_inInsert sign = new Sign_inInsert();
            sign.Show();
        }

        private void Close_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EmpleadosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuButton25_Click(object sender, EventArgs e)
        {
            if (EmpleadosDataGridView.SelectedRows.Count > 0) // Verifica si hay una fila seleccionada
            {

                int EmpleadoID = Convert.ToInt32(EmpleadosDataGridView.SelectedRows[0].Cells[0].Value); //tomar el valor de la primera columna seleccionada

                db.DeleteUserLogin(EmpleadoID);

                EmpleadosDataGridView.Rows.RemoveAt(EmpleadosDataGridView.SelectedRows[0].Index); // Elimina la fila del DataGridView
            }
            else
            {
                MessageBox.Show("Seleccione un producto para eliminar.");
            }
        }

        private void bunifuButton26_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            if (EmpleadosDataGridView.SelectedRows.Count > 0) // Verifica si hay una fila seleccionada
            {
                List<DataGridViewRow> DataUsers = db.GetUserLogin();
                DataGridViewRow selectedRow = DataUsers[EmpleadosDataGridView.SelectedRows[0].Index];             
                SignEdit sign = new SignEdit(selectedRow);
                sign.Show();
            }
        }

        private void Actualizarsubtotal()
        {
            float Total = 0;
            for (int i = 0; i < Venta_dgv.Rows.Count; i++)
            {
                int quantity = Convert.ToInt32(Venta_dgv.Rows[i].Cells[2].Value);
                int priceUnit = Convert.ToInt32(Venta_dgv.Rows[i].Cells[3].Value);

                Total += quantity * priceUnit;
            }

            bunifuLabel6.Text = Total.ToString("C");
        }
    }
}