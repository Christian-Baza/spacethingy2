using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float MoveSpeed = -75f;
    public float BulletLifetime = 1f;
    public bool IsEnemyBullet;
    Vector3 ShootDirection;
    //private Rigidbody2D rb2d;
    public void BulletSetup(Vector3 ShootDirection) //När skottet ska skapas hämtas riktningen och roterar objectet så att den passar. -Chris
    {
        this.ShootDirection = ShootDirection;
        transform.up = ShootDirection;
        Destroy(gameObject, BulletLifetime); //Tar sönder objektet efter en viss tid, -Chris
    }

    void Update()
    {
        transform.position += ShootDirection * MoveSpeed * Time.deltaTime; //Rör skottet åt det hållet den kollar. -Chris
    }   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<playerMovement>() != null && IsEnemyBullet == true) //Ifall att ett fiende skott går in i spelaren blir spelaren stunned. -Chris
        {
            playerMovement player;
            player = collision.GetComponent<playerMovement>();
            player.StartCoroutine(player.Stun(0.25f));
            Destroy(gameObject);
        }
        if (collision.GetComponent<Enemy>() != null && IsEnemyBullet == false)
        {
            collision.GetComponent<Enemy>().EnemyDamage();
            Destroy(gameObject);
        }
        /*if (collision.GetComponent<Orb>() != null)
        {
            collision.GetComponent<Orb>().Hit();
            Destroy(gameObject);
        }
        else if (collision.GetComponent<BoatScript>() != null && IsEnemyBullet == true)
        {
            collision.GetComponent<BoatScript>().Death();
            Destroy(gameObject);
        }
        else if (collision.GetComponent<BoatScript>() != null && IsEnemyBullet == false)
        {
        }
        else
        {
            Destroy(gameObject);
        }*/
    }
}