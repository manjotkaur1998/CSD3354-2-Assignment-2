using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//student name: manjot kaur
//CSD3354 section 2
//assignment 2
//march 8,2019




namespace Assignment2
{
    class Programa
    {

        public static void Main()
        {
            DelegateExercises delegateExercises = new DelegateExercises();
            delegateExercises.Method3();
            Console.ReadLine();

        }


        public class DelegateExercises
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
}