using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1_Homework
{
    class Login
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Login Lab");
            Console.WriteLine();

            int usernameAttempts = 0;
            int passwordAttempts = 0;
            bool lockOut = false;
            bool accessGranted = false;
            do
            {
                Console.WriteLine("Enter your username...");
                string userName = Console.ReadLine().ToLower();
                if (userName == "username")
                {
                    do
                    {
                        Console.WriteLine("Enter your password...");
                        string password = Console.ReadLine().ToLower();
                        if (password == "password")
                        {
                            accessGranted = true;
                        }
                        else if (password != "password" && passwordAttempts < 3)
                        {
                            Console.WriteLine("Try again...");
                            passwordAttempts++;
                            lockOut = true;
                        }
                    } while (passwordAttempts < 3 && accessGranted == false);
                }
                else if (userName != "username" && usernameAttempts < 3)
                {
                    Console.WriteLine("Invalid please try again...");
                    usernameAttempts++;
                }
                
            } while (usernameAttempts < 3 && lockOut == false && accessGranted == false);
            if (accessGranted == true)
            {
                Console.Clear();
                Console.WriteLine("You have been logged in! ");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You have been locked out, please try again later. ");
            }







            Console.WriteLine();
        }
    }
}
