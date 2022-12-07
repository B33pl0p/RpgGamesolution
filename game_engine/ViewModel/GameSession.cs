using game_engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace game_engine.ViewModel
{
    internal class GameSession
    {
        Player? CurrentPlayer { get; set; }
        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Biplop";
            CurrentPlayer.Gold = 10000;
        }
    }
}
