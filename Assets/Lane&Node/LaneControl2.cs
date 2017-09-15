using UnityEngine;
using System.Collections;

public class LaneControl2 : MonoBehaviour
{
    NotesControl2 Destry;
    // Use this for initialization
    void Start()
    {
        Destry = GameObject.FindObjectOfType<NotesControl2>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("判定あり");
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("押されたよ2");
            Destry.DestroyObject2();
        }
    }
}