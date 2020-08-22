using System;

namespace S3E36_Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your weight (Kg)");
            float weight = float.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter your height (Meters)");
            float height = float.Parse(Console.ReadLine());

            float BMI = weight / (height * height);


            bool isTooLow = BMI <= 18.5;
            bool isNormal = BMI > 18.5 && BMI < 25;
            bool isAboveNormal = BMI >= 25 && BMI <= 30;
            bool isTooFat = BMI > 30;


            bool isFat = isAboveNormal || isTooFat;

            if (isFat)
            {
                Console.WriteLine("You;d better loose some weight.");
            }
            else 
            {
                Console.WriteLine("Oh, you;re in a good shape.");
            }

            //if (isFat ==False) // Possible without {}
            if (!isFat) 
                Console.WriteLine("You're too skinny.");

            // -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
            if (isTooLow) 
            {
                Console.WriteLine("not enough weight.");
            }
            else if (isNormal)
            {
                Console.WriteLine("You're OK.");
            }
            else if (isAboveNormal) 
            {
                Console.WriteLine("Be carefull.");
            }
            else
            {
                Console.WriteLine("You need to loose some weight.");
            }

            // -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
            if (isFat || isTooFat) 
            {
                Console.WriteLine("It's diet time.");
            }

            // -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
            Console.WriteLine("Please Enter your age");
            int age = int.Parse(Console.ReadLine());

            //Тернарный оператор "?" // True/False
            string description = age > 18 ? "Get a drink!" : "No alcohol for you.";

            Console.WriteLine(description);
        }
    }
}
