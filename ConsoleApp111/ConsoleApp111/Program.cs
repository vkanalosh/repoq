using System;

namespace ComplexNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double a1, a2, b1, b2, a3;
            string command;

            Console.WriteLine("Put first number.");
            a1 = Convert.ToDouble(Console.ReadLine());
            b1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Put second number.");
            a2 = Convert.ToDouble(Console.ReadLine());
            b2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Put not complex number.");

            a3 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Put command: +, - , *, /, + not complex, - not complex, * not complex, / not complex.");
            command = Console.ReadLine();
           
            ComplexNumber first = new ComplexNumber(a1, b1);
            ComplexNumber second = new ComplexNumber(a2, b2);

            switch (command)
            {
                case "+":
                    ComplexNumber resultAdd = first.Add(second);
                    ComplexNumber resultAdd2 = CN.Add(first, second);
                    resultAdd.Result(resultAdd);

                    bool result = resultAdd.IsReallyComplex();
                    resultAdd.SetIsReallyComplex(false);

                    bool result2 = resultAdd.check;
                    resultAdd.check = false;

                    Console.WriteLine(result);
                    break;

                case "-":
                    ComplexNumber resultSub = first.Sub(second);
                    resultSub.Result(resultSub);
                    break;

                case "*":
                    ComplexNumber resultMulti = first.Multi(second);
                    resultMulti.Result(resultMulti);
                    break;

                case "/":
                    ComplexNumber resultDiv = first.Div(second);
                    resultDiv.Result(resultDiv);
                    break;

                case "+ not complex":
                    ComplexNumber resultAddDouble = first.AddDouble(a3);
                    resultAddDouble.Result(resultAddDouble);
                    break;

                case "- not complex":
                    ComplexNumber resultSubDouble = first.SubDouble(a3);
                    resultSubDouble.Result(resultSubDouble);
                    break;

                case "* not complex":
                    ComplexNumber resultMultiDouble = first.MultiDouble(a3);
                    resultMultiDouble.Result(resultMultiDouble);
                    break;

                case "/ not complex":
                    ComplexNumber resultDivDouble = first.DivDouble(a3);
                    resultDivDouble.Result(resultDivDouble);
                    break;

            }

            

           

            // топорно зробив, але парцює )
            // створи 2 числа number1 i number2
            // number3 це number1 + number2
            // Console.WriteLine(number3.ToString())


            // Дописати клас ComplexNumber:
            // 1. Конструктор
            // 2. в main створити 2 змінні цього типу і вивести їх суму як 3-у змінну.
            //
            // Додатково: Віднімання, Множення, Ділення, Операції порівняння
            // Зчитування з консолі 2х чисел і вивести їх суму
            // в ідеалі зчитувати спочатку що зробити (sum +, sub -, mul *, div /) а потім A i B на кожне з 2-х чисел.
        }
    }
}