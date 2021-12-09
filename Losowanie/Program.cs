using System;

namespace Losowanie
{
    class Program
    {
        Cast FirstNumber = new Cast("PierwszaLiczba", 0);
        Cast SecondNumber = new Cast("DrugaLiczba", 0);
        Cast ThirdNumber = new Cast("TrzeciaLiczba", 0);

        static void Main(string[] args)
        {
            Program RandomCast = new Program ();
            do
            {
                RandomCast.FirstNumber.SetRandomValue();
                RandomCast.SecondNumber.SetRandomValue();
                RandomCast.ThirdNumber.SetRandomValue();
                RandomCast.PrintRandomValuesToConsole(RandomCast.FirstNumber, RandomCast.SecondNumber, RandomCast.ThirdNumber);
                Console.WriteLine("======================");

            } while (!RandomCast.CheckIfDevidableBy3(RandomCast.FirstNumber, RandomCast.SecondNumber, RandomCast.ThirdNumber));

            RandomCast.PrintToConsole(RandomCast.FirstNumber, RandomCast.SecondNumber, RandomCast.ThirdNumber);
        }
        private void PrintRandomValuesToConsole(Cast Input1, Cast Input2, Cast Input3)
        {
            Console.WriteLine($"{Input1.name} : {Input1.value} ");
            Console.WriteLine($"{Input2.name} : {Input2.value} ");
            Console.WriteLine($"{Input3.name} : {Input3.value} ");
        }
        private void PrintToConsole(Cast Input1, Cast Input2, Cast Input3)
        {
            Console.WriteLine("Suma 3 ostatnich liczb :");
            PrintRandomValuesToConsole(Input1, Input2, Input3);
            Console.WriteLine($" Jest równa: {Sum(Input1, Input2, Input3)} i podzielna przez 3.");
        }

        public int Sum(Cast Input1, Cast Input2, Cast Input3)
        {
            return Input1.value + Input2.value + Input3.value;
        }

        public bool CheckIfDevidableBy3(Cast Input1, Cast Input2, Cast Input3)
        {
            int sum = Sum(Input1, Input2, Input3);
            if (sum % 3 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
