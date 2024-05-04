using FAH.Arena.Domain.Foundation.MoveCategories;
using FAH.Arena.Framework.Foundation;
using System;
using System.Collections.Generic;

namespace FAH.Arena.Domain.Foundation
{
    public class Move
    {

        /// <summary>
        /// Constructor call for a move
        /// </summary>
        public Move(Dictionary<string, object> moveData)
        {
            Name = (string)moveData["Name"];
            Description = (string)moveData["Description"];
            MoveType = (PokemonType)Enum.Parse(typeof(PokemonType), (string)moveData["Type"]);
            MoveCategory = GetCategoryByName((string)moveData["Category"]) ?? throw new NullReferenceException("Category could not be parsed!");
            Power = (int)moveData["Power"];
            Accuracy = (int)moveData["Accuracy"];
            PowerPoints = (int)moveData["PowerPoints"];
        }

        public string Name { get; }

        public string Description { get; }

        public PokemonType MoveType { get; }

        public IMoveCategory MoveCategory { get; }

        public int Power { get; set; }

        public int Accuracy { get; set; }

        public int PowerPoints { get; set; }


        private static IMoveCategory? GetCategoryByName(string categoryName)
        {
            switch(categoryName)
            {
                case nameof(Category.Physical):
                    return new PhysicalMove();
                case nameof(Category.Special):
                    return new SpecialMove();
                case nameof(Category.Status):
                    return new StatusMove();
                default:
                    return null;
            }
        }
    }
}
