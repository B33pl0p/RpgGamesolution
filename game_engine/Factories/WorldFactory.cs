using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using game_engine.Models;
namespace game_engine.Factories
{
    internal static class WorldFactory
    {
        public static World CreateWorld()
        {
            World newWorld = new World();
            newWorld.AddLocation(-2, -1, "Farmer's Field",
                "There are rows of corn growing here, with giant rats hiding between them.",
                "/game_engine;component/Images/Locations/FarmFields.png");
            newWorld.AddLocation(-1, -1, "Farmer's House",
                "This is the house of your neighbor, Farmer Ted.",
                "/game_engine;component/Images/Locations/Farmhouse.png");
            newWorld.AddLocation(0, -1, "Home",
                "This is your home",
                "/game_engine;component/Images/Locations/Home.png");
            newWorld.AddLocation(-1, 0, "Trading Shop",
                "The shop of Susan, the trader.",
                "/game_engine;component/Images/Locations/Trader.png");
            newWorld.AddLocation(0, 0, "Town square",
                "You see a fountain here.",
                "/game_engine;component/Images/Locations/TownSquare.png");
            newWorld.AddLocation(1, 0, "Town Gate",
                "There is a gate here, protecting the town from giant spiders.",
                "/game_engine;component/Images/Locations/TownGate.png");
            newWorld.AddLocation(2, 0, "Spider Forest",
                "The trees in this forest are covered with spider webs.",
                "/game_engine;component/Images/Locations/SpiderForest.png");
            newWorld.AddLocation(0, 1, "Herbalist's hut",
                "You see a small hut, with plants drying from the roof.",
                "/game_engine;component/Images/Locations/HerbalistsHut.png");
            newWorld.AddLocation(0, 2, "Herbalist's garden",
                "There are many plants here, with snakes hiding behind them.",
                "/game_engine;component/Images/Locations/HerbalistsGarden.png");
            return newWorld;

        }
        
    }
}
