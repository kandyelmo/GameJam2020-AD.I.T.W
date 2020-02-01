﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sounds : MonoBehaviour
{
    public AudioClip musicPresent;
    public AudioClip musicPast;
    public AudioClip chamberPresent;
    public AudioClip chamberPast;
    public AudioClip walkPresent;
    public AudioClip walkPast;
    public AudioClip landing;
    public AudioClip wind;
    public AudioClip pastAmbience;
    public AudioClip itemCollect;
    public AudioClip puzzleComplete;
    public AudioClip repairedLand;
    public GameObject player;
    public Rigidbody rb;
    public float tState;
    // Start is called before the first frame update
    void Start()
    {
        tState = player.gameObject.GetComponent<PlayerController>().CurrentTimePhase;
        StartCoroutine(music());
    }

    // Update is called once per frame
    void Update()
    {
        tState = player.gameObject.GetComponent<PlayerController>().CurrentTimePhase;
    }

    IEnumerator music()
    {
        while (true)
        {
            switch (tState)
            {
                case 0:
                    //musicPresent
                    break;
                case 1:
                    //music2
                    break;
                case 2:
                    //music3
                    break;

            }
        }
        yield return null;
    }

}