using System;

namespace CSD3354_2_Assignment_2_c0728853
//AJAY DEV SINGH C0728853
//SANDEEP BEHAL C0727520
//CSD3354 SECTION 1
//ASSIGNMENT 2
//March 7,2019
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegateExcercises de = new DelegateExcercises();
            de.Method3();
        }
    }
    public class DelegateExcercises
    {
        public delegate int MyDelegate(int intValue);

        public int Method1(int intMethod1)
        {
            return intMethod1 * 2;
        }
        public int Method2(int intMethod2)
        {
            return intMethod2 * 10;
        }
        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            int result1 = myDelegate(10);
            System.Console.WriteLine(result1);
            myDelegate = new MyDelegate(Method2);
            int result2 = myDelegate(10);
            System.Console.WriteLine(result2);
        }
    }
}

