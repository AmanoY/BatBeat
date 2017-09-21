using UnityEngine;
using System.Collections;
using UnityEngine.UI;

//テストDontDstoroyOnLoad

public class DontonMiss : MonoBehaviour {
    //UIテキストの選択
    public Text MissLabel;
	// Use this for initialization
	void Start () {
        int resultmiss = GameManager2.Miss;/*GameManager2から変数Missを引き出す(この際のMissは
        DontDestroyOnLoadで保護されているので別んAssetからも持ってこれる)*/
        
	}
	
	// Update is called once per frame
	void Update () {
        MissLabel.text = GameManager2.Miss.ToString("") + ( "Miss");
	}
}
