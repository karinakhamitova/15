using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    internal class Program
    {
        static void Main(string[] args)
        {
          ArithProgression arithProgression = new ArithProgression();
            arithProgression.setStart(4);
            arithProgression.setStep(2);
            Console.WriteLine(arithProgression.getNext());
                 Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            arithProgression.Reset();
            Console.WriteLine(arithProgression.getNext());
            GeomProgression geomProgression = new GeomProgression();
            Console.WriteLine("Geometric");
            geomProgression.setStart(4);
            geomProgression.setStep(2);
            Console.WriteLine(geomProgression.getNext());
            Console.WriteLine(geomProgression.getNext());
            Console.WriteLine(geomProgression.getNext());
            Console.WriteLine(geomProgression.getNext());
            Console.ReadKey();
        }
    }
}
