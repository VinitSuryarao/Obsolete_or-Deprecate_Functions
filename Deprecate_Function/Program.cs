using System;

namespace Deprecate_Function
{
    class Program
    {
        static void Main(string[] args)
        {

            // Sometime some function are no longer use
            // Make then Obsolete  to prevent use my anyone else
            // we can add message as well
            // This is call Deprecate Functions

            Demo obj = new Demo();


            obj.Function1();
            // It give below warning without message
            // 'Demo.Function1()' is Obsolete


            obj.Function2();
            // It give below warning with message
            // 'Demo.Function2()' is Obsolete : 'This method is no longer use PLease use Function3()'


            obj.Function3();
            // It give below error with message
            // 'Demo.Function3()' is Obsolete : 'This method is no longer use PLease use Function4()'


            obj.Function4();
            // This will run smoothly


            Console.WriteLine("Hello World!");
        }
    }

    public class Demo
    {
        // Deperecate and gives warning without message
        [Obsolete]
        public void Function1()
        {
            Console.WriteLine(" This is Function1 ");
        }

        // Deperecate and gives warning with message
        [Obsolete("This method is no longer use PLease use Function3()", false)]
        public void Function2()
        {
            Console.WriteLine(" This is Function2 ");
        }

        // Deperecate and gives error with message
        [Obsolete("This method is no longer use PLease use Function4()", true)]
        public void Function3()
        {
            Console.WriteLine(" This is Function3 ");
        }

        // Run Smoothly
        public void Function4()
        {
            Console.WriteLine(" This is Function4");
        }
    }
}
