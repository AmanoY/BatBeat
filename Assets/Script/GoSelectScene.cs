using UnityEngine;
using System.Collections;

public class GoSelectScene : MonoBehaviour {
    SceneChange sceceChange;
	// Use this for initialization
	void Start () {
        sceceChange=GameObject.FindObjectOfType<SceneChange>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButton(0))
        {
            sceceChange.NextSceneNumber(2);
        }
	}
}
