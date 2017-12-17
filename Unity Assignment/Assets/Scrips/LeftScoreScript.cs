using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeftScoreScript : MonoBehaviour
{
    LevelManager levelManager = new LevelManager();
    int maxGoals = 3;
    int leftGoal;
    public static int leftScore;
    public Text leftGoalText;
    // Use this for initialization
    void Start()
    {
        leftGoal = 0;
        leftGoalText.text = "Goal: " + leftGoal;
    }

    // Update is called once per frame
    void Update()
    {
        leftGoalText.text = "Goal: " + leftGoal;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        leftGoal++;
        if(levelManager.GetSceneName() == "level1")
        {
            leftScore++;
        }
        else if (levelManager.GetSceneName() == "level2")
        {
            leftScore = leftScore + 2;
        }
        else if (levelManager.GetSceneName() == "level3")
        {
            leftScore = leftScore + 3;
        }
        if (leftGoal >= maxGoals)
        {
            levelManager.LoadNextScene();
        }
    }
}
