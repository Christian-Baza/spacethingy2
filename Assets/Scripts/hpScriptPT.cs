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
        currentHealth = maxHealth; // detta g�r att n�r man startar �r current helath p� det h�gsta.
    }

    // Update is called once per frame
    void Update()
    {
     
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "gongi")
        {
            currentHealth -= 20; //detta betyder att n�r v�r player�kolliderar med en enemy med tagen "gongi" s� tar den skada.
        }
    }
}



