using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillar_spawner : MonoBehaviour
{
    [SerializeField]
    GameObject pillar;
    [SerializeField]
    float gapHeight;

    float time;
    [SerializeField]
    float delay;
    [SerializeField]
    float top, bottom;

    private void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(time > delay)
        {
            time = 0;
            GameObject a = Instantiate(pillar);
            GameObject b = Instantiate(pillar);
            float gapPos = Random.Range(top - gapHeight / 2, bottom + gapHeight / 2);
            float gapTop = gapPos + gapHeight / 2;
            float gapBottom = gapPos - gapHeight / 2;
            a.transform.position = new Vector3(12, (top + gapTop) / 2);
            b.transform.position = new Vector3(12, (bottom + gapBottom) / 2);
            a.transform.localScale = new Vector3(1, top - gapTop);
            b.transform.localScale = new Vector3(1, bottom - gapBottom);
        }
        time += Time.deltaTime;
    }
}
