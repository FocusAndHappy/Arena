using System;

namespace FAH.Arena.Domain.Foundation.MoveCategories
{
    public struct PhysicalMove : IMoveCategory
    {
        public readonly Category Name => Category.Physical;

        public readonly string Description => "Physical moves deal damage depending on both the Attack stat of the attacking Pokémon and " +
            "the Defense stat of the defending Pokémon.";

        public int GetOffensiveStatValue()
        {
            throw new NotImplementedException();
        }
    }
}
