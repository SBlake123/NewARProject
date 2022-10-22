using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PikachuPlayer : Pikachu
{
    // Start is called before the first frame update
    public PikachuModel pikachuModel;
    public MewtwoEnemy mewtwoEnemy;
    public MewtwoHP mewtwoHP;
    public bool canAttack = true;
    public bool coEnd = false;
    // Start is called before the first frame update
    public void Tackle()
    {
        if (canAttack)
        {
            StartCoroutine(pikachuModel.Tackle());
            mewtwoHP.HP -= 20;
            canAttack = false;
            mewtwoEnemy.canAttack = true;
        }
    }
    public void QuickAttack()
    {
        if (canAttack)
        {
            StartCoroutine(pikachuModel.QuickAttack());
            mewtwoHP.HP -= 30;
            canAttack = false;
            mewtwoEnemy.canAttack = true;
        }
    }
    public void ThunderShock()
    {
        if (canAttack)
        {
            StartCoroutine(pikachuModel.ThunderShock());
            mewtwoHP.HP -= 40;
            canAttack = false;
            mewtwoEnemy.canAttack = true;
        }
    }
}
