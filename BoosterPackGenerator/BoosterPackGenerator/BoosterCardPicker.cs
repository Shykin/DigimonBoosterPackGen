using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoosterPackGenerator
{
    public class BoosterCardPicker
    {
        private Random random = new Random();
        private List<CardFileRow> cardPickList = new List<CardFileRow>();
        private BoosterBoxDefinition BoxDef;
        public BoosterCardPicker(List<CardFileRow> cardFileRows, BoosterBoxDefinition _boxDef)
        {
            cardPickList = cardFileRows;
            BoxDef = _boxDef;
        }
        public CardFileRow GetCardByRarity(List<CardFileRow> cardDefs, string rarity)
        {
            var currentRarityCards = cardDefs.Where(c => c.Rarity == rarity).ToList();
            return currentRarityCards[random.Next(currentRarityCards.Count)];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rares">Total rares per box</param>
        /// <param name="superRares">Total Super Rares per box</param>
        /// <param name="secretRares">Total Secret Rares per box</param>
        /// <param name="allowAlternativeArts">If true include picking an alterntive art instead of a secret rare</param>
        public string GetRandomCardRarityByBoxDef(bool allowAlternativeArts)
        {
            //44
            int totalRandomCards = BoxDef.Rares + BoxDef.SuperRares + BoxDef.SecretRares;
            int ra = random.Next(1,totalRandomCards);
            if(ra < BoxDef.Rares)
            {
                return CardRarities.Rare;
            }
            else if(ra < BoxDef.Rares + BoxDef.SuperRares) //If it was within the rare range it would have been caught by the prior statement so it must be greater than rares but less than super rares
            {
                return CardRarities.SuperRare;
            }
            else if(ra < BoxDef.Rares + BoxDef.SuperRares + BoxDef.SecretRares)
            {
                return CardRarities.SecretRare;
            }

            return CardRarities.Common;
        }
    }
}
