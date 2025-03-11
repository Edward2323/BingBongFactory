using Bing_Bong_Factory.Datos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bing_Bong_Factory.Negocio
{
    internal class SigninValidation
    {
        private DBconnection db = new DBconnection();
        public void UserInsert(string User_rol, string User_firstname, string User_lastname, string User_email, string password, string passwordpass)
        {
            if (User_rol == "" || User_firstname == "" || User_lastname == "" || User_email == "" || password == "")
            {
                MessageBox.Show("No se puede dejar campos vacios");
                return;
            }
            if (!User_email.EndsWith("@gmail.com") || User_email.IndexOf("@gmail.com") < 6)
            {
                MessageBox.Show("Correo electronico incorrecto (debe ser: 6 caracteres + @gmail.com)");
                return;
            }           
            if (password.Count() <= 5)
            {
                MessageBox.Show("Contraseña incorrecta (debe ser: 6 caracteres");
                return;
            }
            if (password != passwordpass)
            {
                MessageBox.Show("Confirmacion incorrecta");
                return;
            }
            if (db.UserInsert(User_rol, User_firstname, User_lastname, User_email, password))
            {
                MessageBox.Show("Usuario registrado");
            }
            else
            {
                MessageBox.Show("Erro en el registro del usuario");
            }
        }
        public void UserUpdate(string User_id, string User_rol, string User_firstname, string User_lastname, string User_email, string password, string passwordpass)
        {
            if (User_id == "" || User_rol == "" || User_firstname == "" || User_lastname == "" || User_email == "" || password == "")
            {
                MessageBox.Show("No se puede dejar campos vacios");
                return;
            }
            if (!User_email.EndsWith("@gmail.com") || User_email.IndexOf("@gmail.com") < 6)
            {
                MessageBox.Show("Correo electronico incorrecto (debe ser: 6 caracteres + @gmail.com)");
                return;
            }
            if (password.Count() <= 5)
            {
                MessageBox.Show("Contraseña incorrecta (debe ser: 6 caracteres");
                return;
            }
            if (password != passwordpass)
            {
                MessageBox.Show("Confirmacion incorrecta");
                return;
            }
            if (db.UpdateUserLogin(User_id, User_rol, User_firstname, User_lastname, User_email, password))
            {
                MessageBox.Show("Usuario registrado");
            }
            else
            {
                MessageBox.Show("Erro en el registro del usuario");
            }
        }
    }
}
