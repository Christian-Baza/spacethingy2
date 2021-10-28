using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityCode : MonoBehaviour
{//kåden fför staden -Lucy
    public int cityHealth;
    static int citySpriteHealth;
    public Animator city;
    public Animator city1;
    public Animator city2;
    private void Start()
    {
        cityHealth = 100;
        citySpriteHealth = cityHealth;
        city.SetInteger("animHealth", citySpriteHealth);
        city1.SetInteger("animHealth", citySpriteHealth);
        city2.SetInteger("animHealth", citySpriteHealth);
    }
    private void FixedUpdate()
    {
        if( cityHealth == 0)
        {
            print("Game Over");

        }
        citySpriteHealth = cityHealth;
        city.SetInteger("animHealth",citySpriteHealth);
        city1.SetInteger("animHealth",citySpriteHealth);
        city2.SetInteger("animHealth",citySpriteHealth);
    }
}
