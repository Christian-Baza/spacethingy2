using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class hpScript : MonoBehaviour   //Wincent
{

    public Image slider;
    public float maxHP = 100;
    /*public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.fillAmount = health; //Gör att start hp är max hp och att värdet på vårt hp alltid samma som slider.
    }*/

    public void SetHealth(float health)
    {
        slider.fillAmount = (health/maxHP/*delar livet med högsta antalet hp för att få en förhållande mellan 0-1. */);  //gör att när koden referar till detta så letar den up slidern och anpassar den efter hur mycket skada man tog eller hur mycket liv man fick tillbaka.
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
