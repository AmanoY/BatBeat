﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NotesGenerator2 : MonoBehaviour
{

    float timer = 0.0f;

    int timeCount = 0;
    public RectTransform clear;

    NotesGenerator difficulty;
    public SceneChange sceneChange;
    public GameObject notesPrefab;

    public float[] timingNormal = {
2.2f,
2.6f,
3f,
3.5f,
3.8f,
4.5f,
5f,
5.5f,
6f,
6.2f,
6.9f,
7.4f,
7.8f,
8.4f,
8.7f,
9.4f,
9.6f,
10f,
10.3f,
10.6f,
10.9f,
11.2f,
11.4f,
11.8f,
12.1f,
12.3f,
12.4f,
12.7f,
12.8f,
13f,
13.2f,
13.4f,
14.1f,
14.4f,
14.6f,
14.7f,
15f,
15.2f,
15.4f,
15.6f,
15.9f,
16.6f,
16.8f,
17f,
17.2f,
17.4f,
17.6f,
17.8f,
18f,
18.2f,
18.6f,
18.9f,
19.4f,
19.9f,
20.4f,
20.7f,
21.3f,
21.6f,
21.8f,
22f,
22.3f,
22.5f,
22.6f,
22.8f,
23.1f,
23.7f,
24f,
24.2f,
24.4f,
24.7f,
24.9f,
25f,
25.2f,
25.4f,
25.8f,
26.2f,
26.6f,
27.1f,
27.4f,
27.8f,
28.2f,
28.6f,
28.9f,
29f,
29.2f,
29.5f,
29.6f,
29.8f,
30f,
30.3f,
30.9f,
31.3f,
31.4f,
31.6f,
31.9f,
32f,
32.2f,
32.4f,
32.7f,
33.3f,
33.7f,
33.8f,
34f,
34.3f,
34.5f,
34.6f,
34.8f,
35.1f,
35.4f,
35.7f,
36.2f,
36.9f,
38.2f,
38.4f,
38.6f,
38.8f,
39.1f,
39.2f,
39.4f,
39.6f,
39.8f,
40.2f,
40.6f,
41f,
41.5f,
41.8f,
42.2f,
42.7f,
43f,
43.3f,
43.6f,
43.8f,
44.1f,
44.6f,
45f,
45.3f,
45.6f,
45.9f,
46.2f,
46.5f,
46.8f,
47f,
47.4f,
47.8f,
48.2f,
48.9f,
49.4f,
49.8f,
50.1f,
50.4f,
50.7f,
50.9f,
51.2f,
51.5f,
51.8f,
52.1f,
52.5f,
53.4f,
53.5f,
53.8f,
54f,
54.3f,
54.6f,
54.8f,
55.2f,
55.5f,
55.9f,
56f,
56.2f,
56.5f,
56.8f,
57f,
57.2f,
57.6f,
57.9f,
58.2f,
58.6f,
58.9f,
59.1f,
59.5f,
59.8f,
60f,
60.3f,
60.6f,
61f,
61.2f,
61.5f,
61.8f,
62.1f,
62.4f,
62.8f,
63f,
63.2f,
63.4f,
63.7f,
64f,
64.2f,
64.4f,
64.8f,
65.1f,
65.5f,
65.7f,
65.8f,
66.1f,
66.4f,
66.6f,
66.8f,
67.2f,
67.5f,
67.8f,
68f,
68.2f,
68.5f,
68.8f,
69f,
69.3f,
69.6f,
69.9f,
70.2f,
70.5f,
70.8f,
71.1f,
71.4f,
71.7f,
72.1f,
72.4f,
72.7f,
73f,
73.4f,
73.9f,
74.4f,
74.7f,
75.3f,
75.8f,
76.2f,
76.7f,
77f,
77.6f,
78.2f,
78.7f,
79.1f,
79.3f,
79.6f,
80.1f,
80.4f,
80.8f,
81.1f,
81.4f,
81.7f,
82f,
82.3f,
82.6f,

    };


    // Use this for initialization
    void Start()
    {
        sceneChange = GameObject.FindObjectOfType<SceneChange>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.isPause == true)
        {
            timer += Time.deltaTime;
            //NormalのNotesを呼び出す
            if (GameData.DifficultyChange == 1)
            {
                //EasyのNotesを呼び出す
                for (timeCount = 0; timeCount < timingNormal.Length - 1; timeCount++)
                {

                    if (timingNormal[timeCount] >= timer - Time.deltaTime / 2.0f && timingNormal[timeCount] <= timer + Time.deltaTime / 2.0f)
                    {
                        GameObject go = Instantiate(notesPrefab);
                    }

                }
            }
            if (timer > 88)
            {
                clear.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 170);
            }
            if (timer >= 90)
            {
                SceneManager.LoadScene("ClearScene");
            }

        }
    }
}
