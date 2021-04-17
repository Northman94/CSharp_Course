using System;
using System.IO;


// Just Examples.  Will not work properly due to lack of file creation!!!

namespace S7E98_Files_Directories_Folders
{
    class MainClass 
    {
        public static void Main(string[] args)
        {
            try
            {
                // Methods working with external sourses should be covered somewhere with try/catch
                DirFileDemo(); 
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            Console.WriteLine("Program End");
        }
        
        
        static void DirFileDemo() 
        {
            
            //File.Copy("text8.txt", @"C:\...Desktop\text8_copy.txt", overwrite: true); //Locations - full path //+ named parameter
            File.Copy("text8.txt", "text8_copy.txt", overwrite: true); //Locations - relative path //+ named parameter
            

            File.Move("text8_copy.txt", "text8_copy_renamed.txt"); //Move file to a new location + can be renamed.

            File.Delete("text8_copy.txt");

            if (File.Exists("text.txt")) //direct or relative path
            {
                File.AppendAllText("text.txt", "some text");
                // This reading file part or calling this method outer code, should be covered wtih try/catch,
                // beacause File.Exists this second returnd true, and next second file can be deleted by another code part.
            }


            File.Replace("fileToRewrite.txt", "fileRewriter.txt", "fileToRewrite_Backup.txt");
            //Right before 1st file will be replaced with 2nd one, all 1st file data will be copied to 3rd one.


            // Working with directories:

            bool existsDirectoryWin = Directory.Exists(@"C:\tmp"); // Windows
            

            
            bool existsDirectoryMAC = Directory.Exists(@"/Users/Zhanat/Desktop"); // Mac -  !userName!

            Console.WriteLine(existsDirectoryMAC + " - Directory");
            


            bool existsFolderMAC = Directory.Exists(@"/Users/Zhanat/Desktop/New Folder"); // Mac -  !userName!

            Console.WriteLine(existsFolderMAC + " - New Folder present");
            Console.ReadKey();

            
            if (existsDirectoryMAC)
            {
                // Will return All file names located in current Directory.
                // Directory can disappear anytime. Use try/catch.
                var files = Directory.EnumerateFiles(@"/Users/userName/Desktop", "*.png");


                var files2 = Directory.EnumerateFiles(@"/Users/userName/Desktop", "*.png", SearchOption.AllDirectories);
                // TopDirectoryOnly - search in basic files
                // AllDirectories - serch in all in infolded files


                foreach (var filePath in files2)
                {
                    Console.WriteLine(filePath);
                }
            }


            Directory.Delete("write path here");


            Path.GetExtension("write path here"); //returns file extencion: e.g. .jpg

            Path.GetFileName("write path here");

            string combinedPath = Path.Combine(@"/Users/userName/Desktop", "/New Folder/image.jpg"); //Combines two strings into a Path

        }
    }
}

