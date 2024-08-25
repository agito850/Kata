using TennisKata;

namespace TestProject
{
    public class TennisTest
    {
        private readonly Tennis _tennis;
        public TennisTest()
        {
            _tennis = new Tennis("Sam1","Sam2");
        }

        

        [Fact]
        public void Love_All()
        {
            Assert.Equal("Love All", _tennis.Score());
        }

        [Fact]
        public void Fifteen_Love()
        {
            _tennis.GiveScoreToPlayer(1, 1);
            Assert.Equal("Fifteen Love", _tennis.Score());
        }

        
    }
}