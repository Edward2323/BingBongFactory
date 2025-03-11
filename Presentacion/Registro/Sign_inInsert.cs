using Bing_Bong_Factory.Datos;
using Bing_Bong_Factory.Negocio;
using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bing_Bong_Factory
{
    public partial class Sign_inInsert : Form
    {
        private SigninValidation Signin = new SigninValidation();
        public Sign_inInsert()
        {
            InitializeComponent();
        }

        private void Login_click(object sender, EventArgs e)
        {

            Login_form Log = new Login_form();
            Log.Show();
            this.Hide();

        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            Signin.UserInsert(bunifuTextBox1.Text, bunifuTextBox2.Text, bunifuTextBox3.Text, bunifuTextBox4.Text, bunifuTextBox5.Text, bunifuDropdown1.Text);

        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {

        }

        private void Sign_in_Load(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuSeparator4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bunifuDropdown1.ForeColor = Color.Black;
        }

        private void Close_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Close_pnl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            if (bunifuTextBox5.UseSystemPasswordChar)
            {
                string text = bunifuTextBox5.Text;
                bunifuTextBox5.Text = "";
                bunifuTextBox5.UseSystemPasswordChar = false;
                bunifuTextBox5.Text = text;
            }
            else
            {
                string text = bunifuTextBox5.Text;
                bunifuTextBox5.Text = "";
                bunifuTextBox5.UseSystemPasswordChar = true;
                bunifuTextBox5.Text = text;
            }
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            if (bunifuTextBox4.UseSystemPasswordChar)
            {
                string text = bunifuTextBox4.Text;
                bunifuTextBox4.Text = "";
                bunifuTextBox4.UseSystemPasswordChar = false;
                bunifuTextBox4.Text = text;
            }
            else
            {
                string text = bunifuTextBox4.Text;
                bunifuTextBox4.Text = "";
                bunifuTextBox4.UseSystemPasswordChar = true;
                bunifuTextBox4.Text = text;
            }
        }
    }
}
