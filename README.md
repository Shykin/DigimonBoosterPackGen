# DigimonBoosterPackGen

This simulates opening x number of booster packs for the Digimon2020 TCG. I created it to have a way to create a deck for Booster pack tournaments. 
The output is built to be imported into Digimoncard.dev and then you can cut the deck down to a proper 50 cards.
It uses the number of guarenteed cards in a booster pack to pick most cards and then it uses the total number of each rarity in a box set to calculate the
percentage chance of the final random card to be which rarity. Then pulls it by randomly picking a card amongst that rarity from the list.

At the end it will group it together by name and how many to output for importing.

Right now its a console app but the classes and program.cs can really be refactored or moves pretty easily and I could host it here as a tiny web app. For future 
releases I'd just need the list of cards and their rarities again.
