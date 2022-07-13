using System;

namespace decorator2
{
    class Program
    {
        static void Main(string[] args)
        {
            ILectora lectora = new LectoraArchivo();
            ILectora zipped = new LectorZIP(lectora);
            ILectora encrypted = new LectorEncrypted(lectora);
            ILectora zippedAndEncrypted = new LectorEncrypted(zipped);
            Console.WriteLine(lectora.Leer());
            Console.WriteLine(zipped.Leer());
            Console.WriteLine(encrypted.Leer());
            Console.WriteLine(zippedAndEncrypted.Leer());
        }
    }




    
  



}

