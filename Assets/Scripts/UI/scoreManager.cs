using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static scoreManager instance;
    public Text scoreText;
    public Text highscoreText;
    int score = 0;
    int highscore = 0;

    public void Awake()
    {
        instance = this;
    }
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = score.ToString() + " POINTS";
        highscoreText.text = "HIGHSCORE: " + highscore.ToString();
        PlayerPrefs.SetInt("score", score);
    }

    public void AddPoint()
    {
        score += 1;
        if (highscore < score)
        {
            PlayerPrefs.SetInt("highscore", score);
            //score2 = score;
            //PlayerPrefs.SetInt("score", score2);
            //scoreText.text = highscore.ToString() + " POINTS";
        }
        PlayerPrefs.SetInt("score", score);
        scoreText.text = score.ToString() + " POINTS";
    }

    // Update is called once per frame
    void Update()
    {

    }
}