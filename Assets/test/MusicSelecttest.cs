using UnityEngine;
using System.Collections;

public class MusicSelecttest : MonoBehaviour {
    // Use this for initialization
    int Count;
    public GameObject gameObjct;
    Vector3 position1 = new Vector3(362, 203.5f, -3770);
    Vector3 position2 = new Vector3(906.5f, 203, -3770);
    Vector3 position3 = new Vector3(1446.5f, 203, -3770);
    void Start ()
    {
        Count =0;
        gameObjct.transform.position = position1;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Count<0)
        {
            Count = 0;
        }
        if (Count > 2)
        {
            Count = 2;
        }
	}
}
