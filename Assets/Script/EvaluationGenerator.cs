using UnityEngine;
using System.Collections;

public class EvaluationGenerator : MonoBehaviour {
    // Use this for initialization
    //評価の画像を移動させる値
    Vector2 SSS = new Vector2(56, 0);
    Vector2 SS = new Vector2(36, 0);
    Vector2 S = new Vector2(16, 0);
    Vector2 A = new Vector2(-4, 0);
    Vector2 B = new Vector2(-24, 0);
    Vector2 C = new Vector2(-44, 0);

    int[,] MusicSelectNumber = new int[4, 3];

    //評価を決めるScore
    int[,,] Evaluation = new int[4,3,6];//[曲番号 , 難易度 , Score]
    
    void Start ()
    {
        MusicSelectNumber[1, 0] = 1;
        MusicSelectNumber[1, 1] = 2;
        MusicSelectNumber[2, 0] = 3;
        MusicSelectNumber[2, 1] = 4;
        MusicSelectNumber[3, 0] = 5;
        MusicSelectNumber[3, 1] = 6;

        Evaluation[1, 1, 1] = 9500;
        Evaluation[1, 1, 2] = 8080;
        Evaluation[1, 1, 3] = 6060;
        Evaluation[1, 1, 4] = 4040;
        Evaluation[1, 1, 5] = 2020;

        Evaluation[1, 2, 1] = 26400;
        Evaluation[1, 2, 2] = 22400;
        Evaluation[1, 2, 3] = 16800;
        Evaluation[1, 2, 4] = 11200;
        Evaluation[1, 2, 5] = 5600;

        Evaluation[2, 1, 1] = 5700;
        Evaluation[2, 1, 2] = 4880;
        Evaluation[2, 1, 3] = 3660;
        Evaluation[2, 1, 4] = 2440;
        Evaluation[2, 1, 5] = 1220;

        Evaluation[2, 2, 1] = 29000;
        Evaluation[2, 2, 2] = 24800;
        Evaluation[2, 2, 3] = 18420;
        Evaluation[2, 2, 4] = 12280;
        Evaluation[2, 2, 5] = 6140;

        Evaluation[3, 1, 1] = 15400;
        Evaluation[3, 1, 2] = 13120;
        Evaluation[3, 1, 3] = 9840;
        Evaluation[3, 1, 4] = 6560;
        Evaluation[3, 1, 5] = 3280;

        Evaluation[3, 2, 1] = 40000;
        Evaluation[3, 2, 2] = 33680;
        Evaluation[3, 2, 3] = 25260;
        Evaluation[3, 2, 4] = 17340;
        Evaluation[3, 2, 5] = 9760;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (MusicSelectNumber[GameData.MusicNumber,GameData.DifficultyChange]==1)
        {
            ItsmyLifeEasy();
        }
        else if (MusicSelectNumber[GameData.MusicNumber, GameData.DifficultyChange] == 2)
        {
            ItsmyLifeNormal();
        }
        if (MusicSelectNumber[GameData.MusicNumber, GameData.DifficultyChange] == 3)
        {
            CurseEasy();
        }
        else if (MusicSelectNumber[GameData.MusicNumber, GameData.DifficultyChange] == 4)
        {
            CurseNormal();
        }
        if (MusicSelectNumber[GameData.MusicNumber, GameData.DifficultyChange] == 5)
        {
            ReaperEasy();
        }
        else if (MusicSelectNumber[GameData.MusicNumber, GameData.DifficultyChange] == 6)
        {
            ReaperNormal();
        }
    }
    public void ItsmyLifeEasy()
    {
        if (GameData.score >= Evaluation[1,1,1])
        {
            transform.position = SSS;
        }
        else if (GameData.score >= Evaluation[1,1,2])
        {
            transform.position = SS;
        }
        else if (GameData.score >= Evaluation[1,1,3])
        {
            transform.position = S;
        }
        else if (GameData.score >= Evaluation[1,1,4])
        {
            transform.position = A;
        }
        else if (GameData.score >= Evaluation[1,1,5])
        {
            transform.position = B;
        }
        else if (GameData.score>=0)
        {
            transform.position = C;
        }
    }
    public void ItsmyLifeNormal()
    {
        if (GameData.score >= Evaluation[1, 2, 1])
        {
            transform.position = SSS;
        }
        else if (GameData.score >= Evaluation[1, 2, 2])
        {
            transform.position = SS;
        }
        else if (GameData.score >= Evaluation[1, 2, 3])
        {
            transform.position = S;
        }
        else if (GameData.score >= Evaluation[1, 2, 4])
        {
            transform.position = A;
        }
        else if (GameData.score >= Evaluation[1, 2, 5])
        {
            transform.position = B;
        }
        else if (GameData.score >= 0)
        {
            transform.position = C;
        }
    }

    public void CurseEasy()
    {
        if (GameData.score >= Evaluation[2, 1, 1])
        {
            transform.position = SSS;
        }
        else if (GameData.score >= Evaluation[2, 1, 2])
        {
            transform.position = SS;
        }
        else if (GameData.score >= Evaluation[2, 1, 3])
        {
            transform.position = S;
        }
        else if (GameData.score >= Evaluation[2, 1, 4])
        {
            transform.position = A;
        }
        else if (GameData.score >= Evaluation[2, 1, 5])
        {
            transform.position = B;
        }
        else if (GameData.score >= 0)
        {
            transform.position = C;
        }
    }

    public void CurseNormal()
    {
        if (GameData.score >= Evaluation[2, 2, 1])
        {
            transform.position = SSS;
        }
        else if (GameData.score >= Evaluation[2, 2, 2])
        {
            transform.position = SS;
        }
        else if (GameData.score >= Evaluation[2, 2, 3])
        {
            transform.position = S;
        }
        else if (GameData.score >= Evaluation[2, 2, 4])
        {
            transform.position = B;
        }
        else if (GameData.score >= Evaluation[2, 2, 5])
        {
            transform.position = A;
        }
        else if (GameData.score >= 0)
        {
            transform.position = C;
        }
    }

    public void ReaperEasy()
    {
        if (GameData.score >= Evaluation[3, 1, 1])
        {
            transform.position = SSS;
        }
        else if (GameData.score >= Evaluation[3, 1, 2])
        {
            transform.position = SS;
        }
        else if (GameData.score >= Evaluation[3, 1, 3])
        {
            transform.position = S;
        }
        else if (GameData.score >= Evaluation[3, 1, 4])
        {
            transform.position = A;
        }
        else if (GameData.score >= Evaluation[3, 1, 5])
        {
            transform.position = B;
        }
        else if (GameData.score >= 0)
        {
            transform.position = C;
        }
    }

    public void ReaperNormal()
    {
        if (GameData.score >= Evaluation[3, 2, 1])
        {
            transform.position = SSS;
        }
        else if (GameData.score >= Evaluation[3, 2, 2])
        {
            transform.position = SS;
        }
        else if (GameData.score >= Evaluation[3, 2, 3])
        {
            transform.position = S;
        }
        else if (GameData.score >= Evaluation[3, 2, 4])
        {
            transform.position = A;
        }
        else if (GameData.score >= Evaluation[3, 2, 5])
        {
            transform.position = B;
        }
        else if (GameData.score >= 0)
        {
            transform.position = C;
        }
    }
}
