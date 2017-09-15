using UnityEngine;
using System.Collections;

public class LaneControl1 : MonoBehaviour {
	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("判定あり");
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("押されたよ1");
        }
    }
}
