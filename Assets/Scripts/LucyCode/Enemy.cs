using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //baskoden f�r fienderna -Lucy
    public CityCode cityCode;
    public Vector3 lineStart;
     public void Start()
     {
        cityCode = FindObjectOfType<CityCode>();// plockar City f�r CityCode -Lucy
        lineStart = transform.position;
        StartCoroutine(Move());// startar Move coroutinen - Lucy
    }
    public virtual void CityHit()// metoden f�r n�r fienden tr�ffar staden -Lucy
    {
        CityDameag();
        Destroy(gameObject);
    }
    public virtual void CityDameag()// tom metod f�r att s�tta in m�ngden skad i -Lucy
    {

    }
    public virtual IEnumerator Move()// tom move coroutine f�r senare specifikation -Lucy
    {
        return null;
    }
    private void OnTriggerEnter(Collider other)// h�r finns interaktioner med de olicka kanterna -Lucy
    {
        if (other.tag == "Wall")
        {
            transform.position = new Vector3(0, -2, 0) + lineStart;
            lineStart = transform.position;// H�r s� flyttas objectet ner en rad -Lucy
        }
        else if (other.tag == "City") { CityHit(); }// h�r s� triggas CityHit metoden -Lucy
    }
}
