using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NotesGenerator3 : MonoBehaviour {


    float timer = 0.0f;

    int timeCount = 0;
    public RectTransform clear;

    bool Chain;

    NotesGenerator difficulty;
    public SceneChange sceneChange;
    public GameObject notesPrefab;

    int Timer;

   public float[] ReaperEasy =

    {
6.7f,
9.6f,
11.1f,
12.7f,
14.1f,
15.6f,
17.1f,
18.5f,
20f,
21.5f,
23.1f,
24.7f,
26f,
27.6f,
29.1f,
30.6f,
32f,
33.6f,
35.1f,
36.7f,
38f,
39.6f,
41f,
42.6f,
44f,
45.7f,
46.1f,
47.1f,
48.7f,
49f,
50.2f,
52.3f,
53.1f,
53.8f,
54.5f,
55.2f,
56.1f,
56.9f,
57.8f,
60.6f,
63.7f,
66.7f,
69.6f,
70.4f,
71.1f,
71.9f,
72.6f,
73.4f,
74.1f,
74.8f,
75.6f,
77.2f,
78.7f,
80.1f,
81.6f,
83.1f,
84.5f,
86.1f,
87.6f,
88.1f,
89.1f,
90.7f,
91.1f,
92.1f,
93.1f,


    };
    // Use this for initialization
    void Start ()
    {
        Chain = true;
    }
	
	// Update is called once per frame
	void Update ()
    {
	        //timerに時間を加算させ続ける
        timer += Time.deltaTime;
        if (timer >= 4 && (Chain))
        {
            GetComponent<AudioSource>().Play();
            Chain = false;
        }
        if (GameData.DifficultyChange == 0)
        {
            //EasyのNotesを呼び出す
            for (timeCount = 0; timeCount < ReaperEasy.Length - 1; timeCount++)
            {

                if (ReaperEasy[timeCount] >= timer - Time.deltaTime / 2 && ReaperEasy[timeCount] <= timer + Time.deltaTime / 2)
                {

                    GameObject go = Instantiate(notesPrefab);
                }

            }
        }
        if (timer > 96)
        {
            clear.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 170);
        }
        if (timer >= 98)
        {
            SceneManager.LoadScene("ClearScene");
        }
    }
	}

