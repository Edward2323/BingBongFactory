using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bing_Bong_Factory.Negocio;
using Bing_Bong_Factory.Datos;

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if(ValidateProduct.Set_ValidateProduct(txtNombreproducto.Text, txtPrecio.Text, txtCantidad.Text)) //METODO PARA VALIDAR LOS VALORES INTRODUCIDOS POR EL USUARIO
            {
                //Si los valores son del tipo correcto
                if (db.InserProduct(ValidateProduct.GetProduct())) //Introduce el producto a la base de datos
                {
                    //Si se inserto el porducto correctamente
                    MessageBox.Show("Se inserto producto correctamente");
                    Cleartxt();
                }
                else
                {
                    //Si ocurre un error
                    MessageBox.Show("Ocurrio un error");
                }
            }
            else
            {
                //Si los valores no son del tipo correcto
                MessageBox.Show("Inserte los valores correctamente");
            }
        }

        private void Cleartxt()
        {
            txtNombreproducto.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
        }
    }
}
