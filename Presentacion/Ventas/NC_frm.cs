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
    public partial class NC_frm : Form
    {
        public NC_frm()
        {
            InitializeComponent();
        }

        private void cancel_btnRC_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
