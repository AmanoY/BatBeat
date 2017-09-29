using UnityEngine;
using System.Collections;

public class TestPlayer : MonoBehaviour {
    public AudioSource audiosource;
	// Use this for initialization
	void Start () {
	    audiosource= gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame

    public void PlaySE_touch()
    {
        audiosource.Play();
    }
}
