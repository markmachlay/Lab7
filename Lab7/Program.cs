using System;
using System.Text.RegularExpressions;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidateNames();
            ValidateEmail();
            ValidatePhoneNumber();
            ValidateDate();

        }
        static void ValidateNames()
        {
            Regex userFirstName = new Regex(@"^[A-Z][a-z]{1,30}");
            Console.WriteLine("Please enter your first name");
            var firstName = Console.ReadLine();

            if (userFirstName.IsMatch(firstName))
            {
                Console.WriteLine($"Thank you {firstName}");
            }
            else
            {
                Console.WriteLine("You entered an invalid name");
            }
        }
        static void ValidateEmail()
        {
            Regex email = new Regex(@"(\w+)@(\w+)(\.(\w{2,3}))");
            Console.WriteLine("Please enter your email");
            var userEmail = Console.ReadLine();

            if (email.IsMatch(userEmail))
            {
                Console.WriteLine("Thank you for providing an email");
            }
            else
            {
                Console.WriteLine("The email you entered is invalid");
            }
        }
        static void ValidatePhoneNumber()
        {
            Regex pattern = new Regex(@"(\d{3}-)(\d{3}-)(\d{4})");
            Console.WriteLine("Please enter your phone number");
            var phoneNumber = Console.ReadLine();

            if (pattern.IsMatch(phoneNumber))
            {
                Console.WriteLine("Thank for providing your phone number");
            }
            else
            {
                Console.WriteLine("The phone number was entered incorrectly");
            }
        }
        static void ValidateDate()
        {
            Regex date = new Regex(@"(\d{2})\/(\d{2})\/(\d{4})");
            Console.WriteLine("Please enter your birthday");
            var userDate = Console.ReadLine();

            if (date.IsMatch(userDate))
            {
                Console.WriteLine("Thank you for providing  your birthday");
            }
            else
            {
                Console.WriteLine("This is not a valid date");
            }
        }
    }
}
