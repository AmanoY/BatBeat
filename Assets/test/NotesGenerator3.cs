using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NotesGenerator3 : MonoBehaviour {


    float timer = 0.0f;

    int timeCount = 0;

    bool Chain;

    NotesGenerator difficulty;
    public SceneChange sceneChange;
    public GameObject notesPrefab;

    int Timer;

    float[] ReaperEasy =
    {
7.675f,
10.64f,
12.128f,
13.655f,
15.086f,
16.58f,
18.078f,
19.535f,
21.002f,
22.51f,
24.071f,
25.708f,
27.044f,
28.586f,
30.095f,
31.603f,
32.996f,
34.59f,
36.078f,
37.673f,
39.014f,
40.6f,
42.026f,
43.569f,
45.036f,
46.678f,
47.103f,
48.145f,
49.683f,
50.031f,
51.178f,
53.344f,
54.066f,
54.754f,
55.512f,
56.233f,
57.053f,
57.85f,
58.762f,
61.601f,
64.655f,
67.671f,
70.617f,
71.392f,
72.084f,
72.872f,
73.627f,
74.414f,
75.142f,
75.845f,
76.592f,
78.162f,
79.662f,
81.082f,
82.617f,
84.109f,
85.549f,
87.072f,
88.634f,
89.053f,
90.125f,
91.652f,
92.059f,
93.097f,

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
        if (timer >= 98)
        {
            SceneManager.LoadScene("ClearScene");
        }
    }
	}

