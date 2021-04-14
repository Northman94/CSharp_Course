using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace S7E97_Files_and_Streams
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Going to create a File in Folder BinDebug or BinRelease
            // according to Debug or Release build Launch type

            //using System.IO; 
            Stream fs = new FileStream("test1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);


            // Working with Streams always should be covered in Try / Catch

            try
            {
                string str1 = "Hello, World!";

                // using System.Text;
                // ASCII table (American standard code for information interchange)

                byte[] strInBytes = Encoding.ASCII.GetBytes(str1);

                //From start = 0, to the end .Length
                fs.Write(strInBytes, 0, strInBytes.Length);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.ToString()} ");
            }
            finally
            {
                // Best practice to close stream in Finally block
                // Will execute in all cases
                fs.Close();
               // Choosing between .Close  &  .Dispose - select .Close
               // due to async nature
            }

            Console.ReadLine();

            /*
            // Variation: using in this case is same as Try/Catch/Finally
            using (Stream readingStream = new FileStream("testRead.txt", FileMode.Open, FileAccess.Read))
            {
                //Bite stream is called Buffer

                // Every iteration will read 14 Bytes and conver to string
                byte[] byteBuffer = new byte[14];
                // Can be done better. instead of 14 Bytes length
                // we can create Buffer with length of stream
                // & in while loop - read any size file to the end

                // We wrote file in ASCII, so will read in it
                //ASCIIEncoding encoding = new ASCIIEncoding();
                //Commented this due to having it in while loop (VVV)

                int bytesRead = 0;
                //Arrays are transferend by refference, Read method will weite to our Array
                while ( (bytesRead = readingStream.Read (byteBuffer, 0, byteBuffer.Length)) > 0 ) 
                {
                    string str2 = Encoding.ASCII.GetString(byteBuffer, 0, bytesRead);
                                          //or  .GetBytes()

                    Console.WriteLine(str2);
                }
            }
            */


            // REWRITE IN A BETTER WAY:
            // READING:
            
            using (Stream readingStream = new FileStream("testRead.txt", FileMode.Open, FileAccess.Read))
            {
                byte[] byteBuffer = new byte[readingStream.Length];

                // If int is short - switch to long
                int bytesToRead = (int)readingStream.Length;
                int bytesRead = 0;


                while (bytesToRead > 0)
                {
                    int n = readingStream.Read(byteBuffer, bytesRead, bytesToRead);

                    if (n == 0)
                    {
                        break;
                    }

                    bytesRead += n;
                    bytesToRead -= n;
                }
                    string str2 = Encoding.ASCII.GetString(byteBuffer, 0, byteBuffer.Length);
                    Console.WriteLine(str2);

                Console.ReadLine();
            }


            // --  --  --  --  --  --  --  --  --  --  --  --  --  --  --
            // Instead of using try / catch / finally:

            // FILE WRITING:


                // Array with a line separated by /n in each cell
                string[] allLines = File.ReadAllLines("test.txt"); //Reads whole dock


                // Text without division on separate lines:
                string allText = File.ReadAllText("text.txt");


            //Вычитывание строк по мере запроса клиентской стороной
            // used for foreach
            // Usefull for Huge Files. When there is no need to read it all
            IEnumerable<string> lines = File.ReadLines("text.txt");


            // If we have one string we want to add to a file
            File.WriteAllText("test_2.txt", "My name is John.");

            // No need to add /n in this command, every line in Array will have it
            File.WriteAllLines("test_3.txt", new string[] { "My hobbies are: ", " Hockey & Snowboarding." });


            File.WriteAllBytes("byteTest.txt", new byte[] { 72, 101, 108, 108, 111});




            // FILE READING:


            string allTest = File.ReadAllText("text_2.txt");
            Console.WriteLine(allTest);


            string[] allLines2 = File.ReadAllLines("test_3.txt");
            Console.WriteLine(allLines2[0]);
            Console.WriteLine(allLines2[1]);

            byte[] bytesArr = File.ReadAllBytes("text_4.txt");
            Console.WriteLine(Encoding.ASCII.GetString(bytesArr));

        }
    }
}
