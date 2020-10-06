using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Data.SqlTypes;
using System.Runtime.InteropServices.ComTypes;
using System.Globalization;
using System.Threading;
using System.Security.Policy;
using System.Collections;

namespace Student_projects
{
    abstract class Auto
    {
        protected Marka marka { get; private set; }
        public int Speed { get; private set; }
        public double GasMileage { get; private set; }
        public double Cost { get; private set; }
        public enum Marka
        {
            Bugatti,
            Tesla,
            Rolls_Royce,
            Lamborghini,
            BMW
        }
        public Auto(int Speed, double GasMileage, double Cost, Marka marka)
        {
            this.Speed = Speed;
            this.GasMileage = GasMileage;
            this.Cost = Cost;
            this.marka = marka;
        }
        public abstract void Print();
    }
    class Bugatti : Auto
    {
        public enum Model
        {
            Chiron,
            Veyron
        }
        protected Model model { get; private set; }
        public Bugatti(int Speed, double GasMileage, double Cost, Model model) : base(Speed, GasMileage, Cost, Marka.Bugatti)
        {
            this.model = model;
        }
        public override void Print()
        {
            Console.WriteLine("{0} {1};\nMax Speed: {2} km/h;\nGas Mileage: {3} l/100 km;\nCost: {4}$;\n", marka, model, Speed, GasMileage, Cost);
        }
        public static void AddAuto(List<Auto> auto)
        {
            ConsoleKey consoleKey;
            do
            {
                Console.Clear();
                Console.WriteLine("0. Exit;\n1. {0} {1};\n2. {0} {2};\n", Marka.Bugatti, Model.Chiron, Model.Veyron);
                consoleKey = Console.ReadKey(true).Key;
                switch (consoleKey)
                {
                    case ConsoleKey.D0:
                        break;
                    case ConsoleKey.D1:
                        auto.Add(new Bugatti(420, 16.8, 2710118.4, Bugatti.Model.Chiron));
                        break;
                    case ConsoleKey.D2:
                        auto.Add(new Bugatti(415, 24.9, 1439750.4, Bugatti.Model.Veyron));
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            } while (consoleKey != ConsoleKey.D0);
        }
    }
    class Tesla : Auto
    {
        public enum Model
        {
            Model_3,
            Model_S,
            Model_X
        }
        protected Model model { get; private set; }
        public Tesla(int Speed, double GasMileage, double Cost, Model model) : base(Speed, GasMileage, Cost, Marka.Tesla)
        {
            this.model = model;
        }
        public override void Print()
        {
            Console.WriteLine("{0} {1};\nMax Speed: {2} km/h;\nGas Mileage: {3} kWt/100 km;\nCost: {4}$;\n", marka, model, Speed, GasMileage, Cost);
        }
        public static void AddAuto(List<Auto> auto)
        {
            ConsoleKey consoleKey;
            do
            {
                Console.Clear();
                Console.WriteLine("0. Exit;\n1. {0} {1};\n2. {0} {2};\n3. {0} {3};\n", Marka.Tesla, Model.Model_3, Model.Model_S, Model.Model_X);
                consoleKey = Console.ReadKey(true).Key;
                switch (consoleKey)
                {
                    case ConsoleKey.D0:
                        break;
                    case ConsoleKey.D1:
                        auto.Add(new Tesla(250, 16.4, 35000, Tesla.Model.Model_3));
                        break;
                    case ConsoleKey.D2:
                        auto.Add(new Tesla(261, 16.5, 79983.14, Tesla.Model.Model_S));
                        break;
                    case ConsoleKey.D3:
                        auto.Add(new Tesla(250, 22.2, 100351.23, Tesla.Model.Model_X));
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            } while (consoleKey != ConsoleKey.D0);
        }
    }
    class Rolls_Royce : Auto
    {
        public enum Model
        {
            Cullinan,
            Dawn,
            Ghost,
            Phantom,
            Wraith
        }
        protected Model model { get; private set; }
        public Rolls_Royce(int Speed, double GasMileage, double Cost, Model model) : base(Speed, GasMileage, Cost, Marka.Rolls_Royce)
        {
            this.model = model;
        }
        public override void Print()
        {
            Console.WriteLine("{0} {1};\nMax Speed: {2} km/h;\nGas Mileage: {3} l/100 km;\nCost: {4}$;\n", marka, model, Speed, GasMileage, Cost);
        }
        public static void AddAuto(List<Auto> auto)
        {
            ConsoleKey consoleKey;
            do
            {
                Console.Clear();
                Console.WriteLine("0. Exit;\n1. {0} {1};\n2. {0} {2};\n3. {0} {3};\n4. {0} {4};\n5. {0} {5};\n", Marka.Rolls_Royce, Model.Cullinan, Model.Dawn, Model.Ghost, Model.Phantom, Model.Wraith);
                consoleKey = Console.ReadKey(true).Key;
                switch (consoleKey)
                {
                    case ConsoleKey.D0:
                        break;
                    case ConsoleKey.D1:
                        auto.Add(new Rolls_Royce(260, 15, 338764.8, Rolls_Royce.Model.Cullinan));
                        break;
                    case ConsoleKey.D2:
                        auto.Add(new Rolls_Royce(250, 14.2, 449120, Rolls_Royce.Model.Dawn));
                        break;
                    case ConsoleKey.D3:
                        auto.Add(new Rolls_Royce(240, 13.7, 61391.22, Rolls_Royce.Model.Ghost));
                        break;
                    case ConsoleKey.D4:
                        auto.Add(new Rolls_Royce(250, 15.7, 460000, Rolls_Royce.Model.Phantom));
                        break;
                    case ConsoleKey.D5:
                        auto.Add(new Rolls_Royce(250, 14, 314384, Rolls_Royce.Model.Wraith));
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            } while (consoleKey != ConsoleKey.D0);
        }
    }
    class Lamborghini : Auto
    {
        public enum Model
        {
            Aventador,
            Diablo,
            Gallardo,
            Huracan,
            Murcielago,
            Urus
        }
        protected Model model { get; private set; }
        public Lamborghini(int Speed, double GasMileage, double Cost, Model model) : base(Speed, GasMileage, Cost, Marka.Lamborghini)
        {
            this.model = model;
        }
        public override void Print()
        {
            Console.WriteLine("{0} {1};\nMax Speed: {2} km/h;\nGas Mileage: {3} l/100 km;\nCost: {4}$;\n", marka, model, Speed, GasMileage, Cost);
        }
        public static void AddAuto(List<Auto> auto)
        {
            ConsoleKey consoleKey;
            do
            {
                Console.Clear();
                Console.WriteLine("0. Exit;\n1. {0} {1};\n2. {0} {2};\n3. {0} {3};\n4. {0} {4};\n5. {0} {5};\n6. {0} {6};\n", Marka.Lamborghini, Model.Aventador, Model.Diablo, Model.Gallardo, Model.Huracan, Model.Murcielago, Model.Urus);
                consoleKey = Console.ReadKey(true).Key;
                switch (consoleKey)
                {
                    case ConsoleKey.D0:
                        break;
                    case ConsoleKey.D1:
                        auto.Add(new Lamborghini(350, 16, 265110.72, Lamborghini.Model.Aventador));
                        break;
                    case ConsoleKey.D2:
                        auto.Add(new Lamborghini(340, 20, 186320.64, Lamborghini.Model.Diablo));
                        break;
                    case ConsoleKey.D3:
                        auto.Add(new Lamborghini(320, 13.3, 143975.04, Lamborghini.Model.Gallardo));
                        break;
                    case ConsoleKey.D4:
                        auto.Add(new Lamborghini(325, 14.1, 228666.24, Lamborghini.Model.Huracan));
                        break;
                    case ConsoleKey.D5:
                        auto.Add(new Lamborghini(331, 32, 270000.43, Lamborghini.Model.Murcielago));
                        break;
                    case ConsoleKey.D6:
                        auto.Add(new Lamborghini(305, 12.6, 195046.4, Lamborghini.Model.Urus));
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            } while (consoleKey != ConsoleKey.D0);
        }
    }
    class BMW : Auto
    {
        public enum Model
        {
            X7,
            M4,
            I8
        }
        protected Model model { get; private set; }
        public BMW(int Speed, double GasMileage, double Cost, Model model) : base(Speed, GasMileage, Cost, Marka.BMW)
        {
            this.model = model;
        }
        public override void Print()
        {
            Console.WriteLine("{0} {1};\nMax Speed: {2} km/h;\nGas Mileage: {3} l/100 km;\nCost: {4}$;\n", marka, model, Speed, GasMileage, Cost);
        }
        public static void AddAuto(List<Auto> auto)
        {
            ConsoleKey consoleKey;
            do
            {
                Console.Clear();
                Console.WriteLine("0. Exit;\n1. {3} {0};\n2. {3} {1};\n3. {3} {2};\n", Model.X7, Model.M4, Model.I8, Marka.BMW);
                consoleKey = Console.ReadKey(true).Key;
                switch (consoleKey)
                {
                    case ConsoleKey.D0:
                        break;
                    case ConsoleKey.D1:
                        auto.Add(new BMW(245, 9.5, 78275.2, BMW.Model.X7));
                        break;
                    case ConsoleKey.D2:
                        auto.Add(new BMW(250, 9.1, 87899.2, BMW.Model.M4));
                        break;
                    case ConsoleKey.D3:
                        auto.Add(new BMW(250, 2.5, 121775.68, BMW.Model.I8));
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            } while (consoleKey != ConsoleKey.D0);
        }
    }
    interface ITaxi
    {
        void CreationTaxi(List<Auto> auto);
        void OutputDataTaxi(List<Auto> auto);
        void SortingByGasMileageTaxi(ref List<Auto> auto);
        void SelectSpeedTaxi(List<Auto> auto);
        void CostTaxi(List<Auto> auto);
    }
    class Taxi : ITaxi
    {
        public void CreationTaxi(List<Auto> auto)
        {
            ConsoleKey consoleKey;
            do
            {
                Console.WriteLine("0. Exit;\n1. BMW;\n2. Lamborghini;\n3. Rolls Royce;\n4. Tesla;\n5. Bugatti;\n");
                consoleKey = Console.ReadKey(true).Key;

                switch (consoleKey)
                {
                    case ConsoleKey.D0:
                        break;
                    case ConsoleKey.D1:
                        BMW.AddAuto(auto);
                        break;
                    case ConsoleKey.D2:
                        Lamborghini.AddAuto(auto);
                        break;
                    case ConsoleKey.D3:
                        Rolls_Royce.AddAuto(auto);
                        break;
                    case ConsoleKey.D4:
                        Tesla.AddAuto(auto);
                        break;
                    case ConsoleKey.D5:
                        Bugatti.AddAuto(auto);
                        break;
                    default:
                        break;
                }
                Console.Clear();
            } while (consoleKey != ConsoleKey.D0);
        }
        public void OutputDataTaxi(List<Auto> auto)
        {
            foreach (var item in auto)
            {
                item.Print();
            }
        }
        public void SortingByGasMileageTaxi(ref List<Auto> auto)
        {
            var SortingByGasMileageAuto = from item in auto
                                          orderby item.GasMileage
                                          select item;
            auto = SortingByGasMileageAuto.ToList<Auto>();
        }
        public void SelectSpeedTaxi(List<Auto> auto)
        {
            Console.Write("Min Speed = ");
            int.TryParse(Console.ReadLine(), out int speedMin);
            Console.Write("Max Speed = ");
            int.TryParse(Console.ReadLine(), out int speedMax);
            var SelectSpeedAuto = from item in auto
                                  where item.Speed >= speedMin && item.Speed <= speedMax
                                  select item;
            foreach (var item in SelectSpeedAuto)
            {
                item.Print();
            }
        }
        public void CostTaxi(List<Auto> auto)
        {
            var sumCost = auto.Sum(item => item.Cost);
            Console.WriteLine("Cost taxi = {0}", sumCost);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-us");
            List<Auto> auto = new List<Auto>();
            Taxi taxi = new Taxi();
            ConsoleKey consoleKey;
            do
            {
                Console.WriteLine("0. Exit;\n1. Creation Taxi;\n2. Output Data Taxi;\n3. Sorting by Gas Mileage;\n4. Select Speed;\n5. Cost Taxi;\n");
                consoleKey = Console.ReadKey().Key;
                switch (consoleKey)
                {
                    case ConsoleKey.D0:
                        break;
                    case ConsoleKey.D1:
                        taxi.CreationTaxi(auto);
                        break;
                    case ConsoleKey.D2:
                        taxi.OutputDataTaxi(auto);
                        break;
                    case ConsoleKey.D3:
                        taxi.SortingByGasMileageTaxi(ref auto);
                        break;
                    case ConsoleKey.D4:
                        taxi.SelectSpeedTaxi(auto);
                        break;
                    case ConsoleKey.D5:
                        taxi.CostTaxi(auto);
                        break;
                    default:
                        break;
                }
            } while (consoleKey != ConsoleKey.D0);
        }
    }
}