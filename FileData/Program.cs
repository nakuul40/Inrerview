using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TextReader input = Console.In;
            TextWriter output = Console.Out;
            Console.WriteLine("Do you want the version of file or size of the file:");
            var firstinput = input.ReadLine();
            MethodWrapperClass wc = new MethodWrapperClass();
            if (firstinput == "-v" || firstinput == "--v" || firstinput == "/v" || firstinput == "--version")
            {
                Console.WriteLine("Please enter the second parameter :");
                var inputforfile = input.ReadLine();
                wc.Version(inputforfile);
                Console.Write("Press any key to close the File app...");
                input.ReadLine();
            }
            else if (firstinput == "-s" || firstinput == "--s" || firstinput == "/s" || firstinput == "--size")
            {
                Console.WriteLine("Please enter the second parameter :");
                var inputforfile = input.ReadLine();
                wc.Size(inputforfile);
                Console.Write("Press any key to close the File app...");
                input.ReadLine();
            }
            else
            {
                Console.WriteLine("Opps!!!You entered the invalid option");
                Console.Write("Press any key to close the File app...");
                input.ReadLine();
            }
        }
    }
}
