using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScoreScript : MonoBehaviour {

    // Use this for initialization
    public Text finalScore;
	void Start () {
		if(LeftScoreScript.leftScore > RightScoreScript.rightScore)
        {
            finalScore.text = "Player 2 Wins with a score of: "+LeftScoreScript.leftScore; 
        }
        if (LeftScoreScript.leftScore < RightScoreScript.rightScore)
        {
            finalScore.text = "Player 1 Wins!" + LeftScoreScript.leftScore;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
