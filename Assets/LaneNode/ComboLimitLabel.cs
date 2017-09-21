using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ComboLimitLabel : MonoBehaviour {

    GameManager gameManager;
    GameObject obj;
    Text ComboText;
	// Use this for initialization
	void Start () {
        ComboText = GetComponentInChildren<Text>();
        ComboText.text = "000";
        obj = GameObject.Find("GameManager");
        gameManager = GetComponent<GameManager>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        int Count = GameManager.ComboCount;
        ComboText.text = "" + Count;
    }
}
