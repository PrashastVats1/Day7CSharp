using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Assignment9
{
    public class ValidationException : Exception
    {
        public ValidationException(string message) : base(message) { }
    }

    public class UserRegistrationValidator
    {
        public static void ValidateInput(string name, string email, string password)
        {
            //Check whether required fields are provided
            if(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password)) {
                throw new ValidationException("Name, email and password are required");
            }
            //Check name length
            if (name.Length < 6)
            {
                throw new ValidationException("User name must have at least  6 characters");
            }
            //Check password length
            if(password.Length < 8)
            {
                throw new ValidationException("Password must have at least 8 characters");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isValidInput = false;
            while(!isValidInput) {
                try
                {
                    //user input
                    Console.WriteLine("Enter your name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter your email");
                    string email = Console.ReadLine();
                    Console.WriteLine("Enter your password");
                    string pwd = Console.ReadLine();
                    //Validate user input using the validate user class
                    UserRegistrationValidator.ValidateInput(name, email, pwd);
                    //if input is valid, display success message and user details entered
                    Console.WriteLine("User Registration is a success");
                    Console.WriteLine("User Name: \t" + name);
                    Console.WriteLine("User Email: \t" + email);
                    Console.WriteLine("User Password: \t" + pwd);
                    isValidInput = true;
                }
                catch (ValidationException ve) {
                    Console.WriteLine("Validation Error " + ve.Message);
                    Console.WriteLine("Please try again");
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error!!!! " + ex.Message);
                    Console.WriteLine("Please try again");
                }
            }
            Console.ReadKey();
        }
    }
}
