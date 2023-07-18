using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppStructures
{
    //public struct Student
    //{
    //    int id;
    //    string name;
    //    public Student(int _id, string _name)
    //    {
    //        //this way
    //        //this.id = _id;
    //        //this.name = _name;
    //        //or this way to initialise parameters
    //        id = _id;
    //        name = _name;
    //    }
    //    public void Display()
    //    {
    //        Console.WriteLine($"Student ID: {id} \t Student Name: {name}");
    //    }
    //}
    public struct Rectangle
    {
        public int width;
        public int height;
        //since width height declared publically, register fn not needed
        //public void Register()
        //{
        //    Console.WriteLine("Enter height");
        //    height = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Enter width");
        //    width = int.Parse(Console.ReadLine());

        //}
        public void Area()
        {
            int area = height * width;
            Console.WriteLine($"Area of rectangle {height} * {width} = {area}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
                //Student student = new Student(12, "Raj");
                //student.Display();
                //Student student1 = new Student(13, "Ravi Ranjan");
                //student1.Display();
                Rectangle rect;
                Console.WriteLine("Enter height");
                rect.height = int.Parse( Console.ReadLine() );
                Console.WriteLine("Enter width");
                rect.width = int.Parse( Console.ReadLine() );
                rect.Area();
                Console.ReadKey();

        }
    }
}
