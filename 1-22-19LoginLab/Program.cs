using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1_22_19LoginLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] emails = new string[1000];

            try
            {
                if (EmailValidation() == true)
                {
                    for (int i = 0; i < 1000; i++)
                    {
                        emails[i] = Console.ReadLine();
                        Console.WriteLine(emails[i]);
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please try again.");
            }
            string[] password = new string[1000];
            try
            {
                if (PasswordValidation() == true)
                {
                    Console.WriteLine("Please enter a password");
                    for (int x = 0; x < 1000; x++)
                    {
                        password[x] = Console.ReadLine();
                        Console.WriteLine(password[x]);
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please try again.");
            }
        }
        public static bool EmailValidation()
        {
            Console.WriteLine("Please enter an email address.");
            string userEmail = Console.ReadLine();
            while (!Regex.IsMatch(userEmail, @"^[\w\d]{3,30}@[\w\d]{3,10}.[\w\d]{2,3}$"))
            {
                Console.WriteLine("That is not a valid email address, please try again.");
                userEmail = Console.ReadLine();
            }
            Console.WriteLine("Congrats! That is a valid email address.");

            return true;
        }
        public static bool PasswordValidation()
        {
            Console.WriteLine("Please enter a password (that contains at least 1 uppercase letter, 1 number, and is at least 5 characters long).");
            string userPassword = Console.ReadLine();
            while (!Regex.IsMatch(userPassword, @"(?=.*[A-Z])(?=.*\d)(?=.*[a-zA-Z]).{5,}$"))
            {
                Console.WriteLine("That is not a valid password, please try again.");
                userPassword = Console.ReadLine();
            }
            Console.WriteLine("Congrats! That is a valid password.");

            return true;
        }
    }
}

