using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class LRButtonDirector: MonoBehaviour {

    GameObject GameObject;

    int offset = 763;
    int tapCount = 0;

    // Use this for initialization
    void Start() {
        GameObject = GameObject.Find("GameObject");

        GameObject.transform.position = new Vector3(282, 120, 0);
    }

    public void MoveL() {
        if(tapCount >= 0 && tapCount < 2) {
            GameObject.transform.Translate(-offset, 0f, 0);
            tapCount++;
        }
    }

    public void MoveR() {
        if(tapCount > 0 && tapCount <= 2) {
            GameObject.transform.Translate(+offset, 0f, 0);
            tapCount--;
        }
    }

    // Update is called once per frame
    void Update() {
    }
}