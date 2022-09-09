using System;
using UnityEngine.UIElements;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    private float Score;
    public Text scoreText;
    Vector2 StartPos;
    Vector2 CurPos;
    public Transform player;
    private float HiScore;
    void Start()
    {
        //Initialise the vector
        StartPos = new Vector2(player.position.x, player.position.y);
        CurPos = StartPos;
    }

    // Update is called once per frame
    void Update()
    {
        CurPos.x = player.position.x;
        Score = 50*Vector2.Distance(StartPos, CurPos);
        if (Score > HiScore)
        {
            HiScore = Score;
        }
        scoreText.text = HiScore.ToString("0");
    }
   
}
