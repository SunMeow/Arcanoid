﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Мячик столкнулся");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Мячик оттолкнулся");
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("Мячик соприкасается");
    }
}
