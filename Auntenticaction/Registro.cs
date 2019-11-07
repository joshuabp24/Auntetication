using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Auntenticaction
{
    public class Registro
    {
        public void RegistrarUsuario(Usuario u, string path)
        {
            string data = u.Nombre+"\n" + u.Username + "\n" + u.Password;
            var datos = ObtenerLineas(path);
            if (datos != null)
            {
                datos.Add(data);
                File.WriteAllLines(path, datos);
            }
            else
            {
                File.WriteAllText(path, data);
            }
        }
        public List<string> ObtenerLineas(string ruta)
        {
            string[] data = null;
            if (File.Exists(ruta))
            {
                data = File.ReadAllLines(ruta);
            }
            List<string> datos = new List<string>();

            foreach (var item in data)
            {
                datos.Add(item);
            }
            return datos;
        }
    }
}
