using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace BoosterPackClassLib
{
    public class BoosterPackFactory : IBoosterPackFactory
    {
        private readonly ICardFactory cardFactory;

        public BoosterPackFactory(ICardFactory cardFactory)
        {
            this.cardFactory = cardFactory;
        }

        public IBoosterPack Create()
        {
            // booster pack has 6 common, 3 uncommon, 1 rare or legendary
            var counter = 1;

            var booster = Generate(RarityEnum.Common, 6)
                .Concat(Generate(RarityEnum.Uncommon, 3))
                .Concat(Generate(RarityEnum.Rare, 1))
                .ToList()
                .AsReadOnly();

            return new BoosterPack(booster);

            IEnumerable<ICard> Generate(RarityEnum rarity, int number)
            {
                for (int i = 0; i < number; i++)
                {
                    if(rarity == RarityEnum.Rare)
                    {
                        var rand = new Random();
                        rarity = rand.Next(0, 100) > 50 ? RarityEnum.Legendary : RarityEnum.Rare;
                    }

                    yield return cardFactory.Create($"{counter++}", rarity);

                }
            }
        }
    }
}
