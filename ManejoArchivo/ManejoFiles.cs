using System;
using System.Collections.Generic;
using System.Text;

namespace ManejoArchivo
{
    public static class ManejoFiles
    {
        public static void Archivos()
        {
            var ruta = @"D:\ITSC\02 Programación II\2026 Programación II\txt\ManejoArchivo.txt";

            if (File.Exists(ruta))
            {
                Console.WriteLine("Existe");
                var contenido = File.ReadAllText(ruta);
                Console.WriteLine(contenido);
                var contenido1 = File.ReadLines(ruta);
                var i = 1;

                foreach (var renglon in contenido1)
                {
                    Console.WriteLine(i.ToString() + "-" + renglon);
                    i++;
                }

                Console.WriteLine("Borrado");
                //File.Delete(ruta);
            }
            else
            {
                Console.WriteLine("No existe");
            }
        }
    }
}
