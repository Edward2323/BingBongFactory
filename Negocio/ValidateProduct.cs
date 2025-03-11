using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bing_Bong_Factory.Negocio
{
    //CLASE PARA VALIDAR INFORMACION DE PRODUCTO
    public static class ValidateProduct
    {
        static private string nombre;

        static private double precio;

        static private int cantidad;

        static public string Getnombre => nombre;
        static public double Getprecio => precio;
        static public int Getcantidad => cantidad;

        //METODO PARA VALIDAR PRODUCTO
        public static bool Set_ValidateProduct(string nombre, string precio, string cantidad)
        {
            try
            {
                if (nombre == "")
                    return false;
                ValidateProduct.nombre = nombre;
                ValidateProduct.precio = Convert.ToDouble(precio);
                ValidateProduct.cantidad = Convert.ToInt32(cantidad);

                return true;

            }
            catch
            {
                return false;
            }
        }



        //METODO PARA DEVOLVER PRODUCTO EN LISTA STRING
        public static List<string> GetProduct()
        {
            List<string> list = new List<string> { nombre, Convert.ToString(precio), Convert.ToString(cantidad) };
            return list;
        }


    }
}
