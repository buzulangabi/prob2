using System;

namespace prob2
{
    class Program
    {
       public static void Main(string[] args)
        {
            Segment se = new Segment(3, 10);
            
            Console.WriteLine($"Introdu primul numar: ");
            string commeN1 = Console.ReadLine();
            double number1 = Convert.ToDouble(commeN1);
            Console.WriteLine($"Numarul introdus este: {number1}");
        
            Console.WriteLine($"Introdu al doilea numar: ");
            string commeN2 = Console.ReadLine();
            var number2 = Convert.ToDouble(commeN2);
            Console.WriteLine($"Numarul introdus este: {number2} ");

            Segment segUserului = new Segment(number1, number2);

          var apartineS =  se.Contains(segUserului);

            Console.WriteLine($"Numerele introduse sunt: {apartineS} ");
            Console.ReadLine();


        }
    }
}
