using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2PaddleScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 newPaddlePos = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);

        if (Input.GetKey("up"))
        {
            print("up arrow key pressed");
            newPaddlePos.y += 0.2f;
            newPaddlePos.y = Mathf.Clamp(newPaddlePos.y, -5f, 5f);
            this.transform.position = newPaddlePos;
        }
        else if (Input.GetKey("down"))
        {
            newPaddlePos.y -= 0.2f;
            newPaddlePos.y = Mathf.Clamp(newPaddlePos.y, -5f, 5f);
            this.transform.position = newPaddlePos;

        }
    }
}

