﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    Text text;
    float theTime;
    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        theTime += Time.deltaTime * speed;
        string hours = Mathf.Floor((theTime % 216000)/3600).ToString("00");
        string minutes = Mathf.Floor((theTime % 3600)/60).ToString("00");
        string seconds = Mathf.Floor(theTime % 60).ToString("00");
    text.text = hours + ":" + minutes + ":" + seconds;
    }
}
