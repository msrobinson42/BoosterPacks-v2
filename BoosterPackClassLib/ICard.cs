using System;

namespace BoosterPackClassLib
{
    public interface ICard
    {
        Guid CardId { get; }
        RarityEnum Rarity { get; }
        string Title { get; }
    }
}