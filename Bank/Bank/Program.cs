using System;

namespace Bank
{
    public class Program
    {
        public static string FullLine;
        public static string[] Arguments;
        public static string Comand;

        public static void Write()
        {
            Console.WriteLine("Enter comand: add, widthdraw, put, send and parameters.");
            FullLine = Console.ReadLine();
            Arguments = FullLine.Split(" ");
            Comand = Arguments[0];
        }
        static int Main(string[] args)
        {
            Handle HandleMethods = new Handle();

            while (true)
            {
                Write();
                
                switch (Comand)
                {

                    case "add":
                        HandleMethods.HandleAdd(Arguments[1]);
                        break;

                    case "widthdraw":
                        HandleMethods.HandleWidthdraw(Arguments[1], Convert.ToDecimal(Arguments[2]));
                        break;

                    case "put":
                        HandleMethods.HandlePut(Arguments[1], Convert.ToDecimal(Arguments[2]));
                        break;

                    case "send":
                        HandleMethods.HandleSend(Arguments[1], Arguments[2], Convert.ToDecimal(Arguments[3]));
                        break;
                }
            }
        }
    }
}