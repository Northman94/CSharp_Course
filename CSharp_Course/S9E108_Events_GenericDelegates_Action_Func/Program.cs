using System;


// Example of Delegate based Events

namespace S9E108_Events_GenericDelegates_Action_Func
{
    public class Car
    {
        public delegate void TooFast(int currentSpeed); //Delegate

        public event TooFast TooFastDrivingEvent; //Delegate based Event - now we dont need Delegate instance

        int speed = 0;



        public void Start()
        {
            speed = 10;
        }

        public void Accelerate()
        {
            speed += 10;

            if (speed > 80)
            {
                if (TooFastDrivingEvent != null)
                {
                    TooFastDrivingEvent(speed); //Вызов События как метода
                }
            }
        }

        public void Stop()
        {
            speed = 0;
        }
    }


    class MainClass
    {
        static Car car; //static because should be available in Main & HandleOnTooFast

        public static void Main(string[] args)
        {
            car = new Car();

        
            car.TooFastDrivingEvent += HandleOnTooFast;
          //car.TooFastDrivingEvent -= HandleOnTooFast;


            car.Start();

            for (int i = 0; i < 10; i++)
            {
                car.Accelerate();
            }

            Console.WriteLine("Tesla detected high speed. STOP!");
            Console.ReadLine();
        }

        
        private static void HandleOnTooFast(int speed) //Event Handler
        {
            car.Stop();
        }
    }
}

