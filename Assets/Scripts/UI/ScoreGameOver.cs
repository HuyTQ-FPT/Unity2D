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
    string test = "abc";
    int check = 0;
    void Start()
    {
        sc = FindObjectOfType<scoreManager>();
        check = 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        //scoreManager ri = GetComponent<scoreManager>();
        //Debug.Log(ri.getScore());
        //Debug.Log("day la "+ scoreGameOver);
        scoreTxt.text= "Score : " + PlayerPrefs.GetInt("score").ToString();
    }
}
