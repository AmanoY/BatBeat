using UnityEngine;
using System.Collections;


public class GameManager2 : MonoBehaviour {
    //仮にGoodとPerfectに別々の点数を与えています。
    public int Score = 0, ComboScore, GoodScore, PerfectScore;
    int Combo = 0, Miss = 0, Good = 50, Perfect = 100;
    
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
    public void SetComboCount()
    {
        Combo++;
        ComboScore += (Combo / 5) * 500;
    }
    //ミス回数をゲット
    public int GetMissCount()
    {
        return Miss;
    }

    //ミス回数をセット
    public void SetMissCount()
    {
        Miss++;
    }

    //グッド回数をゲット
    public int GetGoodCount()
    {
        return Good;
    }

    //グッド回数をセット
    public void SetGoodCount()
    {
        Good++;
        GoodScore += Good;
    }
    //パーフェクト回数をゲット
    public int GetPerfectCount()
    {
        return Perfect;
    }
    //パーフェクト回数を瀬戸
    public void SetPerfectCount()
    {
        Perfect++;
        PerfectScore += Perfect;
    }
    //変数トータルスコア
    int TotalScore;
    //引数になったトータルスコアです。
    public int GetTotalScore()
    {
        return TotalScore= Score + ComboScore + GoodScore + PerfectScore;
    }
    public void SetTotalScore()
    {
        
    } 
    
}