using Bing_Bong_Factory.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bing_Bong_Factory.Presentacion.Inventario
{
    public partial class frmInsertar : Form
    {
        DBconnection db = new DBconnection();
        public frmInsertar()
        {
            InitializeComponent();
        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

<<<<<<< HEAD
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (ValidateProduct.Set_ValidateProduct(txtNombreproducto.Text, txtPrecio.Text, txtCantidad.Text))
            {
                //Si la informacion del producto es del tipo correcto
                if (db.InserProduct(ValidateProduct.GetProduct()))
                {
                    //Si fue correcta la inserccion
                    MessageBox.Show("Inserrcion Correcta");
                }

            }
            else
            {
                //de lo contrario si informacion del producto no es del tipo correcto
                
            }
=======
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
>>>>>>> 4c166ae9d343a72b502021c98a08ba260c02e90e
        }
    }
}
