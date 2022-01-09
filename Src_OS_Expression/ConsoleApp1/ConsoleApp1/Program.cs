using System;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                //OS毎の処理

                Console.WriteLine("OS is Windows.");

                Console.WriteLine(RuntimeInformation.OSDescription);
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                //OS毎の処理

                Console.WriteLine("OS is Linux.");

                Console.WriteLine(RuntimeInformation.OSDescription);
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                //OS毎の処理

                Console.WriteLine("OS is OSX.");

                Console.WriteLine(RuntimeInformation.OSDescription);
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.FreeBSD))
            {
                //OS毎の処理

                Console.WriteLine("OS is FreeBSD.");

                Console.WriteLine(RuntimeInformation.OSDescription);
            }
        }
    }
}
