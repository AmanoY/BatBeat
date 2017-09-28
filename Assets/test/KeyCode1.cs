using UnityEngine;
using System.Collections;

public class KeyCode1 : MonoBehaviour {
    TouchManager tap;
	// Use this for initialization
	void Start () {
        tap = GetComponent<TouchManager>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            tap.KeychordDown();
            tap.KeychordUp();
        }
	}
}
