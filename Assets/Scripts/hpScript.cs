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
        slider.fillAmount = health; //G�r att start hp �r max hp och att v�rdet p� v�rt hp alltid samma som slider.
    }*/

    public void SetHealth(float health)
    {
        slider.fillAmount = (health/maxHP/*delar livet med h�gsta antalet hp f�r att f� en f�rh�llande mellan 0-1. */);  //g�r att n�r koden referar till detta s� letar den up slidern och anpassar den efter hur mycket skada man tog eller hur mycket liv man fick tillbaka.
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
