using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //baskoden för fienderna -Lucy
    public GameManager gameManager;
    public Vector3 lineStart;
    public GameObject deathEffect;
    public virtual void Start()
     {
        gameManager = FindObjectOfType<GameManager>();// plockar City för CityCode -Lucy
        lineStart = transform.position;
        StartCoroutine(Move());// startar Move coroutinen - Lucy
    }
    public virtual void CityHit()// metoden för när fienden träffar staden -Lucy
    {
        CityDamage();
        Destroy(gameObject);
    }
    public virtual void EnemyAtack()// för när fienden släpper bomber -Lucy
    {

    }
    public virtual void CityDamage()// tom metod för att sätta in mängden skad i -Lucy
    {

    }
    public virtual void EnemyDamage()//För när spelaren skadar fienden -Lucy
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    public virtual IEnumerator Move()// tom move coroutine för senare specifikation -Lucy
    {
        return null;
    }
    public virtual IEnumerator EnemyAtackTimer(int attackInterval)// en timer som bestämer när fienden ska atakera -Lucy
    {
        int r = Random.Range(1, attackInterval);
        yield return new WaitForSeconds(r);
        EnemyAtack();
        StartCoroutine(this.EnemyAtackTimer(attackInterval));
    }
    private void OnTriggerEnter2D(Collider2D other)// här finns interaktioner med de olicka kanterna -Lucy
    {
        print(other);
        print(other.gameObject.tag);
        if (other.gameObject.tag == "Bullet")
        {
            EnemyDamage();
        }
        else if (other.gameObject.tag == "City") { CityHit(); }// här så triggas CityHit metoden -Lucy
    }
    public virtual void Update()
    {
        if (transform.position.x > 2.96)
        {
            transform.position = new Vector3(0, -2, 0) + lineStart;
            lineStart = transform.position;// Här så flyttas objectet ner en rad -Lucy
        }
    }

}
