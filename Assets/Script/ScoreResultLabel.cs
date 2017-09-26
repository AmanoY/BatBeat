using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreResultLabel : MonoBehaviour {
    GameManager gameManager;
    Text ScoreText;
    // Use this for initialization
    void Start ()
    {
        ScoreText = GetComponentInChildren<Text>();
        ScoreText.text = "00000";
        gameManager = GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        int Score = GameManager.TotalScore;
        ScoreText.text = "" + Score;
    }
}
