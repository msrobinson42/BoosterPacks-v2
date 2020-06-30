namespace BoosterPackClassLib
{
    public class CardFactory : ICardFactory
    {
        public ICard Create(string title, RarityEnum rarity)
        {
            return new Card(title, rarity);
        }
    }
}
