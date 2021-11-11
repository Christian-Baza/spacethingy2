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
        scoreText = scoreDisplay.text; // Bestämmer vad som ska stå innan poängen. -Chris
        Time.timeScale = 0;
        Instruktions = GameObject.Find("Intrudoktion");
    }
    void Update()
    {
        hpScript.SetHealth(cityHealth);
        scoreDisplay.text = scoreText + score;
        if (Input.anyKey)// Sätter igång spelet -Lucy
        {
            Instruktions.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void Shake(bool isLight) // Skakar skärmen när tillkallad, har 2 olika styrkor på skakningen.
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
