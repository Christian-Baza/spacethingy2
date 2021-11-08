using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//kåden för enemy2 -Lucy
public class EnemyTwo : Enemy
{
    [SerializeField]
    private float MoveSpeed = -1f;
    private bool fall;
    public override void Start()
    {
        base.Start();
        StartCoroutine(EnemyAtackTimer(10));
    }
    
    public override IEnumerator Move()//kåden för att bestäma hur enemy 2 ska röra sig -Lucy
    {
        if (fall != true)
        {
            yield return new WaitForSeconds(1);// denna moddade variation av Move fungerar också som atack kåd för Fiende två -Lucys
            transform.position = transform.position + new Vector3(0.5f, 0, 0);// om enemy2 inta ska droppa så rör den sig ett steg åt höger -Lucy
            StartCoroutine(Move());//startar om move -Lucy
        }
    }
    public override void EnemyAtack()
    {
        fall = true;
    }
    public override void Update()
    {
        base.Update();
        if (fall == true)
        {
            transform.position += Vector3.up * MoveSpeed * Time.deltaTime; //Rör skottet åt det hållet den kollar. -Chris
        }
    }
}

