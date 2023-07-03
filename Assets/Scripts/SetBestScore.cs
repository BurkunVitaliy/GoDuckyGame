
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SetBestScore : MonoBehaviour
{
    private TMP_Text scoreText;

    private void Awake()
    {
        GetComponent<TMP_Text>().text = "Рекорд: " + PlayerPrefs.GetInt("score").ToString();
    }
}
