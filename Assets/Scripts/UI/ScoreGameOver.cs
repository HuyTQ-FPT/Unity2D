using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreGameOver : MonoBehaviour
{
    // Start is called before the first frame update
    int scoreGameOver;
    scoreManager sc;
    public Text scoreTxt;
    void Start()
    {
        sc = FindObjectOfType<scoreManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //scoreManager ri = GetComponent<scoreManager>();
        //Debug.Log(ri.getScore());
        //Debug.Log("day la "+ scoreGameOver);
        scoreTxt.text = "Score : " + PlayerPrefs.GetInt("score").ToString();
    }
}
