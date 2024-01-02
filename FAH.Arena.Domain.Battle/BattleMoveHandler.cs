using System;

namespace FAH.Arena.Domain.Battle
{
    public class BattleMoveHandler : IBattleMoveHandler
    {
        public int CalculateDamage(int level, bool critical, int power, int attack, int defense, bool stab, float typeModifier)
        {
            throw new NotImplementedException();
        }

        public int GetHitPointsAfterDamageTaken(int currentHitPoints, int damageTaken)
        {
            throw new NotImplementedException();
        }

        public bool HasPokemonFainted(int hitPoints)
        {
            throw new NotImplementedException();
        }
    }
}
