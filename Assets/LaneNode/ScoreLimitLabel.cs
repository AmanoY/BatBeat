using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreLimitLabel : MonoBehaviour {
    // インスペクターで参照を設定
    // ゲームマネージャーを覚えておくための変数
     GameManager gameManager;
     GameObject obj;
     Text ScoreText;
    // UIテキストを覚えておくための変数
     void Start()
    {
        ScoreText = GetComponentInChildren<Text>();
        ScoreText.text = "000";
        obj = GameObject.Find("GameManager");
        gameManager = GetComponent<GameManager>();
    }
    // Update is called once per frames
    void Update()
    {
        int Score = GameManager.TotalScore;
        ScoreText.text =""+Score;
    }
}
