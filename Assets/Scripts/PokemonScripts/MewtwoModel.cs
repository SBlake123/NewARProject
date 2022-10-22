using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MewtwoModel : MonoBehaviour
{
    public MewtwoPlayer mewtwoplayer;
    public GameObject target;
    public GameObject tackleEffectFactory;
    public GameObject teleEffectFactory;
    public GameObject psychoBackEffectFactory;
    public GameObject psychoEffectFactory;
    // Start is called before the first frame update

    // ����Ʈ�� �߻����� ���ڰ���! �� ��ġ, Ÿ����ġ��. �ڷ�ƾ? �ڷ�ƾ
    // �������ʹ̳� �����÷��̾�� ����ٰ� �����ش޶�� ��.
    // Update is called once per frame
    public IEnumerator Tackle()
    {
        GameObject tackleEffect = Instantiate(tackleEffectFactory);
        if(target != null)
        {
            tackleEffect.transform.position = target.transform.position;
        }
        Destroy(tackleEffect, 3);
        yield return new WaitForSeconds(1f);
        mewtwoplayer.coEnd = true;
    }
    public IEnumerator Telekinesis()
    {
        GameObject teleEffect = Instantiate(teleEffectFactory);
        if (target != null)
        {
            teleEffect.transform.position = target.transform.position;
        }
        Destroy(teleEffect, 3);
        yield return new WaitForSeconds(3f);
        mewtwoplayer.coEnd = true;
    }
    public IEnumerator Psychokinesis()
    {
        GameObject psychoBackEffect = Instantiate(psychoBackEffectFactory);
        GameObject psychoEffect = Instantiate(psychoEffectFactory);
        psychoBackEffect.transform.position = transform.position;
        psychoEffect.transform.position += new Vector3(1000, 0, 0);
        yield return new WaitForSeconds(1f);
        if (target != null)
        {
            psychoEffect.transform.position = target.transform.position;
        }
        yield return new WaitForSeconds(2f);
        Destroy(psychoBackEffect);
        Destroy(psychoEffect);
        mewtwoplayer.coEnd = true;
        //��ũ��Ʈ���� ī�޶� ����?
    }
}
