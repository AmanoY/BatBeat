using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GoodCountLabel : MonoBehaviour {

    // インスペクターで参照を設定
    // ゲームマネージャーを覚えておくための変数
    public GameManager gameManager;
    // UIテキストを覚えておくための変数
    public Text GoodLabel;

    // Update is called once per frames
    void Update()
    {

    }
}
       // GoodLabel.text = gameManager.GoodComboCount()== ToString("000000")+(" Good");