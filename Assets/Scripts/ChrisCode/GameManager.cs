using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int cityHealth = 100;
    public int score = 0;
    [SerializeField] TMP_Text scoreDisplay;
    string scoreText;

    private hpScript hpScript;
    void Start()
    {
        hpScript = GetComponent<hpScript>();
        scoreText = scoreDisplay.text; // Bestämmer vad som ska stå innan poängen. -Chris
    }
    void Update()
    {
        hpScript.SetHealth(cityHealth);
        scoreDisplay.text = scoreText + score;
    }
}
