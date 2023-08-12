namespace HowDebugMultiThreadedApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(SomeMethod)
            {
                Name="Thread 1"
            };

            Thread t2 = new Thread(SomeMethod)
            {
                Name="Thread 2"
            };

            t1.Start();
            t2.Start();

            Console.ReadKey();
        }

        public static void SomeMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                i++;
                Thread.Sleep(5000);
            }
        }
    }
}