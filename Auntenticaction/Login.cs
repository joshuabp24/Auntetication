using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auntenticaction
{
    
    public class Login
    {
        Usuario u = new Usuario();
        public void IngresarDatos()
        {
            Console.WriteLine("Ingrese su username");
            string User = Console.ReadLine();
            Console.WriteLine("Ingrese su password");
            string Pass = Console.ReadLine();
            Registro r = new Registro();
            string ruta = "Datos.txt";
            List<string> datos = r.ObtenerLineas(ruta);
            ValidarDatos(u,datos);
        }
        public void ValidarDatos(Usuario u ,List<string> Datos)
        {
            List<Usuario> usuarios = new List<Usuario>();
            foreach (var item in Datos)
            {
                string[] info = item.Split(',');
                usuarios.Add(new Usuario { Nombre = info[0],Username = info[1], Password=info[2] });
            }
            foreach (var us in usuarios)
            {
                if (u.Username == us.Username&& u.Password == us.Password)
                {
                    Console.WriteLine("Datos coincidentes");
                    Console.WriteLine("Bienvenido a el nirvana");
                }
            }
            Console.WriteLine("Error; datos no coincidentes");

        }
    }
}
