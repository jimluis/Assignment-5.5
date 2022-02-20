﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscilator : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Movement Parameters")]
    public Vector3 movementAxis;
    public float movementSpeed;
    public float movementDistance;

    [Header("Movement Position")]
    public Vector3 startingPosition;
    public Vector3 posEnd;
    public Vector3 negEnd;

    private Vector3 direction;

    void Start()
    {
        //the direction of movement
        direction = movementAxis.normalized;

        //precompute positions
        startingPosition = transform.position;
        posEnd = transform.position + (direction * movementDistance);
        negEnd = transform.position - (direction * movementDistance);

    }


    // Update is called once per frame
    void FixedUpdate()
    {
        // if we reach the bounds of the movement, reverse the direction vector
        if (Vector3.Distance(transform.position, posEnd) < 0.01f || Vector3.Distance(transform.position, negEnd) < 0.01f)
            direction *= -1;

        //move the platform
        //Delta time is the amount it takes from one frame to another
        transform.Translate(direction * movementSpeed * Time.deltaTime);//
    }
}
