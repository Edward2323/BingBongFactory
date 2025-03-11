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

namespace Bing_Bong_Factory.Presentacion.Registro
{
    public partial class SignEdit : Form
    {
        private SigninValidation Signin = new SigninValidation();
        private DataGridViewRow Datauser = new DataGridViewRow();
        public SignEdit(DataGridViewRow DataUsers)
        {
            InitializeComponent();
            if (DataUsers != null)
            {
                Datauser = DataUsers;

                if (DataUsers.Cells[1].Value.ToString() == "Admin")
                    bunifuDropdown1.SelectedItem = "Admin";
                if (DataUsers.Cells[1].Value.ToString() == "Empleado")
                    bunifuDropdown1.SelectedItem = "Empleado";
                bunifuTextBox1.Text = DataUsers.Cells[2].Value.ToString();
                bunifuTextBox2.Text = DataUsers.Cells[3].Value.ToString();
                bunifuTextBox3.Text = DataUsers.Cells[4].Value.ToString();
                bunifuTextBox4.Text = DataUsers.Cells[5].Value.ToString();
                bunifuTextBox5.Text = DataUsers.Cells[5].Value.ToString();
            }
        }

        private void Close_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SignEdit_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            Signin.UserUpdate(Datauser.Cells[0].Value.ToString(), bunifuDropdown1.Text, bunifuTextBox1.Text, bunifuTextBox2.Text, bunifuTextBox3.Text, bunifuTextBox4.Text, bunifuTextBox5.Text);
            this.Close();
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

        private void Close_pnl_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
