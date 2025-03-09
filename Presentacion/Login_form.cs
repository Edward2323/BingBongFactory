using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bing_Bong_Factory.Datos;
using Microsoft.Win32;

namespace Bing_Bong_Factory
{
    public partial class Login_form : Form
    {
        private DBconnection db = new DBconnection();
        public Login_form()
        {
            InitializeComponent();
        }

        private void Close_login(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_login(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            ShowInTaskbar = true;
        }

        private void Sign_in_hover(object sender, DragEventArgs e)
        {
        }

        private void Register_click(object sender, EventArgs e)
        {
            Sign_in reg = new Sign_in();
            reg.Show();
            this.Hide();
        }

        private void Linkd_click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }

        private void Whats_click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }

        private void Insta_click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }

        private void Face_click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }

        private void bunifuLabel5_Click(object sender, EventArgs e)
        {

        }

        private void Login_btn_clicl(object sender, EventArgs e)
        {
            if (db.LoginExict(bunifuTextBox1.Text, bunifuTextBox2.Text))
            {
                Dashboard_form dashboard_Form = new Dashboard_form();
                dashboard_Form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }         

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
