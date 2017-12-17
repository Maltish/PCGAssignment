using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightScoreScript : MonoBehaviour
{
    LevelManager levelManager = new LevelManager();
    int maxGoals = 3;
    int rightGoal;
    public static int rightScore;
    public Text rightGoalText;
    // Use this for initialization
    void Start()
    {
        rightGoal = 0;
        rightGoalText.text = "Goal: " + rightGoal;
    }

    // Update is called once per frame
    void Update()
    {

        rightGoalText.text = "Goal: " + rightGoal;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        rightGoal++;
        
        if (levelManager.GetSceneName() == "level1")
        {
            rightScore++;
        }
        else if (levelManager.GetSceneName() == "level2")
        {
            rightScore = rightScore + 2;
        }
        else if (levelManager.GetSceneName() == "level3")
        {
            rightScore = rightScore + 3;
        }
        if(rightGoal>= maxGoals)
        {
            levelManager.LoadNextScene();
        }
    }
}
