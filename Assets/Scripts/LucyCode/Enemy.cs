using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //baskoden f�r fienderna -Lucy
    public CityCode cityCode;
    public Vector3 lineStart;
    public GameObject deathEffect;
    public void Start()
     {
        cityCode = FindObjectOfType<CityCode>();// plockar City f�r CityCode -Lucy
        lineStart = transform.position;
        StartCoroutine(Move());// startar Move coroutinen - Lucy
        StartCoroutine(EnemyAtackTimer());
    }
    public virtual void CityHit()// metoden f�r n�r fienden tr�ffar staden -Lucy
    {
        CityDamage();
        Destroy(gameObject);
    }
    public virtual void EnemyAtack()// f�r n�r fienden sl�pper bomber -Lucy
    {

    }
    public virtual void CityDamage()// tom metod f�r att s�tta in m�ngden skad i -Lucy
    {

    }
    public virtual void EnemyDamage()//F�r n�r spelaren skadar fienden -Lucy
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    public virtual IEnumerator Move()// tom move coroutine f�r senare specifikation -Lucy
    {
        return null;
    }
    public virtual IEnumerator EnemyAtackTimer()// en timer som best�mer n�r fienden ska atakera -Lucy
    {
        int r = Random.Range(1, 2);
        yield return new WaitForSeconds(r);
        EnemyAtack();
        StartCoroutine(this.EnemyAtackTimer());
    }
    private void OnTriggerEnter2D(Collider2D other)// h�r finns interaktioner med de olicka kanterna -Lucy
    {
        if (other.tag == "Bullet")
        {
            EnemyDamage();
        }
        if (other.tag != "Wall")
        {
            transform.position = new Vector3(0, -2, 0) + lineStart;
            lineStart = transform.position;// H�r s� flyttas objectet ner en rad -Lucy
        }
        else if (other.tag == "City") { CityHit(); }// h�r s� triggas CityHit metoden -Lucy
    }
}
