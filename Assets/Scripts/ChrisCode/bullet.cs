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
    public void BulletSetup(Vector3 ShootDirection) //N�r skottet ska skapas h�mtas riktningen och roterar objectet s� att den passar. -Chris
    {
        this.ShootDirection = ShootDirection;
        transform.up = ShootDirection;
        Destroy(gameObject, BulletLifetime); //Tar s�nder objektet efter en viss tid, -Chris
    }

    void Update()
    {
        transform.position += ShootDirection * MoveSpeed * Time.deltaTime; //R�r skottet �t det h�llet den kollar. -Chris
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
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