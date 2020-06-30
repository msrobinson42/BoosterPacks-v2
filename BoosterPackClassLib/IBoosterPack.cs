using System.Collections.ObjectModel;

namespace BoosterPackClassLib
{
    public interface IBoosterPack
    {
        ReadOnlyCollection<ICard> Booster { get; }

        string ToString();
    }
}