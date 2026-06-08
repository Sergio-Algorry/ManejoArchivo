using System;
using System.Collections.Generic;
using System.Text;

namespace ManejoArchivo
{
    public static class ManejoStream
    {
        public static void EscribirStream()
        {
            var ruta = @"D:\ITSC\02 Programación II\2026 Programación II\txt\ManejoStream.txt";

            //var stream = new System.IO.StreamWriter(ruta);

            //stream.WriteLine("Hola, este es un ejemplo de manejo de Stream.");
            //stream.WriteLine("Puedes escribir varias líneas en el archivo.");
            //stream.Write("La fecha de ");
            //stream.WriteLine($"hoy es {DateTime.Now.ToString("dd/mm/yyyyy")}");

            var stream = new System.IO.StreamWriter(path: ruta, append: true);
            //stream.WriteLine("Sigo escribiendo.");
            //stream.Write("Otra linea.");
            //stream.WriteLine(" Puedes escribir en el mismo renglon anterior en el archivo.");
            stream.WriteLine("Sigo escribiendo más en este archivo.");

            stream.Dispose();
        }

        public static void EscribirStreamSinDispose()
        {
            var ruta = @"D:\ITSC\02 Programación II\2026 Programación II\txt\ManejoStream.txt";

            using (var stream = new System.IO.StreamWriter(ruta))
            {
                stream.WriteLine("Hola, este es un ejemplo de manejo de Stream.");
                stream.WriteLine("Puedes escribir varias líneas en el archivo.");
                stream.WriteLine("Sigo escribiendo.");
            }
        }

    }
}
