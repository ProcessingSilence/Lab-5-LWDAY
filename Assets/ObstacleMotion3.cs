using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMotion3 : MonoBehaviour
{
    public float modAmp, modFreq;

    private float xNow, zNow;

    private Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        xNow = modAmp * Mathf.Sin(2.0f * Mathf.PI * modFreq * Time.time);
        zNow = modAmp * Mathf.Cos(2.0f * Mathf.PI * modFreq * Time.time);
        transform.position = startPos + new Vector3(xNow, 0, zNow);
    }

    // Update is called once per frame
    void Update()
    {
        xNow = modAmp * Mathf.Sin(2.0f * Mathf.PI * modFreq * Time.time);
        zNow = modAmp * Mathf.Cos(2.0f * Mathf.PI * modFreq * Time.time);
        transform.position = startPos + new Vector3(xNow, 0, zNow);
    }
}
