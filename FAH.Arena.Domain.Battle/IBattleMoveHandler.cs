namespace FAH.Arena.Domain.Battle
{
    public interface IBattleMoveHandler
    {
        /// <summary>
        /// This calculates the damage of an attack move based on the parameters given by the opposing pokemon and the used move
        /// </summary>
        /// <param name="level">level of the attacking pokemon</param>
        /// <param name="critical">is the attack an crit</param>
        /// <param name="power">power of the move</param>
        /// <param name="attack">attack of the attacking pokemon</param>
        /// <param name="defense">defense of the defending pokemon</param>
        /// <param name="stab">has the move same type attack bonus/param>
        /// <param name="typeModifier">type modifier for how effective the move is against the defending pokemon/param>
        /// <returns>calculated damage of the move on the defending pokemon</returns>
        public int CalculateDamage(int level, bool critical, int power, int attack, int defense, bool stab, float typeModifier);

        /// <summary>
        /// This determines the remaining hitpoints after an attack was executed
        /// </summary>
        /// <param name="currentHitPoints">hit points of the pokemon before the attack</param>
        /// <param name="damageTaken">damage applied to the defending pokemon</param>
        /// <returns>hit points after the damage was applied</returns>
        public int GetHitPointsAfterDamageTaken(int currentHitPoints, int damageTaken);

        /// <summary>
        /// This determines if the pokemon has fainted after the hit points were reduced
        /// </summary>
        /// <param name="hitPoints">hit points of the pokemon</param>
        /// <returns>True, if the pokemon has zero hit points</returns>
        public bool HasPokemonFainted(int hitPoints);
    }
}
