using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DifficultyChange : MonoBehaviour {

    GameObject normalColor;
    GameObject easyColor;
    ColorBlock cdBn;
	// Use this for initialization
	void Start ()
    {
        GameData.Reset();
        normalColor = GameObject.Find("NormalButton");
        easyColor = GameObject.Find("EasyButton");
        GameData.DifficultyChange = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (GameData.DifficultyChange == 0)
        {
            easyColor.GetComponentInChildren<Image>().color = new Color(1.0f, 0.0f, 0.0f);
            normalColor.GetComponentInChildren<Image>().color = new Color(1.0f, 1.0f, 1.0f);
        }
        else if (GameData.DifficultyChange == 1)
        {
            normalColor.GetComponentInChildren<Image>().color = new Color(1.0f, 0.0f, 0.0f);
            easyColor.GetComponentInChildren<Image>().color = new Color(1.0f, 1.0f, 1.0f);
        }
	}
    public void DifficultyEasy()
    {

        //cdBn.normalColor = Color;
        GetComponent<AudioSource>().Play();
        GameData.DifficultyChange = 0;
    }
    public void DIfficultyNormal()
    {
        GetComponent<AudioSource>().Play();
        GameData.DifficultyChange = 1;
    }

}
