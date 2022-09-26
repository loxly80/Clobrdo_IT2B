using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clobrdo_IT2B
{
    public class Board
    {
        public Figure[] Path { get; set; }
        public Dictionary<FigureColor, Figure[]> Homes { get; set; }
        public Dictionary<FigureColor, int> Starts { get; set; }

        public Board(int playersCount)
        {
            Path = new Figure[40];
            Homes = new Dictionary<FigureColor, Figure[]>();
            Starts = new Dictionary<FigureColor, int>();
            for (int i = 0; i < playersCount; i++)
            {
                Homes.Add((FigureColor)i, new Figure[4]);
                Starts.Add((FigureColor)i, i * 10);
            }
        }
    }
}
