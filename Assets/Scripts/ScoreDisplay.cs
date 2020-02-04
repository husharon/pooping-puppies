using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ScoreDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    private string welcomeMsg = "Welcome to Poopy Puppy\n Poop on the bushes marked X and get points!";
    private float timeLeft = 60f;
    private int score = 0;
    private GameObject[] targets;
    void Start()
    {
        targets = GameObject.FindGameObjectsWithTag("Target");
    }
    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 500, 40), welcomeMsg);
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
        Debug.Log("Target Score" + targetScore);
        score += targetScore;
        Debug.Log("Score" + score);
    }
    void Update()
    {
        checkWin();
        timeLeft -= Time.deltaTime;
    }
    void checkWin()
    {
        bool completed = true;
        foreach(GameObject temp in targets)
        {
            if (!temp.GetComponent<Target>().poopedOn)
            {
                completed = false;
            }
        }
        if (completed)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
