using System;

namespace Fractions
{
    class Program
    {
        static void Main(string[] args)
        {
            long a1, b1, a2, b2;
            string comand;

            Console.WriteLine("Vvedite pervii drob.");
            a1 = Convert.ToInt64(Console.ReadLine());
            b1 = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Vvedite vtoroi drob.");
            a2 = Convert.ToInt64(Console.ReadLine());
            b2 = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Vvedite komandu: +, -, *, /.");
            comand = Console.ReadLine();

            Fractions first = new Fractions(a1, b1);
            Fractions second = new Fractions(a2, b2);

            switch (comand)
            {
                case "+":
                    Fractions resultAdd = first.Add(second);
                    resultAdd.Result();
                    resultAdd.Reducing();
                    resultAdd.ReducingResult();
                    break;

                case "-":
                    Fractions resultSub = first.Sub(second);
                    resultSub.Result();
                    break;

                case "*":
                    Fractions resultMulti = first.Multi(second);
                    resultMulti.Result();
                    break;

                case "/":
                    Fractions resultDiv = first.Div(second);
                    resultDiv.Result();
                    resultDiv.Reducing();
                    resultDiv.ReducingResult();
                    break;
                    
            }

        }
    }
}
