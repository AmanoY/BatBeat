using UnityEngine;
using System.Collections;

public class Titlego : MonoBehaviour {
    SceneChange sceneChange;
	// Use this for initialization
	void Start ()
    {
        sceneChange = GameObject.FindObjectOfType<SceneChange>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButton(0))
        {
            sceneChange.NextSceneNumber(1);
        }
	}
}
