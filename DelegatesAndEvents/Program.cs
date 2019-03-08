using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Student 1 ---- Tirth Patel ---- C0732052----- CSD3354 Section2----- Assignment 2---- March 6,2019
// Student 2 ---- Harshil Jariwala ---- C0732049----- CSD3354 Section2----- Assignment 2---- March 6,2019

namespace DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class DelegateExercises
    {
        public delegate void MyDelegate();
        void Method1()
        {
            Console.WriteLine("Method1");
            Console.ReadLine();
        }
        public void Method2()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
        }
    }
}
