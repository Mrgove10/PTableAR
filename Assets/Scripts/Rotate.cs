using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public GameObject pivotObject;

    public float speed = 15;
    private Vector3 pivotPos;

    void Start()
    {
        pivotPos = pivotObject.GetComponent<Transform>().position;
    }

    void FixedUpdate()
    {
        // Spin the object around the world origin at 20 degrees/second.
        transform.RotateAround(pivotPos, Vector3.up, speed * Time.deltaTime);
    }
}