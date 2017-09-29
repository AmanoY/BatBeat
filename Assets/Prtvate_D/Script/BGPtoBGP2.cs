using UnityEngine;
using System.Collections;

public class BGPtoBGP2 : MonoBehaviour {
    public GameObject gameobect;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)) {
            Destroy(this.gameObject);
        }

	}
    
}
