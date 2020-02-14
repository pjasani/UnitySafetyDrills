﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookWalk : MonoBehaviour
{

    public Transform Camera;
    public float toggleAngle = 30.0f;
    public float speed = 3.0f;
    public bool move;

    private CharacterController cc;

    // Use this for initialization
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Camera.eulerAngles.x >= toggleAngle && Camera.eulerAngles.x < 90.0f)
        {
            move = true;
        }
        else
        {
            move = false;
        }

        if (move)
        {
            Vector3 forward = Camera.TransformDirection(Vector3.forward);
            cc.SimpleMove(forward * speed);
        }
    }
}