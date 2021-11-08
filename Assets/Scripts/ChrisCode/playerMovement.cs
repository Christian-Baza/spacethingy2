using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//playerMovement kr�ver att spelobjektet ska en Rigidody2D komponent -Christian
[RequireComponent(typeof(Rigidbody2D))]
public class playerMovement : MonoBehaviour
{
    Rigidbody2D rb2d;
    Animator animator;
    SpriteRenderer spriteRenderer;
    public int speed = 750;

    public Transform BulletPrefab;
    public Transform GunPoint;
    public float GunCooldown = 0.2f;
    float NextShot;

    [SerializeField] bool stunned = false;
    [SerializeField] Material flashMat;
    [SerializeField] GameObject smokeEffect;
    Material oldMat;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>(); // H�mtar komponenten -Chris
        animator = GetComponentInChildren<Animator>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        oldMat = spriteRenderer.material; // Best�mmer vad original materialet �r. -Chris
    }
    void Update()
    {
        animator.SetFloat("Horizontal", Input.GetAxisRaw("Horizontal")); // Ger inputen till animat�ren. -Chris
        // R�r sig v�nster och h�ger med hj�lp av AddForce. -Chris
        
        if (Input.GetAxisRaw("Horizontal") >= 1)
        {
            rb2d.AddForce(new Vector2(speed * Time.deltaTime, 0));
        }
        if (Input.GetAxisRaw("Horizontal") <= -1)
        {
            rb2d.AddForce(new Vector2(-speed * Time.deltaTime, 0));
        }
        // R�r sig upp och ner. -Chris
        if (Input.GetAxisRaw("Vertical") >= 1)
        {
            rb2d.AddForce(new Vector2(0, speed / 2 * Time.deltaTime));
        }
        if (Input.GetAxisRaw("Vertical") <= -1)
        {
            rb2d.AddForce(new Vector2(0, -speed / 2 * Time.deltaTime));
        }
        
        if (Input.GetButton("Jump") && Time.time > NextShot) // Spelaren kan bara skjuta om det har g�tt en viss tid. -Chris
        {
            NextShot = Time.time + GunCooldown; // �terst�ller timern f�r GunCooldown. -Chris
            Transform Bullet = Instantiate(BulletPrefab, GunPoint.position, Quaternion.identity);
            Vector3 ShootDirection = Vector3.down; // S�tter riktningen av skottet. -Chris
            Bullet.GetComponent<bullet>().BulletSetup(ShootDirection);
        }
    }
    public IEnumerator Stun(float stunTime)// Coroutine f�r n�r spelaren tar skada. -Chris
    {
        Instantiate(smokeEffect, spriteRenderer.gameObject.transform.position, Quaternion.identity); // Skapar r�k effekten d�r spelarens sprite �r. -Chris
        spriteRenderer.material = flashMat; // �ndrar materialet av spelaren s� att den blir hel vit. -Chris
        rb2d.constraints = RigidbodyConstraints2D.FreezeAll;
        yield return new WaitForSeconds(stunTime);
        rb2d.constraints = RigidbodyConstraints2D.FreezeRotation;
        spriteRenderer.material = oldMat;
    }
}