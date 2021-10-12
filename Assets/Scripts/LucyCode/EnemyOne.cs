using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// detta är scriptet för enemy1 -Lucy
public class EnemyOne : Enemy
{
    [SerializeField]
    private GameObject billet;
    public override void CityDamage()
    {
        cityCode.cityHealth = cityCode.cityHealth - 5;
    }
    public override IEnumerator Move()// flytar enemy1 ett steg åt häger -Lucy
    {
        yield return new WaitForSeconds(1);
        transform.position = transform.position + new Vector3(2, 0, 0);
        StartCoroutine(Move());// starta om Move -Lucy
    }
    public override void EnemyAtack()// specificerar hur fienden atakerar -Lucy
    {
        Instantiate(billet, transform.position,Quaternion.identity);
    }
}
