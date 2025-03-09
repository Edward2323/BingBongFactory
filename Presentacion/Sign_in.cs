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

namespace Bing_Bong_Factory
{
    public partial class Sign_in : Form
    {
        private DBconnection db = new DBconnection();
        public Sign_in()
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
            if (!bunifuTextBox3.Text.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Correo electronico incorrecto (debe ser: @gmail.com)");
                return;
            }
            if (bunifuTextBox4.Text != bunifuTextBox5.Text)
            {
                MessageBox.Show("Confirmacion incorrecta");
                return;
            }
            if (db.UserInsert(comboBox1.Text, bunifuTextBox1.Text, bunifuTextBox2.Text, bunifuTextBox3.Text, bunifuTextBox4.Text))
            {
                MessageBox.Show("Usuario registrado");
            }
            else
            {
                MessageBox.Show("Erro en el registro del usuario");
            }
        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
