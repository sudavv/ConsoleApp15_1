using System;

namespace ConsoleApp3_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            ArithProgression first = new ArithProgression();

            Console.WriteLine("Введите начальное число");
            int start = 0;
            try
            {
                start = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Не число");
                Console.ReadLine();
                Run();
                Environment.Exit(0);
            }
            Console.WriteLine("Алгебраическая прогрессия");
            first.SetStart(start);
            for (int i=0; i<9; i++)
            {
                Console.WriteLine(first.GetNext());                
            }
            Console.WriteLine("Сброс к начальному значению \n");
            first.Reset();

            GeomProgression second = new GeomProgression();
            Console.WriteLine("Геометрическая прогрессия");
            second.SetStart(start);
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(second.GetNext());
            }
            Console.WriteLine("Сброс к начальному значению \n");
            second.Reset();

            Console.ReadLine();
            Run();
            Environment.Exit(0);
        }

        interface ISeries
        {
            void SetStart(int x);
            int GetNext();
            void Reset();
        }

        public class ArithProgression : ISeries
        {

            int start, num;
            
            public ArithProgression()
            {
                start = 0;
                num = 0;
            }

            public int GetNext()
            {
               num += 2;
                return num ;
            }

            public void Reset()
            {
                num = start;
            }

            public void SetStart(int x)
            {
                num = start = x;
            }
        }

        public class GeomProgression : ISeries
        {

            int start, num;

            public GeomProgression()
            {
                start = 0;
                num = 0;
            }

            public int GetNext()
            {
                num *= 2;
                return num;
            }

            public void Reset()
            {
                num = start;
            }

            public void SetStart(int x)
            {
                num = start = x;
            }
        }
    }
}
