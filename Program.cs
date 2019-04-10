using System;
using System.Collections.Generic;

namespace Planner {
    class Program {
        static void Main (string[] args) {

            // Create three buildings
            Building OneHundredMain = new Building ("100 Main Street") {
                Width = 32,
                Depth = 28,
                Stories = 6
            };
            OneHundredMain.Construct ();
            OneHundredMain.Purchase ("Bob Ross");
            Console.WriteLine(OneHundredMain.Width);

            Building TwoOneTwoCaldwell = new Building ("212 Caldwell Avenue") {
                Width = 5,
                Depth = 22,
                Stories = 4
            };
            TwoOneTwoCaldwell.Construct ().Purchase ("Martin Shkreli");

            Building ThreeFiveThreeBroadway = new Building ("353 Broadway Avenue") {
                Width = 26,
                Depth = 18,
                Stories = 2
            };
            ThreeFiveThreeBroadway.Construct ().Purchase ("Donnie Drumpf");

            // Create the city
            City megalopolis = new City ("Megalopolis", 1884, 2) {
                Mayor = "Anna Kersofolis"
            };

            // Use the overloaded RegisterBuildings that accepts a list
            megalopolis.RegisterBuildings (new List<Building> {
                OneHundredMain,
                TwoOneTwoCaldwell,
            });

            // Use the overloaded RegisterBuildings that accepts a single Building
            megalopolis.RegisterBuildings (ThreeFiveThreeBroadway);

            // megalopolis.Buildings.ForEach (Console.WriteLine);
            Console.WriteLine(megalopolis);

        }
    }
}