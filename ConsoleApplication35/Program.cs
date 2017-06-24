using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication35
{
    class Program
    {
        static void Main(string[] args)
        {
            Accounts[] accounts = new Accounts[3];

            accounts[0] = new Accounts("Somebody", "hi", "Paublo", 300);
            accounts[1] = new Accounts("Somebody else", "bye", "Tyrone", 250);
            accounts[2] = new Accounts("Somebody new", "morning", "Austin", 350);




            //Establishing RECOVERY answers
            Console.WriteLine("Welcome to the bank, please log in");
            Console.WriteLine("Please type in your username");
            string username = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            string password = Console.ReadLine();

            bool success = false;
            int userIndex = -1;
            for (int i = 0; i < accounts.Length; i++)
            {
                if (username == accounts[i].username && password == accounts[i].password)
                {
                    success = true;
                    userIndex = i;
                }
            }

            if (success)
            //deciding wether the user input matches the correct username and password 
            {
                Console.WriteLine("Type in your secturity password");
                Console.WriteLine("What is your name?");
                if (Console.ReadLine() == accounts[userIndex].recoveryQ)
                //Deciding wether security passwords that user inputted match the correct answers
                {
                    Console.WriteLine("Welcome to your bank ready to make deposits, withdrawals and tranfers");
                }
                

                while (true)
                //looping the deposits and withdrawals so the user keeps recieving options
                {
                    int money = accounts[userIndex].balance;

                    Console.WriteLine($"You currently have {money} in your account");
                    //Weloming them into the back account showing how much money they have
                    Console.WriteLine("Would you like to make deposits, withdrawals or transfers?");
                    String response = Console.ReadLine();
                    if (response == "deposits")
                    {
                        Console.WriteLine("How much money would you like to deposit");
                        int amount = int.Parse(Console.ReadLine());
                        Console.WriteLine("Deposit accepted");
                        accounts[userIndex].balance += amount;
                    }

                    if (response == "withdrawals")
                    {
                        Console.WriteLine("How much money would you like to withdraw");
                        int amount = int.Parse(Console.ReadLine());
                        if (amount > money)
                        {
                            Console.WriteLine("Can not withdraw more than you have");
                        }
                        //so you cant withdraw more than you have
                        else
                        {
                            money = money - amount;
                            Console.WriteLine("Withdrawal accepted");
                            accounts[userIndex].balance -= amount;
                        }
                    }

                    //transfers between the two accounts
                    if (response == "transfers")
                    {
                        Console.WriteLine("How much money would you like to transfer to the other account?");
                        int tamount = int.Parse(Console.ReadLine());
                        if (userIndex == 0)
                        {
                            accounts[0].balance = accounts[0].balance - tamount;

                            accounts[1].balance += tamount;
                            if (accounts[0].balance < tamount)
                            {
                                Console.WriteLine("Cannot transfer more than you have");
                            }

                        }
                        else if (userIndex == 1)
                        {
                            accounts[1].balance -= tamount;

                            accounts[0].balance += tamount;

                            if (accounts[1].balance < tamount)
                            {
                                Console.WriteLine("Cannot tranfer")
                            }
                        }

                        // Find the index of the balances array that you are at (which is whatever user you are on. So if your user is "Somebody", then your index is 0)
                        // if userIndex is 0, transfer to 1
                        // if its 1 transfer to 0
                        // balances[1] -= tAmount
                        // balances[0] += tAmount


                    }

                }


            }
            Console.ReadKey();
        }


    }
}