using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

//ワルツEasy譜面
public class NotesGenerator5 : MonoBehaviour {
    float timer = 0.0f;

    int timeCount = 0;

    public RectTransform Clear;
    bool Chain;

    NotesGenerator difficulty;
    public SceneChange sceneChange;
    public GameObject notesPrefab;

    int Timer;
    public float[] ReaoerEasy =
    {
5.015f,
5.411f,
6.16f,
6.507f,
7.295f,
7.675f,
8.393f,
8.765f,
9.543f,
9.943f,
10.711f,
11.114f,
11.805f,
12.203f,
12.973f,
13.363f,
13.932f,
14.347f,
15.115f,
15.5f,
16.25f,
16.633f,
17.04f,
18.552f,
18.9f,
19.66f,
20.8f,
21.216f,
23.019f,
23.396f,
24.116f,
24.444f,
25.254f,
25.659f,
26.333f,
26.724f,
27.56f,
28f,
28.603f,
29.032f,
29.68f,
30.166f,
30.567f,
32.038f,
32.493f,
33.128f,
33.592f,
34.247f,
34.68f,
35.123f,
36.229f,
38.368f,
38.952f,
39.205f,
39.516f,
40.618f,
41.737f,
42.838f,
43.98f,
45.051f,
46.228f,
47.383f,
48.505f,
49.685f,
50.803f,
51.917f,
53.095f,
54.177f,
55.235f,
56.329f,
57.357f,
58.495f,
59.692f,
60.852f,
61.957f,
63.073f,
64.122f,
65.325f,
66.427f,
67.584f,
68.685f,
69.794f,
70.963f,
72.15f,
74.333f,
76.536f,
78.876f,
79.323f,
79.673f,
79.988f,
81.57f,
81.865f,
82.649f,
82.999f,
83.767f,
84.132f,
86.038f,
86.35f,
87.16f,
87.495f,
88.315f,
88.63f,
89.357f,
89.72f,
90.493f,
90.855f,
91.617f,
91.989f,
92.768f,
93.121f,
93.478f,
94.98f,
95.343f,
96.109f,
96.48f,
97.252f,
97.628f,
98.021f,
99.506f,
99.89f,
100.636f,
100.993f,
101.782f,
102.15f,
102.879f,
103.27f,
104.003f,
104.406f,
105.092f,
105.495f,
106.253f,
106.655f,
107.042f,
108.52f,
108.892f,
109.603f,
109.978f,
110.686f,
111.083f,
111.508f,
114.886f,
115.437f,
115.659f,
116.08f,

    };
    // Use this for initialization
    void Start ()
    {
        Chain = true;
        Clear.GetComponent<RectTransform>().anchoredPosition = new Vector2(1500, 170);
    }
	
	// Update is called once per frame
	void Update ()
    {
        //timerに時間を加算させ続ける
        timer += Time.deltaTime;
        if (timer >= 5 && (Chain))
        {
            GetComponent<AudioSource>().Play();
            Chain = false;
        }
        if (GameData.DifficultyChange == 0)
        {
            //EasyのNotesを呼び出す
            for (timeCount = 0; timeCount < ReaoerEasy.Length - 1; timeCount++)
            {

                if (ReaoerEasy[timeCount] >= timer - Time.deltaTime / 2 && ReaoerEasy[timeCount] <= timer + Time.deltaTime / 2)
                {

                    GameObject go = Instantiate(notesPrefab);
                }

            }
        }
        if (timer>118)
        {
            Clear.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 170);
        }
        if (timer >= 120)
        {
            SceneManager.LoadScene("ClearScene");
        }
    }
}

