using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SetScore : MonoBehaviour
{

    public TMP_Text scoreText;
    private short score = 0;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Knife"))
        {
            score++;
            scoreText.text = "Рахунок: " + score.ToString();

            if (PlayerPrefs.GetInt("score")< score)
            {
                PlayerPrefs.SetInt("score", score);
            }
           
        }
    }
}
