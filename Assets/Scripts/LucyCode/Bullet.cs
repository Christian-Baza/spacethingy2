using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//K�den f�r ur fiendens bober/skott ska funka; 
public class Bullet : Enemy
{
    public override void CityDamage()
    {
        cityCode.cityHealth--;
    }
    public override IEnumerator Move()
    {
        yield return new WaitForEndOfFrame();
    }
}
