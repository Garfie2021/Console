using System;
using System.Globalization;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //const string = "ja-JP";
            const string cultureName = "ru-RU";

            //CultureInfo.CurrentCulture = new CultureInfo(cultureName, false);
            //CultureInfo.CurrentUICulture = new CultureInfo(cultureName, false);
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo(cultureName, false);
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo(cultureName, false);
            //Thread.CurrentThread.CurrentCulture = new CultureInfo(cultureName, false);
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultureName, false);

            Console.WriteLine("CultureInfo.CurrentCulture.Name : " + CultureInfo.CurrentCulture.Name);
            Console.WriteLine("CultureInfo.CurrentUICulture.Name : " + CultureInfo.CurrentUICulture.Name);
            Console.WriteLine("CultureInfo.DefaultThreadCurrentCulture.Name : " + CultureInfo.DefaultThreadCurrentCulture.Name);
            Console.WriteLine("CultureInfo.DefaultThreadCurrentUICulture.Name : " + CultureInfo.DefaultThreadCurrentUICulture.Name);
            Console.WriteLine("Thread.CurrentThread.CurrentCulture.Name : " + Thread.CurrentThread.CurrentCulture.Name);
            Console.WriteLine("Thread.CurrentThread.CurrentUICulture.Name : " + Thread.CurrentThread.CurrentUICulture.Name);
        }
    }
}
