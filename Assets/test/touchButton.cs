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
            Debug.Log("マイライフ");
            SceneManager.LoadScene("GameScene1");
        }
        if (GameData.MusicSelectCount == 1)
        {
            Debug.Log("呪いの館");
            SceneManager.LoadScene("GameScene2");
        }
        if (GameData.MusicSelectCount == 2)
        {
            Debug.Log("死神のワロス");
            SceneManager.LoadScene("GameScene3");
        }
    }
}
