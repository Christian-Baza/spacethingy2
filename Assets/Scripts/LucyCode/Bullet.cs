using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//K�den f�r ur fiendens bober/skott ska funka; 
public class Bullet : Enemy
{
    private float hieght;
    private void Update()
    {
        hieght = transform.position.y;
        if (hieght > 9f) { Destroy(gameObject); }
    }
    public override void CityDamage()
    {
        cityCode.cityHealth--;
    }
    public override IEnumerator Move()
    {
        yield return new WaitForEndOfFrame();
    }
}
