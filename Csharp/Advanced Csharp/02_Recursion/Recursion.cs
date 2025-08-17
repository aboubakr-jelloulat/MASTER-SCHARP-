using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Csharp._02_Recursion
{
    static  class clsRecursion
    {
        public static int CalculateFactorial(int nb)
        {
            if (nb <= 1)
                return 1;

            return nb * CalculateFactorial(nb - 1);
        }

        public static void PrintDirectoryFileSystemEntries(string DirPath, int Level)
        {
            // 1) Print all FILES in the current directory
            foreach (var FileName in Directory.GetFiles(DirPath))
                Console.WriteLine($"{new string ('-', Level)} {new FileInfo(FileName).Name}");

            // 2) Then, for each SUBDIRECTORY:
            foreach (var DirName in Directory.GetDirectories(DirPath))
            {
                // 2a) Print the directory's name at the current indent level
                Console.WriteLine($"{new string ('-', Level)}  {new DirectoryInfo(DirName).Name}");

                // 2b) Recurse into that subdirectory with Level+1 (one more indent)
                PrintDirectoryFileSystemEntries(DirName, Level + 1);
            }

        }

        public static long ClaculateDirectorySize(string DirPath)
        {
            long size = 0;

            foreach (var FileName in Directory.GetFiles(DirPath))
                size += new FileInfo(FileName).Length;

            foreach(var DirName in Directory.GetDirectories(DirPath))
            {
                size += ClaculateDirectorySize(DirName);

            }

            return size;
        }


    }
}
