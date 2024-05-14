using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hansi proses
            //1-balance goster
            //2-pul cekmek
            //3-pul vurmaq
            //q-exit
            int password = 1981;
            Console.WriteLine("Please enter the password : ");
            int passwd = Convert.ToInt32(Console.ReadLine());

            if (passwd == 1981)
            {

                Console.WriteLine("Welcome.Please,select the procces you want to do:");

                Console.WriteLine("1-Show balance.");

                Console.WriteLine("2-Take the money.");

                Console.WriteLine("3-Invest money.");

                Console.WriteLine("4-Exit procces.");

                Console.Write("Select:");
                int procces = Convert.ToInt32(Console.ReadLine());

                int balance = 5000;

                if (procces == 1)
                {
                    Console.WriteLine("Balance : " + balance);
                }
                else if (procces == 2)
                {
                    Console.WriteLine("How much do you want to take?");
                    int takemoney = Convert.ToInt32(Console.ReadLine());
                    if (balance >= takemoney)
                    {
                        int balanceqalan = balance - takemoney;
                        Console.WriteLine("Procces succesfully.New Balance" + " = " + balanceqalan);
                    }
                    else
                    {
                        Console.WriteLine("Procces failed.Please try again.");
                    }
                }
                else if (procces == 3)
                {
                    Console.WriteLine("How much do you want to invest?");
                    int investmoney = Convert.ToInt32(Console.ReadLine());
                    int yenibalance = balance + investmoney;
                    Console.WriteLine("Procces succesfully.New Balance" + " = " + yenibalance);
                }
                else if (procces == 4)
                {
                    Console.WriteLine("Exit succesfully.Thanks!");
                }
                else
                {
                    Console.WriteLine("Procces not found.Please try again!");
                }
            }
            else
            {
                Console.WriteLine("Password is wrong.Please try again.");
            }
            Console.ReadLine();
        }
    }
}
