using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoSelectScene : MonoBehaviour {
    SceneChange sceceChange;

	// Use this for initialization
	void Start () {
        sceceChange=GameObject.FindObjectOfType<SceneChange>();

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonUp(0))
        {
            SceneManager.LoadScene("MusicSelectScenetest");
            //GameData.Reset();
        }
	}
}
