using Bing_Bong_Factory.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bing_Bong_Factory
{
    public partial class Dashboard_form : Form
    {
        public Dashboard_form()
        {
            InitializeComponent();
        }

        private void lbInventario_Click(object sender, EventArgs e)
        {
            frmInventario frm = new frmInventario(); frm.Show();
            this.Close();
        }
    }
}
