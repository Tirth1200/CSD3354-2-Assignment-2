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
            DelegateExercises de = new DelegateExercises();
            de.Method2(50);
        }
    }
    public class DelegateExercises
    {
        public delegate void MyDelegate(int i);
        public void Method1(int i)
        {
            Console.WriteLine("Method1");
            Console.WriteLine(i) ;
            Console.ReadLine();
        }
        public void Method2(int i)
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate(50);
        }
    }
}
