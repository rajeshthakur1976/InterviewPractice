using System;

namespace ConsoleAppPtactice
{
    class Program
    {
        static void Main(string[] args)
        {
          
            SingletonDemo.Singleton fromteacher = SingletonDemo.Singleton.GetInstance;
            fromteacher.PrintDetails("From Teacher");
            SingletonDemo.Singleton fromstudent = SingletonDemo.Singleton.GetInstance;
            fromteacher.PrintDetails("From student");
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
