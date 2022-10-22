using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MewtwoEnemy : Mewtwo
{
    public MewtwoModel mewtwoModel;
    public PikachuPlayer pikachuPlayer;
    public PikachuHP pikachuHP;
    bool _canAttack = false;
    public bool canAttack
    {
        get { return _canAttack; }
        set
        {
            canAttack = value;
            if (canAttack == true)
            {
                attckAction = true;
            }
        }
    }
    public bool attckAction = false;
    // Start is called before the first frame update
    private void Update()
    {
        if (attckAction && canAttack)
        {
            attckAction = false;
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
            pikachuPlayer.canAttack = true;
        }
        else if (rValue < 5)
        {
            Telekinesis();
            pikachuPlayer.canAttack = true;
        }
        else
        {
            Psychokinesis();
            pikachuPlayer.canAttack = true;
        }
    }

    public void Tackle()
    {
        if (canAttack)
        {
            StartCoroutine(mewtwoModel.Tackle());
            pikachuHP.HP -= 20;
            canAttack = false;
        }
    }
    public void Telekinesis()
    {
        if (canAttack)
        {
            StartCoroutine(mewtwoModel.Telekinesis());
            pikachuHP.HP -= 20;
            canAttack = false;
        }
    }
    public void Psychokinesis()
    {
        if (canAttack)
        {
            StartCoroutine(mewtwoModel.Psychokinesis());
            pikachuHP.HP -= 40;
            canAttack = false;
        }
    }
}
