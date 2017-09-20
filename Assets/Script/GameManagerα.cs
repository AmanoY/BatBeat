using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    //仮にGoodとPerfectに別々の点数を与えています。
    int Score = 0, Combo = 0, Miss = 0, Good = 50, Perfect = 100;

    //スコアをゲット
    public int GetScoreCount()
    {
        return Score;
    }

    //スコアをセット
    public void SetScore(int Value)
    {
        Score += Value;
    }

    //コンボ回数をゲット
    public int GetComboCount()
    {
        return Combo;
    }

    //コンボ回数をセット
    public void SetCoinCount()
    {
        Combo++;
    }







    }