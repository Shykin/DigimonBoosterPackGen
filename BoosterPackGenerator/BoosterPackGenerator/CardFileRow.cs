using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoosterPackGenerator
{
    public class CardFileRow
    {
        public string? CardCode { get; set; }
        public string? Rarity { get; set; }

        public CardFileRow(string? cardCode, string? rarity)
        {
            CardCode = cardCode;
            Rarity = rarity;
        }
    }
}
