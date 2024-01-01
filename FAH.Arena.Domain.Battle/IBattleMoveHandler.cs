namespace FAH.Arena.Domain.Battle
{
    public interface IBattleMoveHandler
    {
        /// <summary>
        /// This calculate the damage of an attack move based on the parameters given by the opposing pokemon and the used move
        /// </summary>
        /// <param name="level"></param>
        /// <param name="critical"></param>
        /// <param name="power"></param>
        /// <param name="attack"></param>
        /// <param name="defense"></param>
        /// <param name="stab"></param>
        /// <param name="type1"></param>
        /// <param name="type2"></param>
        /// <returns></returns>
        public int CalculateDamage(int level, bool critical, int power, int attack, int defense, bool stab, bool type1, bool type2);

        /// <summary>
        /// This determines the remaining hitpoints after an attack was executed
        /// </summary>
        /// <param name="currentHitPoints"></param>
        /// <param name="damageTaken"></param>
        /// <returns></returns>
        public int GetHitPointsAfterDamageTaken(int currentHitPoints, int damageTaken);

        /// <summary>
        /// This determines if the target has fainted after the hit points were reduced
        /// </summary>
        /// <param name="currentHitPoints"></param>
        /// <returns></returns>
        public bool HasTargetFainted(int currentHitPoints);
    }
}
