using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// detta är scriptet för fiende typ ett -Lucy
public class EnemyOne : Enemy
{
    private void Start()
    {
        StartCoroutine(Move());
    }
    public override void CityDameag()
    {
        cityCode.cityHealth--;
    }
    IEnumerator Move()
    {
        yield return new WaitForSeconds(1);
        transform.position = transform.position + new Vector3(2, 0, 0);
        StartCoroutine(Move());
    }
}
