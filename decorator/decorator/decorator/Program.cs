using System;

namespace decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IGuitarra guitarra = new Guitarra("Ibanez", "guitarra eléctrica base", 3000.51);

            //type cast desde clase guitarra ( solo metodo de clase guitarra ) 
            Printer( ((Guitarra)guitarra).marcaCaracteristicas() );
            Printer( $" costo $ {guitarra.Costo()} \n");

            //costo + mics EMG
            Printer(" + mics EMG");
            guitarra = new MicrofonosEMG(guitarra);
            Printer($" $  {guitarra.Costo()}");

            //costo + cuerdas calibre 010
            Printer(" + cuerdas 010");
            guitarra = new Cuerdas010(guitarra);
            Printer($" $  {guitarra.Costo()}");
        }

        static void Printer(string s)
        {
            Console.WriteLine(s);
        }
    }
}
