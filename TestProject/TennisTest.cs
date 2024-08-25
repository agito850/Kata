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
            _tennis.GiveScoreToPlayers(1, 0);
            Assert.Equal("Fifteen Love", _tennis.Score());
        }
        
        [Fact]
        public void Thirty_Love()
        {
            _tennis.GiveScoreToPlayers(2, 0);
            Assert.Equal("Thirty Love", _tennis.Score());
        }
        
        [Fact]
        public void Forty_Love()
        {
            _tennis.GiveScoreToPlayers(3, 0);
            Assert.Equal("Forty Love", _tennis.Score());
        }
        
        [Fact]
        public void Love_Fifteen()
        {
            _tennis.GiveScoreToPlayers(0, 1);
            Assert.Equal("Love Fifteen", _tennis.Score());
        }
        
        [Fact]
        public void Love_Thirty()
        {
            _tennis.GiveScoreToPlayers(0, 2);
            Assert.Equal("Love Thirty", _tennis.Score());
        }
        
        [Fact]
        public void Love_Forty()
        {
            _tennis.GiveScoreToPlayers(0, 3);
            Assert.Equal("Love Forty", _tennis.Score());
        }
        
        [Fact]
        public void Fifteen_All()
        {
            _tennis.GiveScoreToPlayers(1, 1);
            Assert.Equal("Fifteen All", _tennis.Score());
        }
        
        [Fact]
        public void Thirty_All()
        {
            _tennis.GiveScoreToPlayers(2, 2);
            Assert.Equal("Thirty All", _tennis.Score());
        }
        
        [Fact]
        public void Deuce()
        {
            _tennis.GiveScoreToPlayers(3, 3);
            Assert.Equal("Deuce", _tennis.Score());
        }
        
        [Fact]
        public void Sam1_Adv_4_3()
        {
            _tennis.GiveScoreToPlayers(4, 3);
            Assert.Equal("Sam1 Adv", _tennis.Score());
        }
        
        [Fact]
        public void Sam1_Win_5_3()
        {
            _tennis.GiveScoreToPlayers(5, 3);
            Assert.Equal("Sam1 Win", _tennis.Score());
        }
        
        [Fact]
        public void Sam2_Adv_3_4()
        {
            _tennis.GiveScoreToPlayers(3, 4);
            Assert.Equal("Sam2 Adv", _tennis.Score());
        }
        
        [Fact]
        public void Sam2_Win_3_5()
        {
            _tennis.GiveScoreToPlayers(3, 5);
            Assert.Equal("Sam2 Win", _tennis.Score());
        }
        
        //保險加測

        #region additionalTest

        [Fact]
        public void Deuce_4_4()
        {
            _tennis.GiveScoreToPlayers(4, 4);
            Assert.Equal("Deuce", _tennis.Score());
        }
        
        [Fact]
        public void Sam1_Adv_5_4()
        {
            _tennis.GiveScoreToPlayers(5, 4);
            Assert.Equal("Sam1 Adv", _tennis.Score());
        }
        
        [Fact]
        public void Sam2_Adv_4_5()
        {
            _tennis.GiveScoreToPlayers(4, 5);
            Assert.Equal("Sam2 Adv", _tennis.Score());
        }
        
        [Fact]
        public void Sam1_Win_6_4()
        {
            _tennis.GiveScoreToPlayers(6, 4);
            Assert.Equal("Sam1 Win", _tennis.Score());
        }
        
        [Fact]
        public void Sam2_Win_4_6()
        {
            _tennis.GiveScoreToPlayers(4, 6);
            Assert.Equal("Sam2 Win", _tennis.Score());
        }


        #endregion
        
        
    }
}