using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    private void Awake()
    {
        instance = this;
    }
    public GameObject[] menu;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            menu[i].SetActive(false);
        }
    }
    public void PlayerStatusPikachu()
    {
        menu[0].SetActive(true);
    }
    public void PlayerStatusMewtwo()
    {
        menu[1].SetActive(true);
    }
    public void EnemyStatusPikachu()
    {
        menu[2].SetActive(true);
    }
    public void EnemyStatusMewtwo()
    {
        menu[3].SetActive(true);
    }

    public void UIOn()
    {
        for (int i = 0; i < MemoryStorage.instance.markerStorage.Count; i++)
        {
            // 0: ���ϴ�, 1: ����
            if (i == 0)
            {
                // ���ϴܿ��� ó�� �ν��� �༮��
                if (MemoryStorage.instance.markerStorage[0].referenceImage.name.ToLower() == "pikachu")
                {
                    PlayerStatusPikachu();
                }
                else { PlayerStatusMewtwo(); }
            }
            else if (i == 1)
            {
                // ���ܿ��� �ι�° �ν��� �༮
                if (MemoryStorage.instance.markerStorage[1].referenceImage.name.ToLower() == "pikachu")
                {
                    EnemyStatusPikachu();
                }
                else { EnemyStatusMewtwo(); }
            }
        }
    }

    // Update is called once per frame

}
