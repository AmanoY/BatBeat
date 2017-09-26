using UnityEngine;
using System.Collections;

public class LRButtonDirector: MonoBehaviour {

    GameObject RButton;
    GameObject LButton;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
    
    }
    public void RightButtonPush() {
        RButton.transform.position = new Vector2(600, -60);
    }
    public void LeftButtonPush() {
        LButton.transform.position = new Vector2(-600, -60);
    }
}