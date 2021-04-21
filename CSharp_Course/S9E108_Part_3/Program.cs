using System;
using System.Timers;

//Will output in console a line every 3 seconds

namespace S9E108_Part_3
{
    public class CarArgs : EventArgs //Constructor
    {
        public CarArgs(int currentSpeed)
        {
            CurrentSpeed = currentSpeed;
        }
        public int CurrentSpeed { get;} //Property
    }


    public class Car
    {
        public event EventHandler<CarArgs> TooFastDrivingEvent; // Contains Obj & our int
      //public event Action<object, int> TooFastDrivingEvent;  //Event based on Action Delegate

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
                    TooFastDrivingEvent(this, new CarArgs(speed));
                    //Создание new экземпляра CarArgs + инкапсулировать в экземплар класса, который наследует EventArgs
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


            Car car = new Car();
            car.TooFastDrivingEvent += HandleOnTooFast;


            timer.Interval = 3000;
            timer.Start();

            Console.ReadLine();

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
            //var timer = (Timer)_sender;
            Console.WriteLine("Handling Timer elapsed Event");
        }

        private static void HandleOnTooFast(object _obj, CarArgs speed) //Event Handler //_obj = Car car
        {
            Console.WriteLine("Tesla detected high speed. STOP!");

            var car = (Car)_obj;
            car.Stop();
        }
    }
}
