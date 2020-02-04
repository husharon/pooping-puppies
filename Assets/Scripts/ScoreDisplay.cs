using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    private string welcomeMsg = "Welcome to Poopy Puppy\n Poop on the bushes marked X and get points!";
    private float timeLeft = 60f;
    private int score;
    void Start()
    {
        score = 0;
    }
    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 500, 40), welcomeMsg);
        GUI.Label(new Rect(10, 60, 500, 40), ScoreString());
        GUI.Label(new Rect(10, 110, 500, 40), TimeLeft());
    }
    // Update is called once per frame
    private string ScoreString()
    {
        
        return "Score: " + score;
    }
    private string TimeLeft()
    {
        return "Time: " + (int)timeLeft + " secs";
    }
    public void addScore(int targetScore)
    {
        score += targetScore;
    }
    void Update()
    {
        timeLeft -= Time.deltaTime;
    }
}
