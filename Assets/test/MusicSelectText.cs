using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MusicSelectText : MonoBehaviour {
    Text MusicSelectName;
	// Use this for initialization
	void Start ()
    {
        MusicSelectName = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (GameData.MusicSelectCount == 0)
        {
            MusicSelectName.text = ("It's my life");
        }
        if (GameData.MusicSelectCount == 1)
        {
            MusicSelectName.text = ("呪いの館");
        }
        if (GameData.MusicSelectCount == 2)
        {
            MusicSelectName.text = ("死神のワルツ");
        }
    }
}
