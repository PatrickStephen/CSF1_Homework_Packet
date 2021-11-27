using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1_Homework
{
    class ATM_App
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ATM Application");

            int accountAttempts = 0;
            int passwordAttempts = 0;
            bool lockOut = false;
            bool accessGranted = false;

            do
            {
                Console.WriteLine("Enter your account number...");
                string accountNbr = Console.ReadLine().ToLower();
                if (accountNbr == "12345")
                {
                    do
                    {
                        Console.WriteLine("Enter your password...");
                        string password = Console.ReadLine().ToLower();
                        if (password == "password")
                        {
                            accessGranted = true;
                        }
                        else if (password != "password" && passwordAttempts < 3);
                        {
                            Console.WriteLine("Incorrect password, please try again...");
                            passwordAttempts++;
                            lockOut = true;
                        }
                    } while (passwordAttempts < 3 && accessGranted == false);
                }
                else if (accountNbr != "12345" && accountAttempts < 3)
                {
                    Console.WriteLine("Wrong account number, please try again...");
                    accountAttempts++;
                }
            } while (accountAttempts < 3 && lockOut == false && accessGranted == false);

            if (lockOut == true)
            {
                Console.Clear();
                Console.WriteLine("You have been locked out. Please try again later. ");
            }
                Console.Clear();

            do
            {
                Console.WriteLine(@"
Please choose a selection from the list below...
1) Deposit
2) Withdraw
3) Exit
");
                string userOption = Console.ReadLine().ToLower();
                switch (userOption)
                {
                    case "1":
                    case "Deposit":
                    case "D":
                        Console.Clear();
                        Console.WriteLine("Please choose an amount to deposit...");
                        decimal userDeposit = decimal.Parse(Console.ReadLine());
                        Console.WriteLine($"You have deposited {userDeposit:c} into your account...");
                        Console.Write("Would you like to make another selection? Y/N ");
                        ConsoleKey Y1 = Console.ReadKey().Key;
                        Console.Clear();                        
                        if (Y1 == ConsoleKey.N)
                        {
                            Console.WriteLine("Thank you for your business, we hope to see you again soon! ");
                            accessGranted = false;

                        }
                        break;

                    case "2":
                    case "Withdraw":
                    case "W":
                        Console.Clear();
                        Console.WriteLine("Please choose an amount to withdraw...");
                        decimal userWithdraw = decimal.Parse(Console.ReadLine());
                        Console.WriteLine($"You have withdrawn {userWithdraw:c} from your account...");
                        Console.Write("Would you like to make another selection? Y/N ");
                        ConsoleKey Y2 = Console.ReadKey().Key;
                        Console.Clear();
                        if (Y2 == ConsoleKey.N)
                        {
                            Console.WriteLine("Thank you for your business, we hope to see you again soon! ");
                            accessGranted = false;
                        }
                        break;

                    case "3":
                    case "Exit":
                    case "End":
                    case "E":
                        Console.Clear();
                        Console.WriteLine("Thank you for choosing, Know Nothing Banking. We hope to see you again soon! ");
                        accessGranted = false;
                        break;
                }



            } while (accessGranted == true);
        }
    }
}
