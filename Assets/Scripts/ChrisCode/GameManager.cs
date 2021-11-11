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
    [SerializeField] GameObject Instruktions;
    private hpScript hpScript;
    void Start()
    {
        hpScript = GetComponent<hpScript>();
        scoreText = scoreDisplay.text; // Best�mmer vad som ska st� innan po�ngen. -Chris
        Time.timeScale = 0;
        Instruktions = GameObject.Find("Intrudoktion");
    }
    void Update()
    {
        hpScript.SetHealth(cityHealth);
        scoreDisplay.text = scoreText + score;
        if (Input.anyKey)// S�tter ig�ng spelet -Lucy
        {
            Instruktions.SetActive(false);
            Time.timeScale = 1;
        }
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
