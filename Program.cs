using System;
using System.Text.RegularExpressions;

namespace Lab7RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "C#.NET Lab 7: Regular Expressions";

            ValidateFirstName();
            ValidateEmail();
            ValidatePhoneNumber();
            ValidateDate();
            ValidateHTML();

            Console.ReadKey();
        }

        /* Method that will validate first names
         * Names can only have alphabets, start with a capital letter, and have a maximum length of 30
         */
        public static void ValidateFirstName()
        {
            string namePattern = "^[A-Z][a-zA-Z]{1,29}$";

            Regex regex = new Regex(namePattern);

            bool isValid = false;
            do
            {
                Console.Write("Enter a valid name: ");
                string userInput = Console.ReadLine();

                bool isMatch = regex.IsMatch(userInput);

                if (isMatch == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Sorry, the name {userInput} is not valid!");
                    Console.ResetColor();
                }
                else
                {
                    isValid = true;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Name is valid.");
                    Console.ResetColor();
                }
            } while (isValid == false);

        }

        /* Method that will validate emails
         * Email Format:
         *      combination of alphanumeric characters, with a length between 5 and 30, and there are no special characters
         *      @
         *      combination of alphanumeric characters, with a length between 5 and 10, and there are no special charcters
         *      .
         *      domain can be a combination of alphanumeric characters with a length of two or three
         */
        public static void ValidateEmail()
        {
            string emailPattern = "^[A-Za-z0-9]{5,30}@[a-zA-Z0-9]{5,10}.[a-z]{2,3}$";

            Regex regex = new Regex(emailPattern);

            bool isValid = false;
            do
            {
                Console.Write("Enter a valid email: ");
                string userInput = Console.ReadLine();

                bool isMatch = regex.IsMatch(userInput);

                if (isMatch == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Sorry, the email {userInput} is not valid!");
                    Console.ResetColor();
                }
                else
                {
                    isValid = true;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Email is valid");
                    Console.ResetColor();
                }
            } while (isValid == false);

        }

        /* Method that will validate phone numbers
         * Phone Number Format:
         *      area code of 3 digits
         *      -
         *      3 digits
         *      -
         *      4 digits
         */
        public static void ValidatePhoneNumber()
        {
            string phonePattern = "^[0-9]{3}-[0-9]{3}-[0-9]{4}$";

            Regex regex = new Regex(phonePattern);

            bool isValid = false;
            do
            {
                Console.Write("Enter a valid phone number: ");
                string userInput = Console.ReadLine();

                bool isMatch = regex.IsMatch(userInput);

                if (isMatch == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"The phone number {userInput} is not valid!");
                    Console.ResetColor();
                }
                else
                {
                    isValid = true;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Phone number is valid!");
                    Console.ResetColor();
                }
            } while (isValid == false);


        }

        /* Method that will validate a date
         * Date Format:
         *      dd/mm/yyyy
         */
        public static void ValidateDate()
        {
            string datePattern = @"^[0-9]{2}/[0-9]{2}/[0-9]{4}$";

            Regex regex = new Regex(datePattern);

            bool isValid = false;

            do
            {
                Console.Write("Please enter a valid date: ");
                string userInput = Console.ReadLine();

                bool isMatch = regex.IsMatch(userInput);

                if (isMatch == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Sorry. the date {userInput} is not valid!");
                    Console.ResetColor();
                }
                else
                {
                    isValid = true;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"The date {userInput} is valid.");
                    Console.ResetColor();
                }
            } while (isValid == false);

        }

        /* Method that will validate HTML elements
         *  Example:
         *      <p> </p> is a valid html element
         *      <h1> <h1> is not valid
         */
        public static void ValidateHTML()
        {
            string htmlPattern = @"^<[a-z0-9]+>[ ]*<\/[a-z0-9]+>$";

            Regex regex = new Regex(htmlPattern);

            bool isValid = false;
            do
            {
                Console.Write("Enter a valid html element: ");
                string userInput = Console.ReadLine();

                bool isMatch = regex.IsMatch(userInput);

                if (isMatch == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"The HTML element {userInput} is not valid.");
                    Console.ResetColor();
                }
                else
                {
                    isValid = true;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"The HTML element {userInput} is valid.");
                    Console.ResetColor();
                }
            } while (isValid == false);

        }
    }
}
