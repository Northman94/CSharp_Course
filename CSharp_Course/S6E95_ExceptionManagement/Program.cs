using System;
using System.IO;

namespace S6E95_ExceptionManagement
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Pls enter a numb.");


            string result = Console.ReadLine();

            int number = 0;

            try
            {
                number = int.Parse(result);
            }
            catch (FormatException formEx) // Certain exception
            {
                Console.WriteLine("A Format Exception has occured. Info below:");
                // Return all error info:
                Console.WriteLine(formEx.ToString());
            }
            catch (OverflowException overFlowEx)
            {

            }
            catch (Exception ex) // All of them. Any exception
            {
                // Usually used to write all info in a file
                Console.WriteLine(ex.ToString());
                //Zero at the end - means success
            }
            // - - - - - - - - - - - - - - - - - - - - - - - -


            FileStream file = null; //using System.IO;
            try
            {
                file = File.Open("temp.txt", FileMode.Open);
            }
            catch (IOException IOex)
            {
                Console.WriteLine(IOex);
            }
            catch
            {
                // Will do same "genaral" as previous, but with no IOex reach
                // It's a bad coding!!!
            }
            finally
            {
                //Will always trigger. Recommened for unmanaged resourses closure
                if (file != null)
                {
                    file.Dispose();
                } 

            }

            Console.WriteLine(number);
        }
    }
}
