﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public Text scoreText;
    public Text hiscoreText;
    public float scoreCount;
    public float hiscoreCount;
    public float pointsPerSecond;
    public bool scoreIncreasing;
	// Use this for initialization
	void Start () {
		if (PlayerPrefs.HasKey("Highscore"))
        {
            hiscoreCount = PlayerPrefs.GetFloat("Highscore");
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (scoreIncreasing)
        {
            scoreCount += pointsPerSecond * Time.deltaTime;
        }
        if (scoreCount > hiscoreCount)
        {
            hiscoreCount = scoreCount;
            PlayerPrefs.SetFloat("Highscore", hiscoreCount);
        }
        scoreText.text = "Score : " + Mathf.Round (scoreCount);
        hiscoreText.text = "High Score : " + Mathf.Round(hiscoreCount);    
    }
}
