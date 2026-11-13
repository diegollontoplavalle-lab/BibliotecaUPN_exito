using System;
using System.IO;

namespace BibliotecaUPN
{
    public class GestorArchivo
    {
        // La ruta de tu archivo
        public static string ruta = @"C:\Users\piero\OneDrive\Escritorio\bibliotecaUPN\regsitro.csv.txt";

        // Función para calcular el siguiente número de préstamo (001, 002, 003...)
        public static string ObtenerSiguienteCodigo()
        {
            int maxId = 0;
            if (File.Exists(ruta))
            {
                string[] lineas = File.ReadAllLines(ruta);
                foreach (string linea in lineas)
                {
                    if (linea.Contains("|"))
                    {
                        string[] partes = linea.Split('|');
                        if (int.TryParse(partes[0].Trim(), out int id))
                        {
                            if (id > maxId) maxId = id;
                        }
                    }
                }
            }
            return (maxId + 1).ToString("D3");
        }

        // Función para buscar un préstamo por su código
        public static string[] BuscarPrestamo(string codigoBuscado)
        {
            if (!File.Exists(ruta)) return null;

            string[] lineas = File.ReadAllLines(ruta);
            foreach (string linea in lineas)
            {
                if (linea.Contains("|"))
                {
                    string[] datos = linea.Split('|');
                    // Compara ignorando ceros a la izquierda (ej: "001" es igual a "1")
                    if (datos[0].Trim().TrimStart('0') == codigoBuscado.TrimStart('0'))
                    {
                        return datos; // Devuelve todos los datos encontrados
                    }
                }
            }
            return null; // Si no encuentra nada
        }
    }
}