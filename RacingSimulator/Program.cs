using System;
using System.Collections.Generic;
using RacingSimulator.RaceWithBuilder;
using RacingSimulator.RaceWithFactory;
using RacingSimulator.RaceWithFactory.Factories;
using RacingSimulator.Transport;
using static System.Console;

namespace RacingSimulator
{
    internal static class Program
    {
        static void Main()
        {
            try
            {

                var races = new ITransportRaceFactory[]
                {
                    new AirTransportRaceFactory(), new AllTransportRaceFactory(), new LandTransportRaceFactory(),
                };

                WriteLine("Please choose race type:\n1 - air\n2 - land\n3 - mixed\n");
                int raceType = int.Parse(Console.ReadLine());

                WriteLine("Please enter race distance\n");
                float dist = float.Parse(Console.ReadLine());

                if (raceType == 1) {
                    WriteLine("Please choose air transports");
                    var raceAirType = new AirTransportRaceBuilder();

                    WriteLine("1 - Magic Carpet\n2 - Stupa\n3 - Broom\n");
                    string racers = Console.ReadLine();
                    if (racers.Contains("1"))
                    {
                        raceAirType.AddCompetitor(new MagicCarpet());
                    }
                    if (racers.Contains("2"))
                    {
                        raceAirType.AddCompetitor(new Stupa());
                    }
                    if (racers.Contains("3"))
                    {
                        raceAirType.AddCompetitor(new Broom());
                    }

                    WriteLine(raceAirType.AddDistance(dist).Build().StartGame().ToString());
                }
                if (raceType == 2)
                {
                    WriteLine("Please choose land transports");
                    var raceLandType = new LandTransportRaceBuilder();

                    WriteLine("1 - Bactarian Camel\n2 - Speed Camel\n3 - Centaur\n4 - Izbushka");

                    string racers = Console.ReadLine();
                    if (racers.Contains("1"))
                    {
                        raceLandType.AddCompetitor(new BactrianCamel());
                    }
                    if (racers.Contains("2"))
                    {
                        raceLandType.AddCompetitor(new SpeedCamel());
                    }
                    if (racers.Contains("3"))
                    {
                        raceLandType.AddCompetitor(new Centaur());
                    }
                    if (racers.Contains("4"))
                    {
                        raceLandType.AddCompetitor(new MagicHouse());
                    }

                    WriteLine(raceLandType.AddDistance(dist).Build().StartGame().ToString());
                }
                if (raceType == 3)
                {
                    WriteLine("Please choose transports");
                    var raceMixType = new AllTransportRaceBuilder();

                    WriteLine("1 - Magic Carpet\n2 - Stupa\n3 - Broom\n");
                    WriteLine("4 - Bactarian Camel\n5 - Speed Camel\n6 - Centaur\n7 - Izbushka");

                    string racers = Console.ReadLine();
                    if (racers.Contains("1"))
                    {
                        raceMixType.AddCompetitor(new MagicCarpet());
                    }
                    if (racers.Contains("2"))
                    {
                        raceMixType.AddCompetitor(new Stupa());
                    }
                    if (racers.Contains("3"))
                    {
                        raceMixType.AddCompetitor(new Broom());
                    }
                    if (racers.Contains("4"))
                    {
                        raceMixType.AddCompetitor(new BactrianCamel());
                    }
                    if (racers.Contains("5"))
                    {
                        raceMixType.AddCompetitor(new SpeedCamel());
                    }
                    if (racers.Contains("6"))
                    {
                        raceMixType.AddCompetitor(new Centaur());
                    }
                    if (racers.Contains("7"))
                    {
                        raceMixType.AddCompetitor(new MagicHouse());
                    }

                    WriteLine(raceMixType.AddDistance(dist).Build().StartGame().ToString());
                }
            }
            catch (Exception e)
            {
                Error.WriteLine(e.Message);
            }
        }
    }
}