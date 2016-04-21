using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bank101
{
    class Program
    {
        static void Main(string[] args)
        {
            Accounts acctNew = new Accounts();
            Clients clientNew = new Clients();
            bool Continue = true;

            do
            {
                //menu here

                //Menu 
                Console.WriteLine("The Magic Bank of Yonkers");
                Console.WriteLine("\n***********************************");
                Console.WriteLine("\nMENU");
                Console.WriteLine("1.View Client Information");
                Console.WriteLine("2.View Account Balance");
                Console.WriteLine("3.Deposit Funds");
                Console.WriteLine("4.Withdraw Funds");
                Console.WriteLine("5.EXIT");
                Console.Write("Please make menu selection(Ex. Enter -> 1 or 2):  ");

                int pickOne = 0;
                pickOne = int.Parse(Console.ReadLine());
                switch (pickOne)
                {
                    case 1:
                        Console.WriteLine("******************************");
                        Console.WriteLine("Client Information");
                        Console.WriteLine("\n" + clientNew.ToString());
                        Console.WriteLine("\n" + acctNew.AccountNumber);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Client Information");
                        Console.Write("Account Balance:  " + acctNew.Balance);
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Write("Enter Deposit Ammount:  ");
                        string input = Console.ReadLine();
                        double biz = double.Parse(input);
                        acctNew.Balance = acctNew.Deposit(acctNew.Balance, biz);

                        using (StreamWriter prettyTony = new StreamWriter("AccountSummary.txt", true))
                        {
                            prettyTony.WriteLine("test");
                        }



                        break;
                    case 4:
                        Console.Write("Enter Withdrawl Ammount:  ");
                        input = Console.ReadLine();
                        double zib = double.Parse(input);
                        acctNew.Balance = acctNew.Withdraw(acctNew.Balance, zib);

                        using (StreamWriter prettyTony = new StreamWriter("AccountSummary.txt", true))
                        {
                            prettyTony.WriteLine("test");
                        }

                        break;


                    case 5:
                        Console.WriteLine("\nGOODBYE");
                        System.Threading.Thread.Sleep(2000);
                        System.Environment.Exit(0);
                       
                        break;


                    default:


                        break;
                }
            
            
            }
                while (Continue);
            


        }
    }
}
