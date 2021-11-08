using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//k�den f�r enemy2 -Lucy
public class EnemyTwo : Enemy
{
    [SerializeField]
    private float MoveSpeed = -1f;
    private bool fall;
    public override void Start()
    {
        base.Start();
        StartCoroutine(EnemyAtackTimer(6));
    }
    public override void CityDamage()
    {
        gameManager.cityHealth -= 5;// tar bort hp fr�n staden;
    }
    
    public override IEnumerator Move()//k�den f�r att best�ma hur enemy 2 ska r�ra sig -Lucy
    {
        if (fall != true)
        {
            yield return new WaitForSeconds(1);// denna moddade variation av Move fungerar ocks� som atack k�d f�r Fiende tv� -Lucys
            transform.position = transform.position + new Vector3(0.5f, 0, 0);// om enemy2 inta ska droppa s� r�r den sig ett steg �t h�ger -Lucy
            StartCoroutine(Move());//startar om move -Lucy
        }
    }
    public override void EnemyAtack()
    {
        fall = true;
    }
    private void Update()
    {
        base.Update();
        if (fall == true)
        {
            transform.position += Vector3.up * MoveSpeed * Time.deltaTime; //R�r skottet �t det h�llet den kollar. -Chris
        }
    }
}

