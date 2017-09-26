using UnityEngine;
using System.Collections;

public class GoMusicScene : MonoBehaviour {
    SceneChange sceneChange;
    // Use this for initialization
    void Start()
    {
        sceneChange = GameObject.FindObjectOfType<SceneChange>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void ScenechangeMusic()
    {
        sceneChange.NextSceneNumber(2);
    }
}
