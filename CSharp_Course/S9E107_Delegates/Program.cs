using System;

// All commented fields are one example of Delegate signature with int parameter in brackets

namespace S9E107_Delegates
{
    public class Car
    {
        int speed = 0;

        public delegate void TooFast(); //Delegate
        //public delegate void TooFast(int currentSpeed); 

        private TooFast tooFast; //Delegate instance



        public void Start()
        {
            speed = 10;
        }

        public void Accelerate()
        {
            speed += 10;

            if (speed > 80)
            {
                tooFast();
                //tooFast(speed);
            }
        }

        public void Stop()
        {
            speed = 0;
        }


        public void RegisterOnTooFast(TooFast _tooFast)
        {
            this.tooFast = _tooFast;
            // Это еще не совсем подписка на событие.
            // Cинтаксис "=" может перезатереть список методов
            // "+=" добавляет в очередь
            // "-=" отписывает от события
        }
    }


    class MainClass
    {
        static Car car;

        public static void Main(string[] args)
        {
            car = new Car();

            car.RegisterOnTooFast(HandleOnTooFast);
            // Method to trigger //Inner Method should correspond to Delegate signature
            // In this case inner Method should be void & have no parameters

            car.Start();

            for (int i = 0; i < 10; i++)
            {
                car.Accelerate();
            }

            Console.WriteLine("Tesla detected high speed. STOP!");
            Console.ReadLine();
        }

        private static void HandleOnTooFast() //Event Handler
        {
            car.Stop();
        }
        /*
        private static void HandleOnTooFast(int speed) //Event Handler
        {
            car.Stop();
        }
        */
    }
}
