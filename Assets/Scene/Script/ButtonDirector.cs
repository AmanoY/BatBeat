using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonDirector: MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
    public void MusicButtonPush() {
        SceneManager.LoadScene("MusicSelectScene");
    }

    public void BackButtonPush() {
        SceneManager.LoadScene("TitleScene");
    }
}