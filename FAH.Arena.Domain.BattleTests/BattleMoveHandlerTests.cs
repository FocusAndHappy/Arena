using NUnit.Framework;
using FAH.Arena.Domain.Battle;

namespace FAH.Arena.Domain.Battle.Tests
{
    [TestFixture()]
    public class BattleMoveHandlerTests
    {
        readonly IBattleMoveHandler battleMoveHandler = new BattleMoveHandler();

        //Salamence attacks with no crit draco meteor 
        int _levelSalamence;
        int _powerDracoMeteor;
        int _attackSalamence;
        int _defenseSalamence;
        int _hitPointsSalamence;

        //Sceptile attacks with dragon pulse and crits
        int _levelSceptile;
        int _powerDragonpulse;
        int _attackSceptile;
        int _defenseSceptile;
        int _hitPointsSceptile;

        [SetUp]
        public void Setup()
        {
            _levelSalamence = 85;
            _powerDracoMeteor = 130;
            _attackSalamence = 218;
            _defenseSalamence = 167;
            _hitPointsSalamence = 336;

            _levelSceptile = 100;
            _powerDragonpulse = 85;
            _attackSceptile = 308;
            _defenseSceptile = 185;
            _hitPointsSceptile = 169;
        }

        [Test()]
        public void CalculateDamage_SalamenceAttacksSceptile_Between142And168Damage()
        {
            // Arrange
            int minDamage = 142;
            int maxDamage = 168;

            // Act
            var damage = battleMoveHandler.CalculateDamage(_levelSalamence, false, _powerDracoMeteor, _attackSalamence, _defenseSceptile, true, 1);

            // Assert
            Assert.GreaterOrEqual(maxDamage, damage);
            Assert.GreaterOrEqual(damage, minDamage);
        }

        [Test()]
        public void GetHitPointsAfterDamageTaken_SceptileHitByDracoMeteor_GreaterThan0()
        {
            // Arrange
            var damage = battleMoveHandler.CalculateDamage(_levelSalamence, false, _powerDracoMeteor, _attackSalamence, _defenseSceptile, true, 1);

            // Act
            var hitPoints = battleMoveHandler.GetHitPointsAfterDamageTaken(_hitPointsSceptile, damage);

            // Assert
            Assert.GreaterOrEqual(hitPoints, 0);
        }

        [Test()]
        public void HasPokemonFainted_SceptileAfterHit_False()
        {
            // Arrange
            var damage = battleMoveHandler.CalculateDamage(_levelSalamence, false, _powerDracoMeteor, _attackSalamence, _defenseSceptile, true, 1);
            var hitPoints = battleMoveHandler.GetHitPointsAfterDamageTaken(_hitPointsSceptile, damage);

            // Act
            var isFainted = battleMoveHandler.HasPokemonFainted(hitPoints);

            // Assert
            Assert.IsFalse(isFainted);
        }

        [Test()]
        public void CalculateDamage_SceptileAttacksSalamence_Between338And398Damage()
        {
            // Arrange
            int minDamage = 338;
            int maxDamage = 398;

            // Act
            var damage = battleMoveHandler.CalculateDamage(_levelSceptile, true, _powerDragonpulse, _attackSceptile, _defenseSalamence, false, 2);

            // Assert
            Assert.GreaterOrEqual(maxDamage, damage);
            Assert.GreaterOrEqual(damage, minDamage);
        }

        [Test()]
        public void GetHitPointsAfterDamageTaken_SalamenceHitByDragonpulse_Equals0()
        {
            // Arrange
            var damage = battleMoveHandler.CalculateDamage(_levelSceptile, true, _powerDragonpulse, _attackSceptile, _defenseSalamence, false, 2);

            // Act
            var hitPoints = battleMoveHandler.GetHitPointsAfterDamageTaken(_hitPointsSalamence, damage);

            // Assert
            Assert.Equals(hitPoints, 0);
        }

        [Test()]
        public void HasPokemonFainted_SalamenceAfterHit_True()
        {
            // Arrange
            var damage = battleMoveHandler.CalculateDamage(_levelSceptile, true, _powerDragonpulse, _attackSceptile, _defenseSalamence, false, 2);
            var hitPoints = battleMoveHandler.GetHitPointsAfterDamageTaken(_hitPointsSalamence, damage);

            // Act
            var isFainted = battleMoveHandler.HasPokemonFainted(hitPoints);

            // Assert
            Assert.IsTrue(isFainted);
        }
    }
}