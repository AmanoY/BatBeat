using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausePanel : MonoBehaviour
{
    GameManager gameManager;

    bool isVisible;


   // public GameObject soundManagerPrefab;
    //SoundManager soundManager;

    // public Slider sliderBGM;
    // public Slider sliderSE;
    AudioSource menuButtonSound;

    //public void ToggleShow()
    //{
    //    if (gameManager.GamePlay())
    //    {
    //        if (isVisible)
    //        {
    //            Hide();
    //            gameManager.isPause = false;
    //        }
    //        else
    //        {
    //            gameManager.isPause = true;
    //            isVisible = true;
    //            GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -0);
    //        }
    //    }
    //}

    //public void Hide()
    //{
    //    GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 2000);
    //    isVisible = false;

    //}
    //public void BackButton()
    //{
    //    Debug.Log("バックボタンおされた");
    //    menuButtonSound.PlayOneShot(menuButtonSound.clip);
    //    gameManager.isPause = false;
    //    Hide();
    //}

    //public void RetireButton()
    //{
    //    Debug.Log("リタイアボタンおされた");
    //    menuButtonSound.PlayOneShot(menuButtonSound.clip);
    //    Invoke("LoadSelectScene", 0.5f);
    //}
    //    // Use this for initialization
        void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
