namespace FAH.Arena.Domain.Battle.Test
{
    public class BattleMoveHandlerTests
    {
        //Salamence attacks with draco meteor
        int _levelSalamence;
        int _powerDracoMeteor;
        int _attackSalamence;
        int _defenseSalamence;

        //Sceptile attacks with dragon pulse
        int _levelSceptile;
        int _powerDragonPulse;
        int _attackSceptile;
        int _defenseSceptile;

        [SetUp]
        public void Setup()
        {
            _levelSalamence = 85;
            _powerDracoMeteor = 130;
            _attackSalamence = 218;
            _defenseSalamence = 167;

            _levelSceptile = 100;
            _powerDragonPulse = 85;
            _attackSceptile = 308;
            _defenseSceptile = 185;
        }



        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}