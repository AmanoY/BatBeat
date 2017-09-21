using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    bool one;

    public static int ComboCount = 0;
    public static int MaxComboCount=0;
    public static int PerfectCount=0;
    public static int GoodCount = 0;
    public static int MissCount = 0;

    static int Score = 0;
    public static int TotalScore = 0;
    int PerfectsScore = 100;
    int GoodScore = 50;

    // Use this for initialization
    void Start () {
        TotalScore = 0;
        ComboCount = 0;
        MaxComboCount = 0;
        PerfectCount = 0;
        MissCount = 0;

        one = false;
	}
	
	// Update is called once per frame
	void Update () {
        int CountRecord = 0;
        CountRecord = ComboCount;
        //MaxComboCountを記録
        if (MaxComboCount<CountRecord)
        {
            MaxComboCount = CountRecord;
        }
        /*
        //５０コンボ毎に1000Score加算
        if (one)
        {
            one = false;
            counb();
        }
        if (ComboCount==5)
        {
            one = true;
        }
        */
	}

    //Perfectの判定の時に呼び出されるメソッド
    public void PerfectComboCount()
    {
        ComboCount++;
        PerfectCount++;
        TotalScore += PerfectsScore;
    }

    //Goodの判定の時に呼び出されるメソッド
    public void GoodComboCount()
    {
        ComboCount++;
        GoodCount++;
        TotalScore+= GoodScore;
    }

    //Missの判定の時に呼び出されるメソッド
    public void MissComboCount()
    {
        ComboCount=0;
        MissCount++;
    }
    public void counb()
    {

        TotalScore += 1000;

    }

}
