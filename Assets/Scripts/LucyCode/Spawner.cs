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
    [SerializeField]
    private GameObject enemy3;
    private void Start()
    {
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()// v�ljer n�tt att g�ra varje sekund -Lucy
    {
        float random =  Random.Range(0,5);// v�ljer fiende att spawna eller ingen alls -Lucy
        yield return new WaitForSeconds(1);
        if(random == 0 || random == 1)
        {
            Instantiate(enemy1, transform.position, Quaternion.identity);
            print("Enemy1");
        }
        else if(random == 2)
        {
            Instantiate(enemy2, transform.position, Quaternion.identity);
            print("enemy2");
        }
        else if (random == 3)
        {
            Instantiate(enemy3, transform.position, Quaternion.identity);
            print("enemy3");
        }
        if (random == 4 || random == 5)
        {
            print("empty");
        }
        StartCoroutine(Spawn());
    }
}
