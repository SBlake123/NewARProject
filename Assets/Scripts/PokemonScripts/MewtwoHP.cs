using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MewtwoHP : MonoBehaviour
{
    int hp;
    public Mewtwo mewtwo;
    public Slider sliderHP;
    public GameObject mewtwoModel;
    // Start is called before the first frame update
    public int HP
    {
        get { return hp; }
        set
        {
            hp = value;
            sliderHP.value = hp;
        }
    }
    void Start()
    {
        sliderHP.maxValue = mewtwo.hp;
        HP = mewtwo.hp;
    }
    private void Update()
    {
        LiveOrDie();
    }
    void LiveOrDie()
    {
        if (HP <= 0)
        {
            gameObject.SetActive(false);
            Destroy(mewtwoModel);
        }
    }
}
