using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MaxComboresultLabel : MonoBehaviour {
    GameManager gameManager;
    Text MaxComboText;
    // Use this for initialization
    void Start()
    {
        MaxComboText = GetComponentInChildren<Text>();
        MaxComboText.text = "000";
        gameManager = GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        int MaxCombo = GameManager.MaxComboCount;
        MaxComboText.text = "" + MaxCombo;
    }
}
}
