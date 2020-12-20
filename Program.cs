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

            string line = Console.ReadLine();

            double tactSize = 0;

            if (line.Contains('/'))
            {
                string[] c = line.Split('/');

                bool first = Int32.TryParse(c[0], out int aa);
                bool second = Int32.TryParse(c[1], out int bb);

                tactSize = (double) aa / bb;
            }
            else
            {
                bool intRight = Double.TryParse(line, out tactSize);
            }

            Console.WriteLine("Задайте нотный стан:");
            string noteStan = Console.ReadLine();

            if (noteStan.Length == 0)
            {
                Console.WriteLine("Нотный стан пустой");
            }

            string[] noteLine = noteStan.Split(' ');

            double sumOneTact = 0;

            for (int i = 0; i < noteLine.Length; i++)
            {
                var b = Int32.TryParse(noteLine[i], out int c);

                if (b)
                {
                    sumOneTact += (double)1 / c;
                }

                if (noteLine[i] == "|" || i == noteLine.Length - 1)
                {
                    if (sumOneTact > tactSize)
                        {
                            Console.WriteLine("Длина такта на " + Math.Abs(dif) + " больше размера такта");
                        }
                    else
                        {
                            Console.WriteLine("Длина такта на " + Math.Abs(dif) + " меньше размера такта");
                        }
                    sumOneTact = 0;
                }
            }

        }
    }
}
