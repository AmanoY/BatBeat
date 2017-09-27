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

    int[,] MusicSelectNumber = new int[3, 2];

    //評価を決めるScore
    int[,,] Evaluation = new int[4,3,6];//[曲番号 , 難易度 , Score]
    
    void Start ()
    {

        Evaluation[1, 1, 1] = 10000;
        Evaluation[1, 1, 2] = 8080;
        Evaluation[1, 1, 3] = 6060;
        Evaluation[1, 1, 4] = 4040;
        Evaluation[1, 1, 5] = 2020;

        Evaluation[1, 2, 1] = 10000;
        Evaluation[1, 2, 2] = 8080;
        Evaluation[1, 2, 3] = 6060;
        Evaluation[1, 2, 4] = 4040;
        Evaluation[1, 2, 5] = 2000;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (MusicSelectNumber[1,1]==1)
        {
            ItsmyLifeEasy();
        }
        if (GameData.score == Evaluation[1, 1, 1])
        {
            transform.position = SSS;
        }
        else if (GameData.score >= Evaluation[1, 1, 2])
        {
            transform.position = SS;
        }
        else if (GameData.score >= Evaluation[1, 1, 3])
        {
            transform.position = S;
        }
        else if (GameData.score >= Evaluation[1, 1, 4])
        {
            transform.position = A;
        }
        else if (GameData.score >= Evaluation[1, 1, 5])
        {
            transform.position = B;
        }
        else if (GameData.score >= 0)
        {
            transform.position = C;
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
        else
        {
            transform.position = C;
        }
    }
}
