﻿namespace TennisKata;

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

        //同分
        if (IsSameScore())
        {
            return IsBothMoreThanThreePoint() ? Deuce() : ScoreAll();
        }
        else 
        {
            //非同分

            //取得分數較高者的名字與分數
            int leadingPlayerScore = GetLeadingScore();
            string leadingPlayerName = GetLeadingPlayerName();


            //判斷是否為 領先 : 兩人都3分以上且其中一方多一分
            if (IsBothMoreThanThreePoint() && GetScoreGap() == 1)
            {
                return leadingPlayerName + " Adv";
            }
            //判斷是否為 勝利 : 
            //其中一方為4分時 另一方為3分以下
            //兩人都3分以上時 領先2分者
            //合併 -> 有人領先2分且領先者分數>=4
            if (leadingPlayerScore >= 4 && GetScoreGap() == 2)
            {
                return leadingPlayerName + " Win";
            }

            //一般情況
            return _scoreDic[_playerOneScore] + " " + _scoreDic[_playerTwoScore];
        }
    }

    private string ScoreAll()
    {
        return _scoreDic[_playerOneScore] + " All";
    }

    private string Deuce()
    {
        return "Deuce";
    }

    private string GetLeadingPlayerName()
    {
        if (_playerOneScore > _playerTwoScore)
        {
            return _playerOneName;
        }
        else
        {
            return _playerTwoName;
        }
    }

    private int GetLeadingScore()
    {
        if (_playerOneScore > _playerTwoScore)
        {
            return _playerOneScore;
        }
        else
        {
            return _playerTwoScore;
        }
    }

    private int GetScoreGap()
    {
        return Math.Abs(_playerOneScore - _playerTwoScore);
    }

    private static bool IsBothMoreThanThreePoint()
    {
        return _playerOneScore >= 3 && _playerTwoScore >= 3;
    }

    private bool IsSameScore()
    {
        return _playerOneScore == _playerTwoScore;
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