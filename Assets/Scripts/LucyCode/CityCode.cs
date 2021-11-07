using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityCode : MonoBehaviour
{//kåden fför staden -Lucy
    public int cityHealth;
    static int citySpriteHealth;
    public Animator city;
    public Animator city1;
    public Animator city2;

    public GameObject gameOverOverlay;
    private void Start()
    {
        cityHealth = 100;
        citySpriteHealth = cityHealth;
        city.SetInteger("animHealth", citySpriteHealth);
        city1.SetInteger("animHealth", citySpriteHealth);
        city2.SetInteger("animHealth", citySpriteHealth);
    }
    private void Update()
    {
        if(cityHealth <= 0 && Time.timeScale > 0) //När staden har mindre än 0 hp stannas allt och Game Over Overlayen visas. -Chris
        {
            print("Game Over");
            Time.timeScale = 0;
            gameOverOverlay.SetActive(true);
        }
        citySpriteHealth = cityHealth;
        city.SetInteger("animHealth",citySpriteHealth);
        city1.SetInteger("animHealth",citySpriteHealth);
        city2.SetInteger("animHealth",citySpriteHealth);
    }
}
