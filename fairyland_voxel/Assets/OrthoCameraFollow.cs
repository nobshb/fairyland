using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrthoCameraFollow : MonoBehaviour {

    public Transform target;
    public float smoothTime = 0.125f;

    private Vector3 velocity = Vector3.zero;
    public Vector3 offset;


    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 goalPos = target.position;
        goalPos.y = transform.position.y;
        transform.position = Vector3.SmoothDamp(transform.position, goalPos, ref velocity, smoothTime);
        //transform.LookAt(target);
    }
}