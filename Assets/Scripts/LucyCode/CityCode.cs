using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityCode : MonoBehaviour
{//k�den ff�r staden -Lucy
    public int cityHealth;
    private void Start()
    {
        cityHealth = 100;  
    }
    private void Update()
    {
        if( cityHealth == 0)
        {
            print("Game Over");
        }
    }
}
