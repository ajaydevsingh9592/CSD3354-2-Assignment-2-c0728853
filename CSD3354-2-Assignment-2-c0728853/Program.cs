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
        public static void Main()
        {
            DelegateExercises delegateExercises = new DelegateExercises();
            delegateExercises.Method3();
            Console.ReadLine();
        }
    }

    public delegate void MyDelegate();

    public class DelegateExercises
    {
        void Method3()
        {
            System.Console.WriteLine(MyDelegate.ToString());
        }
    }
}

