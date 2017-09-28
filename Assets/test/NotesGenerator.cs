using UnityEngine;
using System.Collections;

public class NotesGenerator : MonoBehaviour
{
    float timer = 0.0f;

    int timeCount = 0;

    //Notesを発生させる時間
    public float[] timingEasy =
    {
4.5f,
6.8f,
9.2f,
11.6f,
14.1f,
14.5f,
14.9f,
16.4f,
16.9f,
17.3f,
18.8f,
19.3f,
19.7f,
21.2f,
21.7f,
22.1f,
23.6f,
24.1f,
24.5f,
26f,
26.5f,
27.2f,
27.7f,
28.4f,
28.9f,
29.3f,
30.8f,
31.3f,
31.7f,
33.2f,
33.7f,
34.1f,
35.6f,
36.1f,
36.5f,
38f,
38.5f,
38.9f,
40.4f,
40.9f,
41.6f,
42.1f,
42.5f,
42.9f,
43.3f,
43.7f,
45.2f,
45.7f,
46.1f,
47.6f,
48.1f,
48.5f,
48.8f,
49.3f,
49.7f,
50f,
53.6f,
54.2f,
54.9f,
55.5f,
56.1f,
56.7f,
57.2f,
57.8f,
58.4f,
59f,
60.8f,
61.4f,
62f,
62.6f,
63.2f,
63.8f,
64.4f,
65f,
65.6f,
66.2f,
66.8f,
67.4f,
68.1f,
68.6f,
69.2f,
69.8f,
70.4f,
71f,
71.6f,
72.2f,
72.8f,
75.2f,
77.6f,
80f,
82.4f,
    };
    public GameObject notesPrefab;
    // NotesControl1 Notes;


    // Update is called once per frame
    void Update()
    {
        //timerに時間を加算させ続ける
        timer += Time.deltaTime;
        if (GameData.DifficultyChange == 0)
        {
            //EasyのNotesを呼び出す
            for (timeCount = 0; timeCount < timingEasy.Length - 1; timeCount++)
            {

                if (timingEasy[timeCount] >= timer - Time.deltaTime / 2 && timingEasy[timeCount] <= timer + Time.deltaTime / 2)
                {

                    GameObject go = Instantiate(notesPrefab);
                }

            }
        }
    }

}
