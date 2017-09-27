using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class perfectResultLabel : MonoBehaviour {
    GameManager gameManager;
    Text perfectText;
    // Use this for initialization
    void Start()
    {
        perfectText = GetComponentInChildren<Text>();
        perfectText.text = "000";
        gameManager = GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        int perfectCount = GameData.perfectcombo;
        perfectText.text = ""+perfectCount;
    }
}
