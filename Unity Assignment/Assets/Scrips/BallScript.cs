using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

    
    bool gameStart = false;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x >= 11f)
        {
            this.transform.position = new Vector3(0f, 0f, -2f);
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
            gameStart = false;
        }

        if (this.transform.position.x <= -11f)
        {
            this.transform.position = new Vector3(0f, 0f, -2f);
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
            gameStart = false;
        }

        if (Input.GetMouseButtonDown(0) && !gameStart)
        {
            gameStart = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(4f, 10f);
        }
    }
}
