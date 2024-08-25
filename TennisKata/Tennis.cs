namespace TennisKata;

public class Tennis
{
    private readonly string _playerOneName;
    private int _playerOneScore;
    private int _playerTwoScore;
    private readonly string _playerTwoName;


    public Tennis(string playerOneName, string playerTwoName)
    {
        _playerOneName = playerOneName;
        _playerTwoName = playerTwoName;
        _playerOneScore = 0;
        _playerTwoScore = 0;
    }

    private Dictionary<int, string> _scoreDic = new Dictionary<int, string>() {
        { 0,"Love"},
        { 1,"Fifteen"},
        { 2,"Thirty"},
        { 3,"Forty"}
    };

    public string Score()
    {
        //1. 輸出必須為網球分數 例：1:0 => Fifteen Love 
        //2. 分數表達必須是文字例如Fifteen Forty 而非15：40 
        //3. 賽末點時 輸出為 Player Name Adv, 例：Sam Adv
        //4. 勝出時 輸出為 Player Name Win, 例：Sam Win

        //判斷是否為 平局 : 同分且3分以上
        if (_playerOneScore >= 3 && _playerTwoScore >= 3 && _playerOneScore == _playerTwoScore)
        {
            return "Deuce";
        }
        
        //判斷是否為 領先 : 兩人都3分以上且其中一方多一分
        if (_playerOneScore >= 3 && _playerTwoScore >= 3 && Math.Abs(_playerOneScore -_playerTwoScore) == 1)
        {
            if (_playerOneScore > _playerTwoScore)
            {
                return _playerOneName + " Adv";
            }
            else 
            {
                return _playerTwoName + " Adv";
            }
        }
        //判斷是否為 勝利 : 
        //其中一方為4分時 另一方為3分以下
        //兩人都3分以上時 領先2分者
        //合併 -> 有人領先2分且領先者>=4

        var leadingPlayerScore = 0;
        if (_playerOneScore > _playerTwoScore)
        {
            leadingPlayerScore = _playerOneScore;
        }
        else
        {
            leadingPlayerScore = _playerTwoScore;
        }

        if (leadingPlayerScore >= 4 && Math.Abs(_playerOneScore - _playerTwoScore) == 2)
        {
            if (_playerOneScore > _playerTwoScore)
            {
                return _playerOneName + " Win";
            }
            else
            {
                return _playerTwoName + " Win";
            }
        }

        //同分
        if (_playerOneScore == _playerTwoScore) 
        {
            return _scoreDic[_playerOneScore] + " All";
        }

        //一般情況
        return _scoreDic[_playerOneScore] + " " + _scoreDic[_playerTwoScore];

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