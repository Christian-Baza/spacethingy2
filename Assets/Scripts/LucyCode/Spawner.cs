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
    private void Start()
    {
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()// v�ljer n�tt att g�ra varje sekund -Lucy
    {
        float random = Random.Range(0,4);// v�ljer fiende att spawna eller ingen alls -Lucy
        yield return new WaitForSeconds(3);
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
