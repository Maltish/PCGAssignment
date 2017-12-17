using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1PaddleScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float mousePos = (Input.mousePosition.y / Screen.height * 12) - 6;

        Vector3 newPaddlePos = new Vector3(this.transform.position.x, mousePos, this.transform.position.z);

        newPaddlePos.y = Mathf.Clamp(mousePos, -5f, 5f);

        this.transform.position = newPaddlePos;
    }
}
