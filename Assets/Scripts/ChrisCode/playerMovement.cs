using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//playerMovement kräver att spelobjektet ska en Rigidody2D komponent -Christian
[RequireComponent(typeof(Rigidbody2D))]
public class playerMovement : MonoBehaviour
{
    Rigidbody2D rb2d;
    Animator animator;
    public int speed = 750;
    public Transform BulletPrefab;
    public Transform GunPoint;
    public float GunCooldown = 0.2f;
    float NextShot;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>(); // Hämtar komponenten -Chris
        animator = GetComponentInChildren<Animator>();
    }
    void Update()
    {
        animator.SetFloat("Horizontal", Input.GetAxisRaw("Horizontal")); // Ger inputen till animatören. -Chris
        // Rör sig vänster och höger med hjälp av AddForce. -Chris
        if (Input.GetAxisRaw("Horizontal") >= 1)
        {
            rb2d.AddForce(new Vector2(speed * Time.deltaTime, 0));
        }
        if (Input.GetAxisRaw("Horizontal") <= -1) 
        {
            rb2d.AddForce(new Vector2(-speed * Time.deltaTime, 0));
        }
        // Rör sig upp och ner. -Chris
        if (Input.GetAxisRaw("Vertical") >= 1)
        {
            rb2d.AddForce(new Vector2(0, speed/2 * Time.deltaTime));
        }
        if (Input.GetAxisRaw("Vertical") <= -1)
        {
            rb2d.AddForce(new Vector2(0, -speed/2 * Time.deltaTime));
        }

        if (Input.GetButtonDown("Jump") && Time.time > NextShot) // Spelaren kan bara skjuta om det har gått en viss tid. -Chris
        {
            NextShot = Time.time + GunCooldown; // Återställer timern för GunCooldown. -Chris
            Transform Bullet = Instantiate(BulletPrefab, GunPoint.position, Quaternion.identity);
            Vector3 ShootDirection = Vector3.down; // Sätter riktningen av skottet. -Chris
            Bullet.GetComponent<bullet>().BulletSetup(ShootDirection); 
        }
    }
}
