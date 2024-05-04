using System;

namespace FAH.Arena.Domain.Foundation.MoveCategories
{
    public struct StatusMove : IMoveCategory
    {
        public readonly Category Name => Category.Status;

        public readonly string Description => "Status move do not directly inflict damage. They include moves that change the weather, inflict status conditions, " +
            "or raise or lower the stats of a Pokémon, among other effects.";

        public int GetOffensiveStatValue()
        {
            throw new NotImplementedException();
        }
    }
}
