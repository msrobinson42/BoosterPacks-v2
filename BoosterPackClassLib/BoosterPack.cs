using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace BoosterPackClassLib
{
    public class BoosterPack : IBoosterPack
    {
        public ReadOnlyCollection<ICard> Booster { get; }

        public BoosterPack(ReadOnlyCollection<ICard> booster)
        {
            Booster = booster;
        }

        public override string ToString()
        {
            var output = "";

            foreach (var card in Booster)
            {
                output += $"{card}\n";
            }

            return output;
        }
    }
}
