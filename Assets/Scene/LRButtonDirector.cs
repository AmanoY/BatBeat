using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class LRButtonDirector: MonoBehaviour {

    GameObject RButton;
    GameObject LButton;
    GameObject LeftButton;
    GameObject CenterButton;
    GameObject RightButton;

    public List<GameObject> musicSelect = new List<GameObject>();

    int offset = 325;
    public int tapCount = 0;

    // Use this for initialization
    void Start() {
        LeftButton = GameObject.Find("LeftButton");
        CenterButton = GameObject.Find("CenterButton");
        RightButton = GameObject.Find("RightButton");

        musicSelect.Add(LeftButton);
        musicSelect.Add(CenterButton);
        musicSelect.Add(RightButton);
    }

    public void MoveL() {
        if(tapCount >= 0 && tapCount < 2) {
            for(int i = 0; i < 3; i++) {
                musicSelect[i].transform.Translate(-offset, 0f, 0);
                if(tapCount >= 2) {
                    tapCount = 2;
                }
            }
            tapCount++;
        }
    }

    public void MoveR() {
        if(tapCount > 0 && tapCount <= 2) {
            for(int i = 0; i < 3; i++) {
                musicSelect[i].transform.Translate(offset, 0f, 0);
                Debug.Log("ああああああああ");
                if(tapCount <= 0) {
                    tapCount = 0;
                }
            }
            tapCount--;
        }
    }

    // Update is called once per frame
    void Update() {
    }
}