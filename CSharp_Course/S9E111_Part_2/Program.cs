using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

// Code will return output 5 file names with their size in Bytes.
// Sorted from Small to Big.
// Example WITH LINQ & Lambda-expressions ("=>")

namespace S9E111_Part_2
{
    //Extension method always in a static Class:
    public static class LinqExtensions // Extension Method
    {
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            if (source == null)
            {
                throw new ArgumentNullException();
            }

            foreach (var item in source) //source can use foreach because it is IEnumerable type
            {
                action(item);
            }
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            DisplayLargestFilesWithLINQ(@"/Users/user/Desktop");     //Change to relevant user!!!
          //DisplayLargestFilesWithoutLINQ(@"/Users/user/Desktop"); //Change to relevant user!!!

            Console.ReadLine();
        }

        private static void DisplayLargestFilesWithLINQ(string pathToDir)
        {
            new DirectoryInfo(pathToDir)  // using System.IO
            .GetFiles()
            .OrderBy(file => file.Length)  //using System.Linq;
            //.OrderByDescending = to sort from Big to small
            .Take(5)
            .ForEach(file => Console.WriteLine($"{file.Name} is {file.Length} Bytes"));
        }


        // This method was replaced by Lambda-expression
        /*
        static long KeySelector(FileInfo file)
        {
            return file.Length;
        }
        */

        // DisplayLargestFilesWithLINQ will replace all below code
        
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

            //Sort from small to big
            if (x.Length == y.Length) return 0;
            if (x.Length > y.Length) return 1;
            return -1;

            /*
            //Sort from big to small
            if (x.Length == y.Length) return 0;
            if (x.Length > y.Length) return -1;
            return 1;
            */
        }
    }
}
