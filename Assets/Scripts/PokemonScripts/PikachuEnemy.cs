using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PikachuEnemy : Pikachu
{
    public PikachuModel pikachuModel;
    public MewtwoPlayer mewtwoPlayer;
    public MewtwoHP mewtwoHP;
    public bool canAttack = false;
    // Start is called before the first frame update
    // Start is called before the first frame update
    private void Update()
    {
        if (canAttack)
        {
            StartCoroutine("Attack");
        }
    }
    IEnumerator Attack()
    {
        yield return new WaitForSeconds(1f);
        int rValue = Random.Range(0, 6);
        if (rValue < 3)
        {
            Tackle();
            mewtwoPlayer.canAttack = true;
        }
        else if (rValue < 5)
        {
            QuickAttack();
            mewtwoPlayer.canAttack = true;
        }
        else
        {
            ThunderShock();
            mewtwoPlayer.canAttack = true;
        }
    }
    public void Tackle()
    {
        if (canAttack)
        {
            StartCoroutine(pikachuModel.Tackle());
            mewtwoHP.HP -= 20;
            canAttack = false;
        }
    }
    public void QuickAttack()
    {
        if (canAttack)
        {
            StartCoroutine(pikachuModel.QuickAttack());
            mewtwoHP.HP -= 30;
            canAttack = false;
        }
    }
    public void ThunderShock()
    {
        if (canAttack)
        {
            StartCoroutine(pikachuModel.ThunderShock());
            mewtwoHP.HP -= 40;
            canAttack = false;
        }
    }
}
