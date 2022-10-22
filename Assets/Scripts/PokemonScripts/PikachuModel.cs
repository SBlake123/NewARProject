using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PikachuModel : MonoBehaviour
{
    public PikachuPlayer pikachuPlayer;
    public GameObject target;
    public GameObject tackleEffectFactory;
    public GameObject quickAttackEffectFactory;
    public GameObject chargeEffectFactory;
    public GameObject thunderEffectFactory;
    // Start is called before the first frame update

    // ����Ʈ�� �߻����� ���ڰ���! �� ��ġ, Ÿ����ġ��. �ڷ�ƾ? �ڷ�ƾ
    // �������ʹ̳� �����÷��̾�� ����ٰ� �����ش޶�� ��.
    // Update is called once per frame
    public IEnumerator Tackle()
    {
        GameObject tackleEffect = Instantiate(tackleEffectFactory);
        if (target != null)
        {
            tackleEffect.transform.position = target.transform.position;
        }
        Destroy(tackleEffect, 3);
        yield return new WaitForSeconds(1f);
        pikachuPlayer.coEnd = true;
    }

    public IEnumerator QuickAttack()
    {
        GameObject quickAttackEffect = Instantiate(quickAttackEffectFactory);
        if (target != null)
        {
            quickAttackEffect.transform.position = target.transform.position;
        }
        Destroy(quickAttackEffect, 3);
        yield return new WaitForSeconds(1f);
        pikachuPlayer.coEnd = true;
    }
    public IEnumerator ThunderShock()
    {
        GameObject chargeEffect = Instantiate(chargeEffectFactory);
        GameObject thunderEffect = Instantiate(thunderEffectFactory);
        chargeEffect.transform.position = transform.position;
        yield return new WaitForSeconds(1f);
        if (target != null)
        {
            thunderEffect.transform.position = target.transform.position;
        }
        yield return new WaitForSeconds(2f);
        Destroy(chargeEffect);
        Destroy(thunderEffect);
        pikachuPlayer.coEnd = true;
    }
}
