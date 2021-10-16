using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public class MethodWrapperClass
    {
        public string Version(string s)
        {
            FileDetails fd = new FileDetails();
            Console.WriteLine(fd.Version(s));
            return fd.Version(s);

        }
        public int Size(string s)
        {
            FileDetails fd = new FileDetails();
            Console.WriteLine(fd.Size(s));
            return fd.Size(s);

        }
    }
}
