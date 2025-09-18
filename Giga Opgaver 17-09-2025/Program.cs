namespace Giga_Opgaver_17_09_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int
            a,
            b,
            m,
            l,
            s,
            j;

            Console.WriteLine("Skriv Andreases alder");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine($"Andreas er {a} år gammel");

            Console.WriteLine("Skriv Berdans alder");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Berdan er {b} år gammel");

            Console.WriteLine("Skriv Mathiases alder");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine($"Berdan er {m} år gammel");

            Console.WriteLine("Skriv Lucases alder");
            l = int.Parse(Console.ReadLine());
            Console.WriteLine($"Lucas er {l} år gammel");

            Console.WriteLine("Skriv Simones alder");
            s = int.Parse(Console.ReadLine());
            Console.WriteLine($"Simone er {s} år gammel");

            Console.WriteLine("Skriv Jenses alder");
            j = int.Parse(Console.ReadLine());
            Console.WriteLine($"Skriv Jenses alder");

            int AllAge = a + b + m + l + s + j;
            double AverageAge = AllAge / 6.0;

            Console.WriteLine("Dette er gennemsnitsalderen " + AverageAge);
        }
    }
}
