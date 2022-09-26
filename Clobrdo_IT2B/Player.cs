using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clobrdo_IT2B
{
    public class Player
    {
        public Figure[] Figures { get; }

        public Player(FigureColor figureColor)
        {
            Figures = new Figure[4];
            for (int i = 0; i < Figures.Length; i++)
            {
                Figures[i] = new Figure(figureColor);
            }
        }
    }
}
