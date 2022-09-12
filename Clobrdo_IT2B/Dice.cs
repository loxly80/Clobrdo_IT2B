using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clobrdo_IT2B
{
    public class Dice
    {
        private Random random;
        public int Value { get; internal set; }

        public Dice()
        {
            random = new Random();
            Throw();
        }

        public void Throw()
        {
            Value = random.Next(1, 7);
        }
    }
}
