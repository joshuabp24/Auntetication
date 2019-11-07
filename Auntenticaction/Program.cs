using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Auntenticaction
{
    class Program
    {              
        static void Main(string[] args)
        {
            string ruta = "Datos.txt";
            Usuario u = new Usuario();
            Registro r = new Registro();
            Login l = new Login();
            void Menu()
            {
                Console.WriteLine("---MENU---");
                Console.WriteLine("Ingrese uno de los sigueintes valores segun su preferencia");
                Console.WriteLine("1.- Registrese");
                switch (Console.ReadLine())
                {
                    case "1":
                        Registrese();
                        r.RegistrarUsuario(u, ruta);
                        break;
                    case "2":
                        l.IngresarDatos();
                        break;
                        
                }
            }
       
            Usuario Registrese()
            {
               
                Console.WriteLine("Ingrese su nombre");
                u.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese su Username");
                u.Username = Console.ReadLine();
                Console.WriteLine("Ingrese su Password");
                u.Password = Console.ReadLine();
                return u;
            }
            Menu();
            Console.WriteLine(u.Username);

           // string nombre = "joshua benitez";
            //string[] datos = nombre.Split(' ');
            //foreach (string item in datos)
            //{
            //    Console.WriteLine(item);
            //    Console.ReadKey();
            //}
        }
    }
}
