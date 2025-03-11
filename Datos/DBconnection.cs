using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Data;
using System.Windows.Forms;

namespace Bing_Bong_Factory.Datos
{
    public class DBconnection
    {
        static string serverName = Environment.MachineName;
        string connectionString = $"Server={serverName};Database=BBDB;Integrated Security=True;";


        public void DeleteProduct(int productID)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("DeleteProducts", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Product_ID", productID);
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public List<DataGridViewRow> GetProduct()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                List<DataGridViewRow> Data = new List<DataGridViewRow>();
                try
                {
                    con.Open();
                    string qry = "SELECT * FROM Products;";
                    using (SqlCommand cmd = new SqlCommand(qry, con))
                    {
                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                DataGridViewRow tem = new DataGridViewRow();
                                for (int i = 0; i < rd.FieldCount; i++)
                                {
                                    tem.Cells.Add(new DataGridViewTextBoxCell());
                                    tem.Cells[i].Value = rd[i];
                                }
                                Data.Add(tem);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                return Data;
            }
        }

        //Metodo para insertar un producto
        public bool InserProduct(List<string> ls)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("AddProduct", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        //Agregar parametros al llamado del procedimiento
                        cmd.Parameters.AddWithValue("@Product_name", ls[0]);
                        cmd.Parameters.AddWithValue("@Unit_price", ls[1]);
                        cmd.Parameters.AddWithValue("@Unit_in_stock", ls[2]);

                        cmd.ExecuteNonQuery();

                        using (SqlCommand checkError = new SqlCommand("SELECT @@ERROR", con))
                        {
                            int errorCode = (int)checkError.ExecuteScalar();
                            if (errorCode == 0)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }


            }
        }
        public string LoginExict(string User_email, string password)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("Login", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@User_email", User_email);
                        cmd.Parameters.AddWithValue("@User_password", password);

                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {
                            if (rd.Read())
                            {
                                return rd.GetString(0);
                            }
                            else
                            {
                                return null;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                return null;
            }
        }
        public bool UserInsert(string User_rol, string User_firstname, string User_lastname, string User_email, string password)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("AddUserLogin", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@User_rol", User_rol);
                        cmd.Parameters.AddWithValue("@User_firstname", User_firstname);
                        cmd.Parameters.AddWithValue("@User_lastname", User_lastname);
                        cmd.Parameters.AddWithValue("@User_email", User_email);
                        cmd.Parameters.AddWithValue("@User_password", password);

                        cmd.ExecuteNonQuery();

                        using (SqlCommand checkError = new SqlCommand("SELECT @@ERROR", con))
                        {
                            int errorCode = (int)checkError.ExecuteScalar();
                            if (errorCode == 0)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                return false;
            }
        }
        public List<DataGridViewRow> GetUserLogin()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                List<DataGridViewRow> Data = new List<DataGridViewRow>();
                try
                {
                    con.Open();
                    string qry = "SELECT * FROM UserLogin;";
                    using (SqlCommand cmd = new SqlCommand(qry, con))
                    {
                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                DataGridViewRow tem = new DataGridViewRow();
                                for (int i = 0; i < rd.FieldCount; i++)
                                {
                                    tem.Cells.Add(new DataGridViewTextBoxCell());
                                    tem.Cells[i].Value = rd[i];
                                }
                                Data.Add(tem);
                            }
                        }
                    }
<<<<<<< HEAD
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                return Data;
            }
        }
        public void DeleteUserLogin(int UserID)
=======
                    catch (Exception ex)
                    {
                        return false;
                    }


                }
            }

        public bool UpdateProduct(string id, string nombre, string precio, string cantidad)
>>>>>>> 6ac25b1b7b7c4163c6a9785229ebf6e6b8a2163f
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
<<<<<<< HEAD
                    using (SqlCommand cmd = new SqlCommand("DeleteUserLogin", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@User_id", UserID);
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        public bool UpdateUserLogin(string User_id, string User_rol, string User_firstname, string User_lastname, string User_email, string password)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("UpdateUserLogin", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@User_id", User_id);
                        cmd.Parameters.AddWithValue("@User_rol", User_rol);
                        cmd.Parameters.AddWithValue("@User_firstname", User_firstname);
                        cmd.Parameters.AddWithValue("@User_lastname", User_lastname);
                        cmd.Parameters.AddWithValue("@User_email", User_email);
                        cmd.Parameters.AddWithValue("@User_password", password);
=======
                    using (SqlCommand cmd = new SqlCommand("UpdateProduct", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        //Agregar parametros al llamado del procedimiento
                        cmd.Parameters.AddWithValue("@Product_id", id);
                        cmd.Parameters.AddWithValue("@Product_name", nombre);
                        cmd.Parameters.AddWithValue("@Unit_price", precio);
                        cmd.Parameters.AddWithValue("@Unit_in_stock", cantidad);
>>>>>>> 6ac25b1b7b7c4163c6a9785229ebf6e6b8a2163f

                        cmd.ExecuteNonQuery();

                        using (SqlCommand checkError = new SqlCommand("SELECT @@ERROR", con))
                        {
                            int errorCode = (int)checkError.ExecuteScalar();
                            if (errorCode == 0)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
<<<<<<< HEAD
                    MessageBox.Show("Error: " + ex.Message);
                }
                return false;
            }
        }
    }
}
=======
                    return false;
                }


            }
        }
    }
    }
>>>>>>> 6ac25b1b7b7c4163c6a9785229ebf6e6b8a2163f
