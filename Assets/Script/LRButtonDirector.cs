using UnityEngine;
using System.Collections;

public class LRButtonDirector: MonoBehaviour {

    GameObject GameObject;

    int offset = 572;
    int tapCount = 0;

    // Use this for initialization
    void Start() {
        GameObject = GameObject.Find("GameObject");

        GameObject.transform.position = new Vector3(0, 0, 0);
    }

    public void MoveL() {
        if(tapCount >= 0 && tapCount < 2) {
            GameObject.transform.Translate(-offset, 0f, 0, Space.World);
            tapCount++;
        }
    }

    public void MoveR() {
        if(tapCount > 0 && tapCount <= 2) {
            GameObject.transform.Translate(+offset, 0f, 0, Space.World);
            tapCount--;
        }
    }

    // Update is called once per frame
    void Update() {
    }
}