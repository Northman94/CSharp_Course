using System;

namespace S9E107_Delegates
{
    public class Car
    {
        int speed = 0;

        public delegate void TooFast(); //Delegate

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
            }
        }

        public void Stop()
        {
            speed = 0;
        }


        public void RegisterOnTooFast(TooFast _tooFast)
        {
            this.tooFast = _tooFast;
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

            Console.ReadLine();
        }

        private static void HandleOnTooFast() //Event Handler
        {
            car.Stop();
        }
    }
}
