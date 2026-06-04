using System;
using System.Collections.Generic;
using System.Text;

namespace ManejoArchivo
{
    public static class ManejoPath
    {
        public static void Manejo()
        {
            //var ruta = @"D:\ITSC\02 Programación II\2026 Programación II\txt";
            //var rutas = Directory.EnumerateFiles(ruta, "*", SearchOption.AllDirectories);
            //foreach (var item in rutas)
            //{
            //    var nombreArchivo = Path.GetFileName(item);
            //    var nombreExtension = Path.GetExtension(item);

            //    Console.WriteLine($"{nombreArchivo} - extension {nombreExtension}");
            //}
            
            var ruta = @"D:\xx";
            var ruta1 = @"txt";
            var rutaCombinada = Path.Combine(ruta, ruta1);

            Console.WriteLine(rutaCombinada);

        }
    }
}
