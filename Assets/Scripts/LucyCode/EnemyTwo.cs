using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//k�den f�r enemy2 -Lucy
public class EnemyTwo : Enemy
{
    [SerializeField]
    private Rigidbody rb;

    public override void CityDamage()
    {
        cityCode.cityHealth = cityCode.cityHealth - 5;// tar bort hp fr�n staden;
    }
    public override IEnumerator Move()//k�den f�r att best�ma hur enemy 2 ska r�ra sig -Lucy
    {
        int i = 0;
        int rCompare = Random.Range(1, 6);// en random sifra mellan 1 & 6 s�tt spm timer inann fiunde tv� droppar och faller ner p� staden -Lucy
        yield return new WaitForSeconds(1);// denna moddade variation av Move fungerar ocks� som atack k�d f�r Fiende tv� -Lucy
        i++;
        if (i>= rCompare)//h�r j�mf�rs i och rCompare f�r att som enemy ska droppa -Lucy
        {
            rb.useGravity = true;
        }
        transform.position = transform.position + new Vector3(2, 0, 0);// om enemy2 inta ska droppa s� r�r den sig ett steg �t h�ger -Lucy
        StartCoroutine(Move());//startar om move -Lucy
    }
}

