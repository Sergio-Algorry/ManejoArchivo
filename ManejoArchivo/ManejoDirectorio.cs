using System;
using System.Collections.Generic;
using System.Text;

namespace ManejoArchivo
{
    public class ManejoDirectorio
    {
        public static void Manejo()
        {
            //var ruta = @"D:\xx\txt\directo1\directo2";

            //Directory.CreateDirectory(ruta);
            
            //ruta = @"D:\xx\txt\directo2\directo2";

            //Directory.CreateDirectory(ruta);

            var rutaMuestra = @"D:\xx\txt";

            //var ListaDirectorios = Directory.EnumerateDirectories(rutaMuestra, "*", SearchOption.AllDirectories);

            //foreach (var item in ListaDirectorios)
            //{
            //    Console.WriteLine(item);
            //}

            //var rutaArchivos = @"D:\xx\txt";

            //var ListaArchivos = Directory.EnumerateFiles(rutaArchivos, "*.psc", SearchOption.AllDirectories);
            //foreach (var item in ListaArchivos)
            //{
            //    Console.WriteLine(item);
            //}

            //Directory.Delete(rutaMuestra);
            //Directory.Delete(rutaMuestra, recursive:true);
        }
    }
}
