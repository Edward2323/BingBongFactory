using Bing_Bong_Factory.Datos;
using Bing_Bong_Factory.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bing_Bong_Factory.Presentacion;

namespace Bing_Bong_Factory.Presentacion.Inventario
{
    
    
    public partial class FrmEditar : Form
    {
        DBconnection db = new DBconnection();
        string id;
        public FrmEditar(string productoid, string nombre, string precio, string cantidad)
        {
            InitializeComponent();

            this.id = productoid;
            txtNombreproductoE.Text = nombre;
            txtPrecioE.Text = precio;
            txtCantidadE.Text = cantidad;
        }

        private void btnCancelarE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ValidateProduct.Set_ValidateProduct(txtNombreproductoE.Text, txtPrecioE.Text, txtCantidadE.Text)) //METODO PARA VALIDAR LOS VALORES INTRODUCIDOS POR EL USUARIO
            {
                //Si los valores son del tipo correcto
                if (db.UpdateProduct(id, txtNombreproductoE.Text, txtPrecioE.Text, txtCantidadE.Text)) //Introduce el producto a la base de datos
                {
                    //Si se inserto el porducto correctamente
                    MessageBox.Show("Se actualizo el producto con exito");
                    this.Close();
                }
                else
                {
                    //Si ocurre un error
                    MessageBox.Show("Ocurrio un error");
                }
            }
            else
            {
                MessageBox.Show("Inserte los valores correctos");
            }
        }
    }
}
