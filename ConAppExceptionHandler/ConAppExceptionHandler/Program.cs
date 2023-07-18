using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppExceptionHandler
{
    public class Calculation
    {
        public static byte Add(byte num1, byte num2)
        {
            var result = num1 + num2;
            return (byte)result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num1, num2, result;
            //try
            //{
            //    Console.WriteLine("Enter first number");
            //    num1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter second number");
            //    num2 = int.Parse(Console.ReadLine());
            //    result = num1 + num2;
            //    Console.WriteLine("Result after adding {0} and {1} = \t {2}", num1, num2, result);
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine("Error!!" + ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("End of Program");
            //    Console.ReadKey();
            //}


            byte fNum, sNum, result;
            try
            {
                Console.WriteLine("Enter first number");
                fNum = byte.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number");
                sNum = byte.Parse(Console.ReadLine());
                result = Calculation.Add(fNum, sNum);
                Console.WriteLine("Result after adding {0} and {1} = \t {2}", fNum, sNum, result);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Error!!" + fe.Message);
            }
            catch (OverflowException oe)
            {
                Console.WriteLine("Error!!" + oe.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!" + ex.Message);
            }
            finally
            {
                Console.WriteLine("End of Program");
                Console.ReadKey();
            }
        }
    }
}
