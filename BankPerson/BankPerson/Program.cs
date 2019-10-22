using System;

namespace BankPerson
{
    public class Program
    {
        private static string fullLine;
        private static string[] Arguments;
        private static string Comand;

        private static void Write()
        {
            Console.WriteLine("Enter comand: add, addRange, addPerson, list, widthdraw, put, send and parameters.");
            fullLine = Console.ReadLine();
            Arguments = fullLine.Split(" ");
            Comand = Arguments[0];
        }
        static int Main(string[] args)
        {
            Handle handleMethods = new Handle();

            handleMethods.HandleLogin();

            while (true)
            {
                /*
                try
                {
                */
                    Write();

                    switch (Comand)
                    {

                        case "add":
                            handleMethods.HandleAdd(Arguments[1], Arguments[2]);
                            break;

                        case "addRange":
                            handleMethods.HandleAddRange(Arguments);
                            break;

                        case "widthdraw":
                            handleMethods.HandleWidthdraw(Arguments[1], Convert.ToDecimal(Arguments[2]));
                            break;

                        case "put":
                            handleMethods.HandlePut(Arguments[1], Convert.ToDecimal(Arguments[2]));
                            break;

                        case "send":
                            handleMethods.HandleSend(Arguments[1], Arguments[2], Convert.ToDecimal(Arguments[3]));
                            break;

                        case "list":
                            handleMethods.HandleList(Arguments[1]);
                            break;

                        case "addPerson":
                            handleMethods.HandleAddPerson(Arguments[1], Arguments[2]);
                            break;
                    }

                }
            /*
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                }
            */
            }
        }
    }
