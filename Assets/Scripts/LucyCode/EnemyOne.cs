using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// detta �r scriptet f�r enemy1 -Lucy
public class EnemyOne : Enemy
{
    public override void CityDameag()
    {
        cityCode.cityHealth--;
    }
    public override IEnumerator Move()// flytar enemy1 ett steg �t h�ger -Lucy
    {
        yield return new WaitForSeconds(1);
        transform.position = transform.position + new Vector3(2, 0, 0);
        StartCoroutine(Move());// starta om Move -Lucy
    }
}
