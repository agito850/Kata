using NUnit.Framework;

namespace TennisKata;

[TestFixture]
[TestOf(typeof(Tennis))]
public class TennisTest
{

    [Test]
    public void Love_All()
    {
        var tennis = new Tennis("Sam1", "Sam2");
        var score = tennis.Score();
        Assert.AreEqual("Love-All", score);
    }
}