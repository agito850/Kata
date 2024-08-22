using NUnit.Framework;

namespace TennisKata;

[TestFixture]
[TestOf(typeof(Tennis))]
public class TennisTest
{
    private Tennis _tennis;
    
    [SetUp]
    public void SetUp()
    {
        _tennis = new Tennis("Sam Adv", "Sam Win");
    }
    
    private void ScoreShouldBe(string expected)
    {
        var score = _tennis.Score();
        Assert.AreEqual(expected, score);
    }

    [Test]
    public void Love_All()
    {
        ScoreShouldBe("Love All");
    }
    
    [Test]
    public void Fifteen_Love()
    {
        _tennis.PlayerOneScore();
        ScoreShouldBe("Fifteen Love");
    }
    
    [Test]
    public void Thirty_Love()
    {
        _tennis.PlayerOneScore();
        _tennis.PlayerOneScore();
        ScoreShouldBe("Thirty Love");
    }
    
    [Test]
    public void Forty_Love()
    {
        _tennis.PlayerOneScore();
        _tennis.PlayerOneScore();
        _tennis.PlayerOneScore();
        ScoreShouldBe("Forty Love");
    }
    
    [Test]
    public void Love_Fifteen()
    {
        _tennis.PlayerTwoScore();
        ScoreShouldBe("Love Fifteen");
    }
    
    [Test]
    public void Love_Thirty()
    {
        _tennis.PlayerTwoScore();
        _tennis.PlayerTwoScore();
        ScoreShouldBe("Love Thirty");
    }
    
    [Test]
    public void Love_Forty()
    {
        _tennis.PlayerTwoScore();
        _tennis.PlayerTwoScore();
        _tennis.PlayerTwoScore();
        ScoreShouldBe("Love Forty");
    }
    
    [Test]
    public void Fifteen_All()
    {
        _tennis.PlayerOneScore();
        _tennis.PlayerTwoScore();
        ScoreShouldBe("Fifteen All");
    }
    
    [Test]
    public void Thirty_All()
    {
        _tennis.PlayerOneScore();
        _tennis.PlayerOneScore();
        _tennis.PlayerTwoScore();
        _tennis.PlayerTwoScore();
        ScoreShouldBe("Thirty All");
    }
    
    [Test]
    public void Deuce()
    {
        _tennis.PlayerOneScore();
        _tennis.PlayerOneScore();
        _tennis.PlayerOneScore();
        _tennis.PlayerTwoScore();
        _tennis.PlayerTwoScore();
        _tennis.PlayerTwoScore();
        ScoreShouldBe("Deuce");
    }
    
}