using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using MilkShake;

public class GameManager : MonoBehaviour
{
    public int cityHealth = 100;
    public int score = 0;
    [SerializeField] TMP_Text scoreDisplay;
    string scoreText;
    [SerializeField] ShakePreset lightShake;
    [SerializeField] ShakePreset heavyShake;

    private hpScript hpScript;
    void Start()
    {
        hpScript = GetComponent<hpScript>();
        scoreText = scoreDisplay.text; // Best�mmer vad som ska st� innan po�ngen. -Chris
    }
    void Update()
    {
        hpScript.SetHealth(cityHealth);
        scoreDisplay.text = scoreText + score;
    }

    public void Shake(bool isLight) // Skakar sk�rmen n�r tillkallad, har 2 olika styrkor p� skakningen.
    {
        if (isLight == true)
        {
            Shaker.ShakeAll(lightShake);
        }
        else
        {
            Shaker.ShakeAll(heavyShake);
        }
    }
}
