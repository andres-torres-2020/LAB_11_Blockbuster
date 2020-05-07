using System;

namespace LAB_11_BlockBuster
{
    class Program
    {
        static void Main(string[] args)
        {
            RunApp();
        }
        public static void RunApp()
        {
            Console.WriteLine("Welcome to GC Blockbuster Lab!\n");

            BlockBuster gcbb = new BlockBuster();

            bool keepWatching;
            string[] watchMoreYes = { "y", "yes" };
            string[] watchMoreNo = { "n", "no" };
            do
            {
                gcbb.CheckOut();
                keepWatching = InputUtil.GetInputBool("Watch another movie?", watchMoreYes, watchMoreNo);
            } while (keepWatching);
            Console.WriteLine("\nThank you and come again!\n");
        }
    }
}
