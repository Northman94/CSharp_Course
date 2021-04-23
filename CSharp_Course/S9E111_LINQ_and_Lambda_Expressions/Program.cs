using System;
using System.IO;

// Code will return output 5 file names with their size in Bytes.
// Sorted from Big to Small.
// Example without LINQ & Lambda-expressions ("=>")

namespace S9E111_LINQ_and_Lambda_Expressions
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DisplayLargestFilesWithoutLINQ(@"/Users/user/Desktop"); //Change to relevant user!!!

            Console.ReadLine();
        }


        private static void DisplayLargestFilesWithoutLINQ(string pathToDir)
        {
            var dirInfo = new DirectoryInfo(pathToDir); // using System.IO;

            FileInfo[] files = dirInfo.GetFiles();

            Array.Sort(files, FilesComparison);

            for (int i = 0; i < 5; i++)
            {
                FileInfo file = files[i];
                Console.WriteLine($"{file.Name} is {file.Length} Bytes \n\n");
            }
        }


        static int FilesComparison(FileInfo x, FileInfo y)
        {
            //To understand - should read Array.Sort documentation.
            //Array.Sort behaves in a d

            //Sort from big to small
            if (x.Length == y.Length) return 0;
            if (x.Length > y.Length) return -1;
            return 1;

            /*
            //Sort from small to big
            if (x.Length == y.Length) return 0;
            if (x.Length > y.Length) return 1;
            return -1;
            */
        }
    }
}
