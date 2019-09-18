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

            while (true)
            {
                Write();

                switch (Comand)
                {

                    case "add":
                        Handle.HandleAdd(Arguments[1]);
                        break;

                    case "widthdraw":
                        Handle.HandleWidthdraw(Arguments[1], Convert.ToDecimal(Arguments[2]));
                        break;

                    case "put":
                        Handle.HandlePut(Arguments[1], Convert.ToDecimal(Arguments[2]));
                        break;

                    case "send":
                        Handle.HandleSend(Arguments[1], Arguments[2], Convert.ToDecimal(Arguments[3]));
                        break;
                }

            }

        }
    }
}