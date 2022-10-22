using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PikachuHP : MonoBehaviour
{
    int hp;
    public Pikachu pikachu;
    public GameObject pikachuModel;
    public Slider sliderHP;

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
        sliderHP.maxValue = pikachu.hp;
        HP = pikachu.hp;
    }

    private void Update()
    {
        LiveOrDie();
    }
    void LiveOrDie()
    {
        if(HP <= 0)
        {
            gameObject.SetActive(false);
            Destroy(pikachuModel);
        }
    }
}
