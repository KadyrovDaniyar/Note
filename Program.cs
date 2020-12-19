using System;

namespace Nota
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Задайте размер такта:");
            }

            string a = Console.ReadLine();

            if (a.Contains('/'))
            {
                string[] c = a.Split('/');

                foreach(a in )
            }

            bool intRight = Double.TryParse(Console.ReadLine(), out double tactSize);

            if (intRight)
            {
                Console.WriteLine("Задайте нотный стан:");
                string noteStan = Console.ReadLine();
                
                if (noteStan.Length == 0)
                {
                    Console.WriteLine("Нотный стан пустой");
                }

                string[] noteLine = noteStan.Split(' ');

                double sumOneTact = 0;

                foreach(var a in noteLine)
                {

                    if (a == "|")
                    {
                       if (sumOneTact != tactSize)
                        {
                            var dif = sumOneTact - tactSize;
                            Console.WriteLine("Длина такта на " + Math.Abs(dif) + "больше размера такта");
                        }
                    }

                    var b = Int32.TryParse(a, out int c);

                    if (b)
                    { 
                        sumOneTact += (double)1/c; 
                    }
                }

            }
            
        }
    }
}
