using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //baskoden f�r fienderna -Lucy
    public GameManager gameManager;
    public Vector3 lineStart;
    public GameObject deathEffect;
    public GameObject smokeEffect;
    public GameObject cityDamagefx;
    SpriteRenderer spriteRenderer;
    public Material flashMat;
    Material oldMat;
    public int health = 4;
    public virtual void Start()
     {
        gameManager = FindObjectOfType<GameManager>();// plockar City f�r CityCode -Lucy
        spriteRenderer = GetComponent<SpriteRenderer>();
        oldMat = spriteRenderer.material;
        lineStart = transform.position;
        StartCoroutine(Move());// startar Move coroutinen - Lucy
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
        gameManager.cityHealth -= 5;
        Instantiate(cityDamagefx, transform.position, Quaternion.identity);
        EnemyDeath();
    }
    public virtual void EnemyDamage()//F�r n�r spelaren skadar fienden -Lucy
    {
        health--;
        StartCoroutine(damageFlash());
        if (health <= 0)
        {
            EnemyDeath();
        }
    }
    public virtual void EnemyDeath() //F�r n�r spelaren d�dar fienden -Chris
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        gameManager.score++;
    }
    public virtual IEnumerator Move()// tom move coroutine f�r senare specifikation -Lucy
    {
        return null;
    }
    public virtual IEnumerator EnemyAtackTimer(int attackInterval)// en timer som best�mer n�r fienden ska atakera -Lucy
    {
        int r = Random.Range(1, attackInterval);
        yield return new WaitForSeconds(r);
        EnemyAtack();
        StartCoroutine(this.EnemyAtackTimer(attackInterval));
    }
    private void OnTriggerEnter2D(Collider2D other)// h�r finns interaktioner med de olicka kanterna -Lucy
    {
        print(other);
        print(other.gameObject.tag);
        if (other.gameObject.tag == "City") 
        {
            CityHit();
        }// h�r s� triggas CityHit metoden -Lucy
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<playerMovement>() != null) //Ifall att en fiende g�r in i spelaren blir spelaren stunned. -Chris
        {
            playerMovement player;
            player = collision.gameObject.GetComponent<playerMovement>();
            player.StartCoroutine(player.Stun(0.25f));
        }
    }
    public virtual void Update()
    {
        if (transform.position.x > 2.96)
        {
            transform.position = new Vector3(0, -2, 0) + lineStart;
            lineStart = transform.position;// H�r s� flyttas objectet ner en rad -Lucy
        }
    }
    public IEnumerator damageFlash()// Coroutine f�r n�r Fiendne tar skada. -Chris
    {
        Instantiate(smokeEffect, transform.position, Quaternion.identity);
        spriteRenderer.material = flashMat; // �ndrar materialet av fienden s� att den blir hel r�d. -Chris
        yield return new WaitForSeconds(.25f);
        spriteRenderer.material = oldMat;
    }
}
