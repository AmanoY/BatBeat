using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MissresultLabel : MonoBehaviour {

    GameManager gameManager;
    Text MissText;
    // Use this for initialization
    void Start()
    {
        MissText = GetComponentInChildren<Text>();
        MissText.text = "000";
        gameManager = GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        int MissCount = GameManager.MissCount;
        MissText.text = "" + MissCount;
    }
}
