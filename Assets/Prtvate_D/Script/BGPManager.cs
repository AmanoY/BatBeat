﻿using UnityEngine;
using System.Collections;

public class BGPManager : MonoBehaviour {

    public GameObject bgp1;
    public GameObject bgp2;
    public GameObject bgp3;
    public GameObject bgp4;
    int cnt = 0;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetMouseButtonDown(0))
        {
            cnt = ++cnt % 4;
            switch(cnt)
            {
                case 0:

                    bgp1.GetComponent<SpriteRenderer>().sortingOrder = 1;
                    bgp2.GetComponent<SpriteRenderer>().sortingOrder = 0;
                    bgp3.GetComponent<SpriteRenderer>().sortingOrder = 0;
                    bgp4.GetComponent<SpriteRenderer>().sortingOrder = 0;
                   
                    break;
                case 1:
                    bgp1.GetComponent<SpriteRenderer>().sortingOrder = 0;
                    bgp2.GetComponent<SpriteRenderer>().sortingOrder = 1;
                    bgp3.GetComponent<SpriteRenderer>().sortingOrder = 0;
                    bgp4.GetComponent<SpriteRenderer>().sortingOrder = 0;

                    break;
                case 2:
                    bgp1.GetComponent<SpriteRenderer>().sortingOrder = 0;
                    bgp2.GetComponent<SpriteRenderer>().sortingOrder = 0;
                    bgp3.GetComponent<SpriteRenderer>().sortingOrder = 1;
                    bgp4.GetComponent<SpriteRenderer>().sortingOrder = 0;

                    break;
                case 3:
                    bgp1.GetComponent<SpriteRenderer>().sortingOrder = 0;
                    bgp2.GetComponent<SpriteRenderer>().sortingOrder = 0;
                    bgp3.GetComponent<SpriteRenderer>().sortingOrder = 0;
                    bgp4.GetComponent<SpriteRenderer>().sortingOrder = 1;

                    break;
            }
        }
	}
}
