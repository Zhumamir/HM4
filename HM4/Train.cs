using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM4
{
    public partial class Train
    {
        private string trainNumber;
        private int numberOfCars;
        private double lengthInMeters;
        private int maximumSpeed;
        private bool isOperational;

        private static int totalTrains = 0;
        private static string trainCompany = "Example Railways";

        public static int TotalTrains
        {
            get { return totalTrains; }
        }

        public Train()
        {
            trainNumber = "Unknown";
            numberOfCars = 0;
            lengthInMeters = 0;
            maximumSpeed = 0;
            isOperational = false;
            totalTrains++;
        }

        public Train(string number, int cars, double length, int speed, bool operational)
        {
            trainNumber = number;
            numberOfCars = cars;
            lengthInMeters = length;
            maximumSpeed = speed;
            isOperational = operational;
            totalTrains++;
        }

        public Train(string number, int cars, double length)
            : this(number, cars, length, 0, false)
        {
        }

        public string GetTrainNumber()
        {
            return trainNumber;
        }

        public void SetOperationalStatus(bool operational)
        {
            isOperational = operational;
        }

        public void DisplayTrainInfo()
        {
            Console.WriteLine($"Train Number: {trainNumber}");
            Console.WriteLine($"Number of Cars: {numberOfCars}");
            Console.WriteLine($"Length: {lengthInMeters} meters");
            Console.WriteLine($"Maximum Speed: {maximumSpeed} km/h");
            Console.WriteLine($"Operational: {(isOperational ? "Yes" : "No")}");
        }

        static Train()
        {
            Console.WriteLine("Initializing the Train class.");
        }
    }
}
