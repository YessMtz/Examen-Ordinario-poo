using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Examen_Ordinario__BlancaMtz
{
    class Program
    {
        class Compras
        {
            //campos de la clase
            public string producto, cantidad, precio;

            //constructor de la clase
            public Compras(string producto, string cantidad, string precio)
            {
                this.producto = producto;
                this.cantidad = cantidad;
                this.precio = precio;
            }

            //metodo despliegue de la compra en pantalla
            public void despliegueCompra()
            {
                Console.WriteLine("TICKET DE COMPRA" +
                    "\nProducto: " + this.producto+
                    "\nCantidad: " + this.cantidad+
                    "\nPrecio: " + this.precio);
            }
            //destructor de la clase
            ~Compras()
            {
                Console.WriteLine("MEMORIA DE LA CLASE DERIVADA");
            }
        }

        static void Main(string[] args)
        {
            //GENERADOR DE ARCHIVO
            StreamWriter nuevoDocumento;               
            string capturaProductos;
           nuevoDocumento = new StreamWriter("Ticket de compra.txt", true);
            

            //EXCEPCION 
            try
            {


                //CAPTURA DE DATOS
                Console.Title = "BIENVENIDO A LA MÁS BARATA";
                //declaracion de varables auxiliares
                Console.Write("Introduzca el nombre del producto que desea comprar: ");
                string newprodc = Console.ReadLine().ToString();

                Console.Write("Cantidad de productos: ");
                string  cant = Console.ReadLine().ToString();

                Console.Write("Precio del producto: ");
                String pprecio = Console.ReadLine().ToString();

                //CREACION DEL OBJETO DE LA CLASE
                Compras nuevacompra = new Compras(newprodc, cant, pprecio);
                nuevacompra.despliegueCompra();

                Console.WriteLine("PRESIONE ENTER continuar");

                //ESCRITURA EN EL DOCUMENTO
                nuevoDocumento.WriteLine(nuevacompra.producto);
                nuevoDocumento.WriteLine(nuevacompra.cantidad);
                nuevoDocumento.WriteLine(nuevacompra.precio);
                capturaProductos = Console.ReadLine();

                while (capturaProductos.Length != 0) ; 
                    
                if(capturaProductos != null) nuevoDocumento.Close();


            }catch(FormatException mensaje)
            {
                Console.WriteLine("MENSAJE DE ERROR: "+ mensaje);
            }
            finally
            {
                Console.WriteLine("PRESIONE ENTER PARA SALIR DEL PROGRAMA");
            }
;
        }
    }
}
