using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MewtwoPlayer : Mewtwo
{
    // Start is called before the first frame update
    public MewtwoModel mewtwoModel;
    public PikachuEnemy pikachuEnemy;
    public PikachuHP pikachuHP;
    public bool canAttack = true;
    public bool coEnd = false;

    public void Tackle()
    {
        if (canAttack)
        {
            StartCoroutine(mewtwoModel.Tackle());
      
            pikachuHP.HP -= 20;
            canAttack = false;
            pikachuEnemy.canAttack = true;
 
        }
    }
    public void Telekinesis()
    {
        if (canAttack)
        {
            StartCoroutine(mewtwoModel.Telekinesis());

            pikachuHP.HP -= 20;
            canAttack = false;
            pikachuEnemy.canAttack = true;
        }

    }

    public void Psychokinesis()
    {
        if (canAttack)
        {
            StartCoroutine(mewtwoModel.Psychokinesis());

            pikachuHP.HP -= 40;
            canAttack = false;
            pikachuEnemy.canAttack = true;

        }

    }
}
