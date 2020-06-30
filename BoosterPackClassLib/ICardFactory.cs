namespace BoosterPackClassLib
{
    public interface ICardFactory
    {
        ICard Create(string title, RarityEnum rarity);
    }
}