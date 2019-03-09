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
        public static void Main(string[] args)
        {
            DelegateExercises de = new DelegateExercises();
            de.Method3();
            Console.Read();
        }
    }
    public delegate void MyDelegate();
    public class DelegateExercises
    {
        void Method1()
        {
            System.Console.WriteLine("Method1");
        }
        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
        }
    }

}
