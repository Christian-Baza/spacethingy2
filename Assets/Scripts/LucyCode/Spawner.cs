using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// kåden för att spawna fineder -Lucy
public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy1;
    [SerializeField]
    private GameObject enemy2;
    GameManager gameManager;
    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()// väljer nått att göra varje sekund -Lucy
    {
        float random = Random.Range(0,4);// väljer fiende att spawna eller ingen alls -Lucy
        if (gameManager.score * 0.05f < 3)
        {
            yield return new WaitForSeconds(3 - (gameManager.score * 0.05f));// Spawnar fiender varje 3 sekunder och antalet sekunder minskar med 50ms varje poäng. -Chris
        }
        else
        {
            yield return new WaitForSeconds(0.05f); // Så att tiden inte blir 0 så har jag gjort en else som låser WaitForSeconds på minst 50ms. -Chris
        }
        
        if(random == 0 || random == 1)
        {
            Instantiate(enemy1, transform.position, Quaternion.identity);
        }
        else if(random == 2)
        {
            Instantiate(enemy2, transform.position, Quaternion.identity);
            
        }
        if (random == 3 || random == 4)
        {
        }
        StartCoroutine(Spawn());
    }
}
