using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class MissCountLabel : MonoBehaviour {
    // インスペクターで参照を設定
    // ゲームマネージャーを覚えておくための変数
    public GameManager2 gameManager;
    // UIテキストを覚えておくための変数
    public Text MissLabel;

    // Update is called once per frames
    void Update()
    {
        MissLabel.text = gameManager.GetMissCount().ToString("0000") + (" Miss");
    }
}
