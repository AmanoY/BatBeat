using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NortsParticle : MonoBehaviour {

    public GameObject nortsParticle;

    // Use this for initialization
    void Start()
    {

    }
	// Update is called once per frame
	void Update () {
       
	}

    public void ParticlePlay()
    {
        Instantiate(nortsParticle, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
