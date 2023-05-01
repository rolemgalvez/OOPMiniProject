using HomeworkTwentyOneUI;

namespace HomeworkTwentyOneUI
{
    public static class Section
    {
        public static void Welcome()
        {
            Console.Clear();
            Console.WriteLine("Homework Twenty One");
            Console.WriteLine("-------------------");
            Console.WriteLine();
        }

        public static void Core()
        {
            Process.GetInformation();
            Process.PrintInformation();
        }

        public static void End()
        {
            Console.WriteLine();
            Console.WriteLine("End of program.");
            Console.ReadLine();
        }
    }
}
