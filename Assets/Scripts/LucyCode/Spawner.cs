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
    private void Start()
    {
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()// väljer nått att göra varje sekund -Lucy
    {
        float random = Random.Range(0,4);// väljer fiende att spawna eller ingen alls -Lucy
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
