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

        Evaluation[1, 1, 1] = 10000;
        Evaluation[1, 1, 2] = 8080;
        Evaluation[1, 1, 3] = 6060;
        Evaluation[1, 1, 4] = 4040;
        Evaluation[1, 1, 5] = 2020;

        Evaluation[1, 2, 1] = 28000;
        Evaluation[1, 2, 2] = 22400;
        Evaluation[1, 2, 3] = 16800;
        Evaluation[1, 2, 4] = 11200;
        Evaluation[1, 2, 5] = 5600;
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
            ItsmyLifeEasy();
        }
        else if (MusicSelectNumber[GameData.MusicNumber, GameData.DifficultyChange] == 4)
        {
            ItsmyLifeNormal();
        }
        if (MusicSelectNumber[GameData.MusicNumber, GameData.DifficultyChange] == 5)
        {
            ItsmyLifeEasy();
        }
        else if (MusicSelectNumber[GameData.MusicNumber, GameData.DifficultyChange] == 6)
        {
            ItsmyLifeNormal();
        }
    }
    public void ItsmyLifeEasy()
    {
        if (GameData.score == Evaluation[1,1,1])
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
            transform.position = A;
        }
        else if (GameData.score>=0)
        {
            transform.position = C;
        }
    }
    public void ItsmyLifeNormal()
    {
        if (GameData.score == Evaluation[1, 2, 1])
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
            transform.position = A;
        }
        else if (GameData.score >= 0)
        {
            transform.position = C;
        }
    }
}
