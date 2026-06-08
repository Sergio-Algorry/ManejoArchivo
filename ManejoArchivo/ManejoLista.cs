using System;
using System.Collections.Generic;
using System.Text;

namespace ManejoArchivo
{
    public static class ManejoLista
    {
        static string ruta = @"D:\ITSC\02 Programación II\2026 Programación II\txt\ListaToTxt.txt";

        static List<Persona> lista = new List<Persona>
        {
            new Persona { Id = 1, Nombre = "Juan", Ingresos = 500.99m },
            new Persona { Id = 2, Nombre = "María", Ingresos = 60000m },
            new Persona { Id = 3, Nombre = "Pedro", Ingresos = 450m },
            new Persona { Id = 4, Nombre = "Ana", Ingresos = 70000m }
        };

        public static void ListaToTxt()
        {
            var stringBuilder = new StringBuilder();
            foreach (Persona persona in lista)
            {
                stringBuilder.AppendLine($"{persona.Id} - {persona.Nombre} ({persona.Ingresos})");
            }
            using (var stream = new StreamWriter(ruta, append: false))
            {
                stream.Write(stringBuilder.ToString());
            }
        }

        public static void ListaToTxtFormat()
        {
            ManejoLista.ruta = @"D:\ITSC\02 Programación II\2026 Programación II\txt\ListaToTxtFormat.txt";
            var stringBuilder = new StringBuilder();
            foreach (Persona persona in lista)
            {
                var id = persona.Id.ToString().PadLeft(5, '0');
                var ingreso = persona.Ingresos.ToString("0.00").Replace(".", ",").PadLeft(10);
                
                stringBuilder.AppendLine($"{id} - {persona.Nombre.PadRight(15)} ({ingreso})");
            }
            using (var stream = new StreamWriter(ruta, append: false))
            {
                stream.Write(stringBuilder.ToString());
            }
        }

    }


    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }= string.Empty;
        public decimal  Ingresos { get; set; }
    }
}
