using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppCustomExceptions
{
    public class CustomException : Exception
    {
        public CustomException(string message): base(message) { 
        }
    }
    internal class Program
    {
        public enum DayofWeek
        {
            Monday=1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }
        static void Main(string[] args)
        {
            DayofWeek today = DayofWeek.Tuesday;
            Console.WriteLine("Day: "+today);
            Console.WriteLine("Day Number: "+ (int)today);
            try
            {
                int userAge;
                Console.WriteLine("Enter your age");
                userAge = int.Parse(Console.ReadLine());
                if (userAge < 0)
                {
                    throw new CustomException("Age must be a positive number, Please enter positive number only");
                }
                else if (userAge >= 18)
                {
                    Console.WriteLine("You are eligible for voting");
                }
                else
                {
                    Console.WriteLine("You are not elgible for voting, become 18 first!");
                }
            }
            catch (CustomException ce)
            {
                Console.WriteLine("Custom Error!!"+ce.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!" + ex.Message);
            }
            finally { Console.WriteLine("**** Good Bye ****"); }
            Console.ReadKey();
        }
    }
}
