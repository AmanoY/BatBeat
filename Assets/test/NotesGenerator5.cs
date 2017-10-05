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
//1.16f,
//1.507f,
//2.295f,
//2.675f,
//3.393f,
//3.765f,
//4.543f,
4.943f,
5.711f,
6.114f,
6.805f,
7.203f,
7.973f,
8.363f,
8.932f,
9.347f,
10.115f,
10.5f,
11.25f,
11.633f,
12.04f,
13.552f,
13.9f,
14.66f,
15.8f,
16.216f,
18.019f,
18.396f,
19.116f,
19.444f,
20.254f,
20.659f,
21.333f,
21.724f,
22.56f,
23f,
23.603f,
24.032f,
24.68f,
25.166f,
25.567f,
27.038f,
27.493f,
28.128f,
28.592f,
29.247f,
29.68f,
30.123f,
31.229f,
33.368f,
33.952f,
34.205f,
34.516f,
35.618f,
36.737f,
37.838f,
38.98f,
40.051f,
41.228f,
42.383f,
43.505f,
44.685f,
45.803f,
46.917f,
48.095f,
49.177f,
50.235f,
51.329f,
52.357f,
53.495f,
54.692f,
55.852f,
56.957f,
58.073f,
59.122f,
60.325f,
61.427f,
62.584f,
63.685f,
64.794f,
65.963f,
67.15f,
69.333f,
71.536f,
73.876f,
74.323f,
74.673f,
74.988f,
76.57f,
76.865f,
77.649f,
77.999f,
78.767f,
79.132f,
81.038f,
81.35f,
82.16f,
82.495f,
83.315f,
83.63f,
84.357f,
84.72f,
85.493f,
85.855f,
86.617f,
86.989f,
87.768f,
88.121f,
88.478f,
89.98f,
90.343f,
91.109f,
91.48f,
92.252f,
92.628f,
93.021f,
94.506f,
94.89f,
95.636f,
95.993f,
96.782f,
97.15f,
97.879f,
98.27f,
99.003f,
99.406f,
100.092f,
100.495f,
101.253f,
101.655f,
102.042f,
103.52f,
103.892f,
104.603f,
104.978f,
105.686f,
106.083f,
106.508f,
109.886f,
110.437f,
110.659f,
111.08f,





    };
    // Use this for initialization
    void Start ()
    {
        Chain = true;
        Clear.GetComponent<RectTransform>().anchoredPosition = new Vector2(1500, 170);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.isPause == true)
        {
            //timerに時間を加算させ続ける
            timer += Time.deltaTime;
            //if (timer >= 5 && (Chain))
            //{
            //   // GetComponent<AudioSource>().Play();
            //    //Chain = false;
            //}
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
            if (timer > 118)
            {
                Clear.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 170);
            }
            if (timer >= 120)
            {
                SceneManager.LoadScene("ClearScene");
            }

        }
    }
}

