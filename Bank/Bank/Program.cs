using System;

namespace Bank
{
    public class Program
    {
        public static string fullLine;
        public static string[] arguments;
        public static string comand;
        
        public static void Write()
        {
            Console.WriteLine("Enter comand: add, widthdraw, put, send and parameters.");
            fullLine = Console.ReadLine();
            arguments = fullLine.Split(" ");
            comand = arguments[0];
        }
        static int Main(string[] args)
        {
            
            while (true)
            {
                Write();

                switch (comand)
                {
                    case "add":
                        Handle.HandleAdd(arguments[1]);
                        break;

                    case "widthdraw":
                        Handle.HandleWidthdraw(arguments[1], arguments[2]);
                        break;

                    case "put":
                        Handle.HandlePut(arguments[1], arguments[2]);
                        break;

                    case "send":
                        Handle.HandleSend(arguments[1], arguments[2], arguments[3]);
                        break;
                }
            }
        }
    }
}