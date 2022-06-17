using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate array1 = new ConcreteAggregate();
            IIterator iterador1 = array1.createIterator();

            Console.WriteLine(iterador1.next());
            Console.WriteLine(iterador1.next());
            Console.WriteLine(iterador1.next());
            Console.WriteLine(iterador1.next());
            Console.WriteLine(iterador1.next());
            Console.WriteLine(iterador1.next());
            Console.WriteLine(iterador1.next());
            Console.WriteLine(iterador1.next());
            Console.WriteLine(iterador1.next());
            Console.WriteLine(iterador1.next());
            Console.WriteLine(iterador1.next());
            //11


            Console.WriteLine("POSICION: " + iterador1.getPosicion());


            Console.WriteLine(iterador1.back());
            Console.WriteLine(iterador1.back());
            Console.WriteLine(iterador1.back());
            Console.WriteLine(iterador1.back());
            Console.WriteLine(iterador1.back());
            Console.WriteLine(iterador1.back());
            Console.WriteLine(iterador1.back());
            Console.WriteLine(iterador1.back());
            Console.WriteLine(iterador1.back());
            Console.WriteLine(iterador1.back());
            Console.WriteLine(iterador1.back());
            Console.WriteLine(iterador1.back());


        }
    }
}
