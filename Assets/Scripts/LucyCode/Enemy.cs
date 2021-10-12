using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //baskoden för fienderna -Lucy
    public CityCode cityCode;
    public Vector3 lineStart;
     public void Start()
     {
        cityCode = FindObjectOfType<CityCode>();// plockar City för CityCode -Lucy
        lineStart = transform.position;
        StartCoroutine(Move());// startar Move coroutinen - Lucy
    }
    public virtual void CityHit()// metoden för när fienden träffar staden -Lucy
    {
        CityDamage();
        Destroy(gameObject);
    }
    public virtual void EnemyAtack()
    {

    }
    public virtual void CityDamage()// tom metod för att sätta in mängden skad i -Lucy
    {

    }
    public virtual void EnemyDamage()
    {

    }
    public virtual IEnumerator Move()// tom move coroutine för senare specifikation -Lucy
    {
        return null;
    }
    private void OnTriggerEnter(Collider other)// här finns interaktioner med de olicka kanterna -Lucy
    {
        if (other.tag == "Wall")
        {
            transform.position = new Vector3(0, -2, 0) + lineStart;
            lineStart = transform.position;// Här så flyttas objectet ner en rad -Lucy
        }
        else if (other.tag == "City") { CityHit(); }// här så triggas CityHit metoden -Lucy
    }
}
