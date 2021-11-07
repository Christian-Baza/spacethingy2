using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// detta är scriptet för enemy1 -Lucy
public class EnemyOne : Enemy
{
    [SerializeField]
    private Transform BulletPrefab;
    [SerializeField]
    private Transform GunPoint;
    public override void CityDamage()
    {
        cityCode.cityHealth = cityCode.cityHealth - 5;
    }
    public override IEnumerator Move()// flytar enemy1 ett steg åt häger -Lucy
    {
        yield return new WaitForSeconds(1);
        transform.position = transform.position + new Vector3(0.5f, 0, 0);
        StartCoroutine(Move());// starta om Move -Lucy
    }
    public override void EnemyAtack()// specificerar hur fienden atakerar -Lucy
    {
        Transform Bullet = Instantiate(BulletPrefab, GunPoint.position, Quaternion.identity); // Skapar fiende skottet. -Chris
        Vector3 ShootDirection = Vector3.up; // Sätter riktningen av skottet. -Chris
        Bullet.GetComponent<bullet>().BulletSetup(ShootDirection);
    }
}
