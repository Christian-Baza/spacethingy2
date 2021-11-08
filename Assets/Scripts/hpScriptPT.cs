using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hpScriptPT : MonoBehaviour //Wincent
{


    public int maxHealth = 100;
    public int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth; // detta gör att när man startar är current helath på det högsta.
    }

    // Update is called once per frame
    void Update()
    {
     
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "gongi")
        {
            currentHealth -= 20; //detta betyder att när vår player´kolliderar med en enemy med tagen "gongi" så tar den skada.
        }
    }
}



