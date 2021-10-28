using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class hpScript : MonoBehaviour
{

    public Slider slider;

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health; //Gör att start hp är max hp och att värdet på vårt hp alltid samma som slider.
    }

    public void SetHealth(int health)
    {
        slider.value = health;  //gör att när koden referar till detta så letar den up slidern och anpassar den efter hur mycket skada man tog eller hur mycket liv man fick tillbaka.
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
