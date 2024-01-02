using System;

namespace FAH.Arena.Domain.Battle
{
    public class BattleMoveHandler : IBattleMoveHandler
    {
        /// <inheritdoc />
        public int CalculateDamage(int level, bool critical, int power, int attack, int defense, bool stab, float typeModifier)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public int GetHitPointsAfterDamageTaken(int currentHitPoints, int damageTaken)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool HasPokemonFainted(int hitPoints)
        {
            throw new NotImplementedException();
        }
    }
}
