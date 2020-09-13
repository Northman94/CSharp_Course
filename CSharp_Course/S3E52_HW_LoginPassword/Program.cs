using System;

namespace S3E52_HW_LoginPassword
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string login;
            string password;


            for (int i = 0; i < 3; i++)
            {
                login = LoginToGet();
                password = PasswordToGet();

                if (login == "Zh" && password == "1R2")
                {
                    Console.WriteLine("Great!");
                    break;
                }

                if (i == 2)
                {
                    Console.WriteLine("The number of available tries has been exceeded");
                }
            }
        }

        private static string LoginToGet()
        {
            Console.WriteLine("Please enter Login");
            return Console.ReadLine();
        }

        private static string PasswordToGet()
        {
            Console.WriteLine("Please enter Password");
            return Console.ReadLine();
        }
    }
}
