using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityCode : MonoBehaviour
{//kåden fför staden -Lucy
    public int cityHealth;
    static int citySpriteHealth;
    public Animator city;
    private void Start()
    {
        cityHealth = 100;
    }
    private void FixedUpdate()
    {
        if( cityHealth == 0)
        {
            print("Game Over");
            citySpriteHealth = cityHealth;
            city.SetInteger("animHealth",citySpriteHealth);
        }
    }
}
