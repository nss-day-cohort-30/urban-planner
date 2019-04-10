using System;
using System.Collections.Generic;
using System.Text;

namespace Planner {
    public class City {
        private string _name;
        private int _maximumCapacity;
        private int _yearEstablished;

        public List<Building> Buildings { get; private set; } = new List<Building>();
        public string Mayor { get; set; }


        public City (string name, int year, int capacity) {
            _name = name;
            _maximumCapacity = capacity;
            _yearEstablished = year;
        }

        public void RegisterBuildings (List<Building> buildings) {
            if (Buildings.Count >= _maximumCapacity) {
                System.Console.WriteLine("This city is at maximum capacity!");
            } else {
                Buildings.AddRange(buildings);
            }
        }

        public void RegisterBuildings (Building building) {
            if (Buildings.Count >= _maximumCapacity) {
                System.Console.WriteLine("This city is at maximum capacity!");
            } else {
                Buildings.Add(building);
            }
        }

        public override string ToString() {
            StringBuilder output = new StringBuilder($@"
****************************************************
*******  {_name.ToUpper()}
****************************************************
Mayor: {Mayor}
Year founded: {_yearEstablished}


Buildings:
");
            Buildings.ForEach(b => output.Append($"{b}\n"));
            return output.ToString();
        }
    }
}