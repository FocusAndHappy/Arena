using System;

namespace FAH.Arena.Domain.Foundation.MoveCategories
{
    public struct SpecialMove : IMoveCategory
    {
        public readonly Category Name => Category.Special;

        public readonly string Description => "Special moves deal damage depending on both the Special Attack stat of the attacking Pokémon " +
            "and the Special Defense stat of the defending Pokémon.";

        public int GetOffensiveStatValue()
        {
            throw new NotImplementedException();
        }
    }
}
