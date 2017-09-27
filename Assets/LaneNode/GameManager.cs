using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public static int ComboCount = 0;
    public static int MaxComboCount = 0;
    public static int PerfectCount = 0;
    public static int GoodCount = 0;
    public static int MissCount;

    public static int TotalScore ;
    int PerfectsScore = 100;
    int GoodScore = 50;

    // Use this for initialization
    void Start () {
        //値を初期化
        TotalScore = 0;
        ComboCount = 0;
        MaxComboCount = 0;
        PerfectCount = 0;
        MissCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
        int CountRecord = 0;
        CountRecord = ComboCount;
        //MaxComboCountを記録
        if (MaxComboCount<CountRecord)
        {
            MaxComboCount = CountRecord;
            GameData.SetCombo(MaxComboCount);
        }
	}

    //Perfectの判定の時に呼び出されるメソッド
    public void PerfectComboCount()
    {
        ComboCount++;
        PerfectCount++;
        TotalScore += PerfectsScore;
        if (ComboCount%50==0)
        {
            GameData.score += 1000;
        }
        GameData.Setperfectcombo(1);
        GameData.SetScore(PerfectsScore);
    }

    //Goodの判定の時に呼び出されるメソッド
    public void GoodComboCount()
    {
        ComboCount++;
        GoodCount++;
        TotalScore+= GoodScore;
        if (ComboCount % 50 == 0)
        {
            GameData.score += 1000;
        }
        GameData.Setgoodcombo(1);
        GameData.SetScore(GoodScore);
    }

    //Missの判定の時に呼び出されるメソッド
    public void MissComboCount()
    {
        ComboCount=0;
        MissCount++;
        GameData.Setmisscombo(1);
    }


}
