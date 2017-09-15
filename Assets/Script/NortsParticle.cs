using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NortsParticle : MonoBehaviour {

    public GameObject nortsParticle;

	// Use this for initialization
	void Start () {
        nortsParticle = GetComponent<GameObject>();
       
	}
	
	// Update is called once per frame
	void Update () {

      
	}

    public void ParticlePlay()
    {
        Instantiate(nortsParticle);
    }
}
