namespace TennisKata;

public class Tennis
{
    private readonly string _playerOneName;
    private int _playerOneScore;
    private int _playerTwoScore;
    private readonly string _playerTwoName;

    private Dictionary<int, string> scoreDic = new Dictionary<int, string>()
    {
        { 0, "Love" }, 
        { 1, "Fifteen" }, 
        { 2, "Thirty" }, 
        { 3, "Forty" }
    };

    public Tennis(string playerOneName, string playerTwoName)
    {
        _playerOneName = playerOneName;
        _playerTwoName = playerTwoName;
        _playerOneScore = 0;
        _playerTwoScore = 0;
    }

    public string Score()
    {
        //1. 輸出必須為網球分數 例：1:0 => Fifteen Love 
        //2. 分數表達必須是文字例如Fifteen Forty 而非15：40 
        //3. 賽末點時 輸出為 Player Name Adv, 例：Sam Adv
        //4. 勝出時 輸出為 Player Name Win, 例：Sam Win
        
        if(IsSameScore())
        {
           return IsDeuce()? Deuce() : SameScore();
        }
        
        return IsBothHaveAtLeastThreePoints() ? GetWinOrAdvPlayer() : DifferentScore();
    }

    private bool IsBothHaveAtLeastThreePoints()
    {
        return _playerOneScore >= 3 && _playerTwoScore >= 3;
    }

    private string DifferentScore()
    {
        var playerOneScore = scoreDic[_playerOneScore];
        var playerTwoScore = scoreDic[_playerTwoScore];
        return playerOneScore + " " + playerTwoScore;
    }

    private static string Deuce()
    {
        return "Deuce";
    }

    private string SameScore()
    {
        return scoreDic[_playerOneScore] + " All";
    }

    private bool IsSameScore()
    {
        return _playerOneScore == _playerTwoScore;
    }

    private bool IsDeuce()
    {
        return IsSameScore() && _playerOneScore >= 3;
    }

    private string GetWinOrAdvPlayer()
    {
        return GetAdvPlayerName() + (IsAdv() ? " Adv" :" Win");
    }

    private bool IsAdv()
    {
        return Math.Abs(_playerOneScore - _playerTwoScore) == 1;
    }

    private string GetAdvPlayerName()
    {
        var advPlayer = _playerOneScore > _playerTwoScore ? _playerOneName : _playerTwoName;
        return advPlayer;
    }

    public void PlayerOneScore()
    {
        _playerOneScore++;
    }

    public void PlayerTwoScore()
    {
        _playerTwoScore++;
    }
}