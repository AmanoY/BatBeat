using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BackButtontoMusicSelect : MonoBehaviour {
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
    public void TouchButtonPush(){
        SceneManager.LoadScene("MusicSelectScene");
    }
}
