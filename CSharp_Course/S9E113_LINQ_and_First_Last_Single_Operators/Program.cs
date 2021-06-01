using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace S9E113_LINQ_and_First_Last_Single_Operators
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            MinMaxSumAverage("LINQ_DB.csv");
        }

        private static void MinMaxSumAverage(string v)
        {
            throw new NotImplementedException();
        }
    }

    public class BaseballPlayers
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public string Position { get; set; }

        public int Height_inches { get; set; }
        public int Weight_LBS { get; set; }
        public float Age { get; set; }
        public int ID { get; set; }


        public override string ToString()
        {
            return $@"Full Name: {Name}, Team: {Team}, Position: {Position}, Height(inches): {Height_inches},
                      Weight(LBS): {Weight_LBS}, Age: {Age} years old.";
        }

        // Parcing method here. Не логично создавать этот метод на уровне экземпляра.
        // Иначе придется созадавать экземпляр BaseballPlayers.
        // Логично вызывать этот метод как static.

        public static BaseballPlayers ParcseFideCSV(string line)
        {
            string[] parts = line.Split(';'); //Can be

            return new BaseballPlayers()
            {
                //"ID"; Name"; "Team"; "Position"; "Height(inches)"; "Weight(lbs)"; "Age"

                // разбор через инициализацию свойства
                // using: Obj initialize syntax

                ID = int.Parse(parts[0]),
                Name = parts[1],
                // If in .CSV Name & Surname are devided by ',' :
                // FirstName = parts[1].Split(',')[0].Trim(),
                // LastName = parts[1].Split(',')[1].Trim(),
                Team = parts[2],
                Position = parts[3],

                Height_inches = int.Parse(parts[4]),
                Weight_LBS = int.Parse(parts[5]),
                Age = int.Parse(parts[6])
            };
        }


        static void MinMaxSumAverage(string file)
        {
            List<BaseballPlayers> list = File.ReadAllLines(file)
                //ReadAllLines возвращает массив, который реализует: IEnumerable<T>

                .Skip(1)
                //Will skip line with column headers (Name, Age, etc.)
                .Select(x => BaseballPlayers.ParcseFideCSV(x))
                // Метод проекции - трансформирует каждый элемент в другой тип <T>
                // Еквивалентно методу, который принимает экземпляр BaseballPlayers
                // Select returns IEnumerable<BaseballPlayers>

                // Lambda can be simplified:
                //.Select(BaseballPlayers.ParcseFideCSV)

                //Filtering:
                .Where(player => player.Age > 25)
                //Sorting
                .OrderByDescending(player => player.Age)
                .ThenBy(player => player.Height_inches)
                .Take(10)  // Returns INumerable, but it's more convenient to work with List
                .ToList(); // Extension method on INumerable
                           // Without .ToList List<BaseballPlayers> will be replaced with
                           // IEnumerable<BaseballPlayers

            Console.WriteLine($"The lowest Age in TOP10: {list.Min(x => x.Age)}");
            Console.WriteLine($"The highest Age in TOP10: {list.Max(x => x.Age)}");
            Console.WriteLine($"The average Age in TOP10: {list.Average(x => x.Age)}");
        }
    }
}
