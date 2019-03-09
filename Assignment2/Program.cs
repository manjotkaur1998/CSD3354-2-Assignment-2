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
    public class Program
    {
        public static void Main()
        {
            DelegateExercises delegateExercises = new DelegateExercises();
            delegateExercises.Method3();
        }
    }

    public class DelegateExercises
    {
        public delegate int MyDelegate();

        void Method1()
        {
            System.Console.WriteLine("MyDelegate");
        }

        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
        }
    }
}