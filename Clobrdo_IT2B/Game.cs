using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;

namespace Clobrdo_IT2B
{
    public class Game
    {
        public Player[] Players { get; }
        public Board Board { get; }
        public Dice Dice { get; }

        public Game(int playersCount)
        {
            Dice = new Dice();
            Board = new Board(playersCount);
            Players = new Player[playersCount];
            for(int i = 0; i < playersCount; i++)
            {
                Players[i] = new Player((FigureColor)i);
            }
        }
    }
}
