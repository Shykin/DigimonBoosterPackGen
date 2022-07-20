using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoosterPackGenerator
{
    public class BoosterPackDefinition
    {
        public int Commons;
        public int Uncommons;
        public int Rares;
        public int RandomCard;

        public BoosterPackDefinition(int commons, int uncommons, int rares, int randomCard)
        {
            Commons = commons;
            Uncommons = uncommons;
            Rares = rares;
            RandomCard = randomCard;
        }

        public int TotalCards
        {
            get
            {
                return Commons + Uncommons + Rares + RandomCard;
            }
        }
    }
}