using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BackButtontoMusicSelect : MonoBehaviour {
    SceneChange sceneChange;

    void Start()
    {
        sceneChange = GameObject.FindObjectOfType<SceneChange>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            sceneChange.NextSceneNumber(3);
        }
    }
    public void TouchButtonPush(){
        SceneManager.LoadScene("MusicSelectScene");
    }
}
