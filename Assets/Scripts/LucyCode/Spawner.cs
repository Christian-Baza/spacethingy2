using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// k�den f�r att spawna fineder -Lucy
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
    IEnumerator Spawn()// v�ljer n�tt att g�ra varje sekund -Lucy
    {
        float random = Random.Range(0,4);// v�ljer fiende att spawna eller ingen alls -Lucy
        if (gameManager.score * 0.05f < 3)
        {
            yield return new WaitForSeconds(3 - (gameManager.score * 0.05f));// Spawnar fiender varje 3 sekunder och antalet sekunder minskar med 50ms varje po�ng. -Chris
        }
        else
        {
            yield return new WaitForSeconds(0.05f); // S� att tiden inte blir 0 s� har jag gjort en else som l�ser WaitForSeconds p� minst 50ms. -Chris
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
