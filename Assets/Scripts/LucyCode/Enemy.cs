using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //baskoden f�r fienderna -Lucy
    public CityCode cityCode;
    private void OnTriggerEnter(Collider other)
    {
        if( other.tag == "City")
        {
            CityDameag();
        }
    }
    public virtual void CityDameag()
    {

    }
}
