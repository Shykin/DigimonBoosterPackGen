using System;

namespace BoosterPackGenerator // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fileLines = System.IO.File.ReadAllLines("BT09-ParseList.csv");
            List<CardFileRow> cardDefs = fileLines.Select(s => new CardFileRow(s.Split(',')[0].Trim(), s.Split(',')[1].Trim())).ToList();

            BoosterPackDefinition packDef = new BoosterPackDefinition(7, 3, 1, 1);
            int packCount = 6;
            List<string> cards = new List<string>();

            for(int i = 0; i < packCount; i++)
            {
                for(int c = 0; c < packDef.Commons; c++)
                {

                }
            }

            //First loop the number of packs
            //Then in each pack you need to pick from the pool of Commons, Uncommons, and Rares based on the definition
            //The pick card should be "PickByRarity" you pick a rarity and it grabs a random card from the list loaded by the CSV
            //On the random card you need to pick from the pool of Rare, Super Rare, Secret Rare or Alternative Art
            //Once you have the rarity, pick the card from the list
            // You can do a linq query to make the list by rarity, than a rand on the length to pick a random one from the list
            //Once you have picked the card, add it to the list
            //Then loop to the next pack
            //Once you have the full list, group by the list to format it as a CardCode, Count
            //Then output as a file or text
            


        }

        public static CardFileRow GetCardByRarity(List<CardFileRow> cardDefs, string rarity)
        {
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rares">Total rares per box</param>
        /// <param name="superRares">Total Super Rares per box</param>
        /// <param name="secretRares">Total Secret Rares per box</param>
        /// <param name="allowAlternativeArts">If true include picking an alterntive art instead of a secret rare</param>
        public static string GetRandomCardRarityByBoxDef(int rares, int superRares, int secretRares, bool allowAlternativeArts)
        {
            return CardRarities.Common;
        }
    }
}