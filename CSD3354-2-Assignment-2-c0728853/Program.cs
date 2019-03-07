using System;

namespace CSD3354_2_Assignment_2_c0728853
//AJAY DEV SINGH C0728853
//SANDEEP BEHAL C0727520
//CSD3354 SECTION 1
//ASSIGNMENT 2
//March 7,2019
{
    public class Program
    {
        static void Main(string[] args)
        {
            DelegateExcercises delegateExcercises = new DelegateExcercises();
            delegateExcercises.Method3();
            Console.ReadLine();
        }
    }
    public delegate void MyDelegate();

    public class DelegateExcercises
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

