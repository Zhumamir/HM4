using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Train[] trains = new Train[5];
            trains[0] = new Train("123A", 8, 200.5, 120, true);
            trains[1] = new Train("456B", 10, 250.2, 150, true);
            trains[2] = new Train("789C", 6, 180.0, 100, false);
            trains[3] = new Train("101D", 12, 300.7);
            trains[4] = new Train();
            trains[0].StartJourney();

            foreach (var train in trains)
            {
                train.DisplayTrainInfo();
                Console.WriteLine();
            }
            Console.WriteLine($"Total Trains: {Train.TotalTrains}");
        }
    }
}
