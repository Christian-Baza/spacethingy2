using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//kåden för enemy2 -Lucy
public class EnemyTwo : Enemy
{
    [SerializeField]
    private Rigidbody rb;

    public override void CityDamage()
    {
        cityCode.cityHealth = cityCode.cityHealth - 5;// tar bort hp från staden;
    }
    public override IEnumerator Move()//kåden för att bestäma hur enemy 2 ska röra sig -Lucy
    {
        int i = 0;
        int rCompare = Random.Range(1, 6);// en random sifra mellan 1 & 6 sätt spm timer inann fiunde två droppar och faller ner på staden -Lucy
        yield return new WaitForSeconds(1);// denna moddade variation av Move fungerar också som atack kåd för Fiende två -Lucy
        i++;
        if (i>= rCompare)//här jämförs i och rCompare för att som enemy ska droppa -Lucy
        {
            rb.useGravity = true;
        }
        transform.position = transform.position + new Vector3(2, 0, 0);// om enemy2 inta ska droppa så rör den sig ett steg åt höger -Lucy
        StartCoroutine(Move());//startar om move -Lucy
    }
}

