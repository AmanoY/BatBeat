using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class touchButton : MonoBehaviour {
	// Use this for initialization
	void Start ()
    {
        GameData.MusicSelectCount = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (GameData.MusicSelectCount < 0)
        {
            GameData.MusicSelectCount = 0;
        }
        if (GameData.MusicSelectCount>2)
        {
            GameData.MusicSelectCount = 2;
        }
	}
    public void touchButtonDown()
    {
        if (GameData.MusicSelectCount == 0)
        {
            GameData.MusicNumber = 1;
            SceneManager.LoadScene("GameScene1");
        }
        if (GameData.MusicSelectCount == 1)
        {
            GameData.MusicNumber = 2;
            SceneManager.LoadScene("GameScene2");
        }
        if (GameData.MusicSelectCount == 2)
        {
            GameData.MusicNumber = 3;
            SceneManager.LoadScene("GameScene3");
        }
    }
}
