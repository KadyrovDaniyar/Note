using System;

namespace Nota
{
    public class NotaMusic
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Задайте размер такта:");
            }

            string line = Console.ReadLine();

            double tactSize;

            bool first = false;
            bool second = false;
            bool intRight = false;

            if (line.Contains('/'))
            {
                string[] c = line.Split('/');

                first = Int32.TryParse(c[0], out int aa);
                second = Int32.TryParse(c[1], out int bb);

                tactSize = (double)aa / bb;
            }
            else
            {
                intRight = Double.TryParse(line, out tactSize);
            }

            if ((first && second) || intRight)
            {
                Console.WriteLine("Задайте нотный стан:");
                string noteStan = Console.ReadLine();

                if (noteStan.Length == 0)
                {
                    Console.WriteLine("Нотный стан пустой");
                }

                Console.WriteLine(NotaCheck(tactSize, noteStan));
            }
            else
            {
                Console.WriteLine("Нотный стан должен быть числом или дробью");
            }
        }

        public static string NotaCheck(double tactSize, string noteStan)
        {
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
                    if (sumOneTact != tactSize)
                    {
                        var dif = sumOneTact - tactSize;
                        if (sumOneTact > tactSize)
                        {
                            return ("Длина такта на " + Math.Abs(dif) + " больше размера такта");
                        }
                        else
                        {
                            return ("Длина такта на " + Math.Abs(dif) + " меньше размера такта");
                        }
                    }
                    sumOneTact = 0;
                }
            }

            return "Ok";
        }
    }
}