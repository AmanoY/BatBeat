using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class goodresultLabel : MonoBehaviour
{
    GameManager gameManager;
    Text goodText;
    // Use this for initialization
    void Start()
    {
        goodText = GetComponentInChildren<Text>();
        goodText.text = "000";
        gameManager = GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        int goodCount = GameData.goodcombo;
        goodText.text = "" + goodCount;
    }
}

