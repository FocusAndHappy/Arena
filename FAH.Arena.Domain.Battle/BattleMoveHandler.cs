using System;

namespace FAH.Arena.Domain.Battle
{
    public class BattleMoveHandler : IBattleMoveHandler
    {
        public int CalculateDamage(int level, bool critical, int power, int attack, int defense, bool stab, bool type1, bool type2)
        {
            throw new NotImplementedException();
        }

        public int GetHitPointsAfterDamageTaken(int currentHitPoints, int damageTaken)
        {
            throw new NotImplementedException();
        }

        public bool HasTargetFainted(int currentHitPoints)
        {
            throw new NotImplementedException();
        }
    }
}
