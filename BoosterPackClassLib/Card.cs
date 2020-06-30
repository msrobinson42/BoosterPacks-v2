using System;

namespace BoosterPackClassLib
{
    public class Card : ICard
    {
        public string Title { get; }
        public Guid CardId { get; }
        public RarityEnum Rarity { get; }

        public Card(string title, Guid cardId, RarityEnum rarity)
        {
            Title = title;
            CardId = cardId;
            Rarity = rarity;
        }

        public Card(string title, RarityEnum rarity)
            : this(title, Guid.NewGuid(), rarity)
        { 

        }

        public override string ToString()
        {
            return $"Title: {Title}. CardId: {CardId.ToString().Substring(0, 6)}. Rarity: {Rarity}.";
        }
    }
}
