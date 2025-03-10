using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bing_Bong_Factory.Presentacion.Ventas
{
    public partial class FrmBuscarP : Form
    {
        public FrmBuscarP()
        {
            InitializeComponent();
        }

        private void btnCancelarB_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
