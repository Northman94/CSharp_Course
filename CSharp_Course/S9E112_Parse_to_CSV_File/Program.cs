using System;

namespace S9E112_Parse_CSV_File
{
    public class BaseballPlayers
    {
        public string Name { get; set;}
        public string Team { get; set;}
        public string Position { get; set;}

        public int Height_inches { get; set;}
        public int Weight_LBS { get; set;}
        public float Age { get; set;}
        public int ID { get; set;}


        public override string ToString()
        {
            return $@"Full Name: {Name}, Team: {Team}, Position: {Position}, Height(inches): {Height_inches},
                      Weight(LBS): {Weight_LBS}, Age: {Age} years old.";
        }

        // Parcing method here. Не логично создавать этот метод на уровне экземпляра.
        // Иначе придется созадавать экземпляр BaseballPlayers.
        // Логично вызывать этот метод как static.

        public static BaseballPlayers ParcseFideCSV (string line)
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
    }

    class MainClass
    {
        public static void Main(string[] args)
        {

        }
    }

    static void MinMaxSumAverage
}
