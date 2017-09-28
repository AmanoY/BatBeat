using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NotesGenerator3 : MonoBehaviour {


    float timer = 0.0f;

    int timeCount = 0;

    NotesGenerator difficulty;
    public SceneChange sceneChange;
    public GameObject notesPrefab;

    float[] ReaperEasy =
    {
2.675f,
5.64f,
7.128f,
8.655f,
10.086f,
11.58f,
13.078f,
14.535f,
16.002f,
17.51f,
19.071f,
20.708f,
22.044f,
23.586f,
25.095f,
26.603f,
27.996f,
29.59f,
31.078f,
32.673f,
34.014f,
35.6f,
37.026f,
38.569f,
40.036f,
41.678f,
42.103f,
43.145f,
44.683f,
45.031f,
46.178f,
48.344f,
49.066f,
49.754f,
50.512f,
51.233f,
52.053f,
52.85f,
53.762f,
56.601f,
59.655f,
62.671f,
65.617f,
66.392f,
67.084f,
67.872f,
68.627f,
69.414f,
70.142f,
70.845f,
71.592f,
73.162f,
74.662f,
76.082f,
77.617f,
79.109f,
80.549f,
82.072f,
83.634f,
84.053f,
85.125f,
86.652f,
87.059f,
88.097f,

    };
    // Use this for initialization
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	        //timerに時間を加算させ続ける
        timer += Time.deltaTime;
        if (timer>=5)
        {

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
        if (timer >= 90)
        {
            SceneManager.LoadScene("ClearScene");
        }
    }
	}

