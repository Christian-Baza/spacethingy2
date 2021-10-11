using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyThree : Enemy
{
    public override IEnumerator Move()// flytar enemy1 ett steg åt häger -Lucy
    {
        yield return new WaitForSeconds(1);
        transform.position = transform.position + new Vector3(2, 0, 0);
        StartCoroutine(Move());// starta om Move -Lucy
    }
}
