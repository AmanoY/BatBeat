using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreCountLabel : MonoBehaviour {

    // インスペクターで参照を設定
    // ゲームマネージャーを覚えておくための変数
    public GameManager gameManager;
    // UIテキストを覚えておくための変数
    public Text ScoreLabel;

    // Update is called once per frames
    void Update()
    {
        ScoreLabel.text = gameManager.GetScoreCount().ToString("0000000")+("Score");
    }
}
