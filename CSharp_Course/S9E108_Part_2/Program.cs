using System;
using System.Timers;

namespace S9E108_Part_2
{
    public class Car
    {
        public event EventHandler<int> TooFastDrivingEvent; // Contains Obj & our int

        //public event Action<object, int> TooFastDrivingEvent; //Event based on Action Delegate

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
                    TooFastDrivingEvent(this, speed); //Вызов События как метода
                    //this = ссылка на текущий экземпляр Car car
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
        public static void Main(string[] args)
        {
            Timer timer = new Timer(); // using System.Timers;

            timer.Elapsed += Timer_Elapsed;


            Car car = new Car(); //No need to be static anymore


            car.TooFastDrivingEvent += HandleOnTooFast;


            car.Start();

            for (int i = 0; i < 10; i++)
            {
                car.Accelerate();
            }

            Console.ReadLine();
        }


        // Method Handler / Метод оборатотчик 
        private static void Timer_Elapsed(object _sender, ElapsedEventArgs e) 
        {
            var timer = (Timer)_sender;
        }

        private static void HandleOnTooFast(object _obj, int speed) //Event Handler //_obj = Car car
        {
            Console.WriteLine("Tesla detected high speed. STOP!");

            var car = (Car)_obj;
            car.Stop();
        }
    }
}
