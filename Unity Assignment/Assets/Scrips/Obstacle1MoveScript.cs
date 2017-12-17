using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle1MoveScript : MonoBehaviour {

    // Use this for initialization
    public float min;
    public float max;
    void Start () {

        min = transform.position.y;
        max = transform.position.y - 2;

    }

    // Update is called once per frame
    void Update () {
        transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time * 2, min - max) +max, transform.position.z);
    }
}
