using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMotion : MonoBehaviour
{
    public float modAmp, modFreq;

    private float xNow;
    Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        //modAmp = 2.5f;
        //modFreq = 0.2f;
    }

    // Update is called once per frame
    void Update()
    {
        // Change x position based on sin and time formula.
        xNow = modAmp * Mathf.Sin(2.0f * Mathf.PI * modFreq * Time.time);
        transform.position = startPos + new Vector3(xNow, 0, 0);
    }
}
