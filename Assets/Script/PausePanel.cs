using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausePanel : MonoBehaviour
{
    GameManager gameManager;

   public AudioSource audioSouse;


    bool isVisible;
    public void ToggleShow()
    {
            if (isVisible)
            {
                Hide();
            this.audioSouse.UnPause();
            GameManager.isPause = true;
            }
            else
            {
                this.audioSouse.Pause();
                GameManager.isPause = false;
                isVisible = true;
                GetComponent<RectTransform>().anchoredPosition = new Vector2(0,410);
            }
        
    }

    public void Hide()
    {

        GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 2000);
        isVisible = false;

    }
    public void BackButton()
    {
        Debug.Log("バックボタンおされた");
        GameManager.isPause = false;
        Hide();
    }

    public void RetireButton()
    {
        Debug.Log("リタイアボタンおされた");
        SceneManager.LoadScene("MusicSelectScenetest");
       // Invoke("LoadSelectScene", 0.5f);
    }

    void Start()
    {
       // audioSouse.PlayOneShot(audioSouse.clip);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
