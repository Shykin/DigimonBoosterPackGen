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
            BoosterBoxDefinition boxDef = new BoosterBoxDefinition(168, 72, 35, 7, 2);
            BoosterCardPicker cardPicker = new BoosterCardPicker(cardDefs, boxDef);

            int packCount = 6;
            List<CardFileRow> cards = new List<CardFileRow>();

            for(int i = 0; i < packCount; i++)
            {
                //First get the guarrenteed cards for each pack
                for(int c = 0; c < packDef.Commons; c++)
                {
                    cards.Add(cardPicker.GetCardByRarity(cardDefs, CardRarities.Common));
                }
                for(int u = 0; u < packDef.Uncommons; u++)
                {
                    cards.Add(cardPicker.GetCardByRarity(cardDefs, CardRarities.Uncommon));
                }
                for(int r = 0; r < packDef.Rares; r++)
                {
                    cards.Add(cardPicker.GetCardByRarity(cardDefs, CardRarities.Rare));
                }
                cards.Add(cardPicker.GetCardByRarity(cardDefs, cardPicker.GetRandomCardRarityByBoxDef(false)));
            }

            var groupedCards = cards.GroupBy(c => c.CardCode);
            foreach(var group in groupedCards)
            {
                string outputGroup = group.Count() + " " + group.Key;
                Console.WriteLine(outputGroup);
            }
            Console.ReadKey();
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
    }
}