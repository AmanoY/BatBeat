using UnityEngine;
using System.Collections;

public class LRButton : MonoBehaviour {

    touchButton TouchButton;
    GameObject obj;

	// Use this for initialization
	void Start ()
    {
        TouchButton = GetComponent<touchButton>();
        obj = GameObject.Find("CenterButton");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void RButtonDown()
    {
        Debug.Log("マイナスされたよ");
        GameData.MusicSelectCount--;
    }
    public void LButtonDown()
    {
        Debug.Log("プラスされたよ");
        GameData.MusicSelectCount++;
    }
}
