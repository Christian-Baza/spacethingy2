using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MilkShake;

public class spaceShup : MonoBehaviour
{
    public Text ScoreText;
    public enum Typ { Skepp, Alien, Skott, Bomb}
    public Typ typ;
    public GameObject[] prefabs;
    public GameObject[] punkteer;
    public int vapen = 0;
    public static int score = 0;
    public float max;
    public float timer = 0;
    Shaker shaker;
    public ShakePreset shakePreset;
    private float cooldown;
    private bool canShoot;
    // Start is called before the first frame update
    void Start()
    {
        shaker.Shake(shakePreset);
        cooldown = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        if(vapen == 0&&cooldown==0f) { canShoot = true; }
        else if (vapen == 2 && cooldown == 0f) { canShoot = true; }
        else { cooldown = cooldown - 1 * Time.deltaTime; }
        if (Input.GetKeyDown(KeyCode.E))
        {
            vapen++;
            if (vapen > 2)
            {
                vapen = 0;
            }
        }
        ScoreText.text = "Score: " + score;
        switch (typ)
        {
            case Typ.Skepp:
                if (Input.GetKeyUp(KeyCode.Space) && vapen == 0 && canShoot == true)
                {
                    print("bang");
                    Instantiate(prefabs[0], transform.position, Quaternion.identity).GetComponent<Rigidbody>().AddForce(0, 500, 0);
                }
                if (Input.GetKeyUp(KeyCode.Space) && vapen == 2&& canShoot == true)
                {
                    print("bang");
                    Instantiate(prefabs[1], transform.position, Quaternion.identity).GetComponent<Rigidbody>().AddForce(0, 500, 0);
                }
                int rng = Random.Range(0, 3);
                if (timer > 5)
                {
                    print("Ahh");
                    timer = 0;
                    Instantiate(prefabs[2], punkteer[rng].transform.position, Quaternion.identity).GetComponent<Rigidbody>().AddForce(0, -250, 0);
                }
                if (Input.GetKey(KeyCode.D))
                {
                    GetComponent<Rigidbody>().AddForce(500 * Time.deltaTime, 0, 0);
                }
                if (Input.GetKey(KeyCode.A))
                {
                    GetComponent<Rigidbody>().AddForce(-500 * Time.deltaTime, 0, 0);
                }
                if (transform.position.x > max)
                {
                    transform.position = new Vector3(-max, transform.position.y, 0);
                }
                if (transform.position.x < -max)
                {
                    transform.position = new Vector3(max, transform.position.y, 0);
                }
                timer += Time.deltaTime;
                break;
            case Typ.Alien:
                break;
            case Typ.Skott:
                break;
            case Typ.Bomb:
                timer += Time.deltaTime;
                if (timer > 3)
                {
                    GetComponent<SphereCollider>().radius = 4;
                    Destroy(gameObject);
                }
                break;
            default:
                break;
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch (typ)
        {
            case Typ.Skepp:
                if (collision.transform.gameObject.layer == 6)
                {
                    Destroy(gameObject);
                }
                break;
            case Typ.Alien:
                break;
            case Typ.Skott:
                break;
            case Typ.Bomb:
                break;
            default:
                break;
        }
    }
}
