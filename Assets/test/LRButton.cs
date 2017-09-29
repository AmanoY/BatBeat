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
        GetComponent<AudioSource>().Play();
        GameData.MusicSelectCount--;
    }
    public void LButtonDown()
    {
        GetComponent<AudioSource>().Play();
        GameData.MusicSelectCount++;
    }
}
