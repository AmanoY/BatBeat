using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PerfectCountLabel : MonoBehaviour {

    // インスペクターで参照を設定
    // ゲームマネージャーを覚えておくための変数
    public GameManagerα gameManager;
    // UIテキストを覚えておくための変数
    public Text PerfectLabel;

    // Update is called once per frames
    void Update()
    {
        PerfectLabel.text = gameManager.GetPerfectCount().ToString("0000") + (" Perfect");
    }
}
