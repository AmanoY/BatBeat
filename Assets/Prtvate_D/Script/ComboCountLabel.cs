using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ComboCountLabel : MonoBehaviour {

    // インスペクターで参照を設定
    // ゲームマネージャーを覚えておくための変数
    public GameManager gameManager;
    // UIテキストを覚えておくための変数
    public Text ComboLabel;
    // Update is called once per frames
    void Update()
    {
        ComboLabel.text = gameManager.MaxComboCount().ToString("000000") + (" Combo");
    }
}
