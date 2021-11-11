using System.IO;
using System.Collections.Generic;
using System;

namespace ArciveProject
{
    class Program
    {
        static void Main(string[] args)
        {
             // variable que almacena el valor de retorno del metodo FindeFiles
            var salesFiles = FindFiles("stores");
            foreach (var file in salesFiles)
            {
                Console.WriteLine(file);
            }
        }
        //funcion que retonar un tipo IEnumerable<string> y recibe como parametro un string
        static IEnumerable<string> FindFiles(string folderName)
        {
            // instanciamos una lista de strings
            List<string> salesFiles = new List<string>();
            /*
            se crea una variable foundFiles el cual devuelve una colección enumerable de los nombres completos (incluidas las rutas)
            Directory = clase que tiene el metodo .EnumerateDirectories el cual recibe tresparametros
            */
            var foundFiles = Directory.EnumerateDirectories(folderName,"*", SearchOption.AllDirectories);
            // recorremos la coleccion con un foreach
            foreach (var file in foundFiles)
            {
                if (file.EndsWith("sales.json"))
                {
                    // añadimos a la lista el archivo
                    salesFiles.Add(file);
                }
            }
            return salesFiles;
        }
    }
}
