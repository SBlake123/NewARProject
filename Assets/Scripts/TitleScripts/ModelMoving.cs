using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelMoving : MonoBehaviour
{
    float timer;
    void Update()
    {        
        if(Input.touchCount == 0)
        {
            timer += Time.deltaTime;
            if(timer >=0 && timer < 2.5f)
            transform.position += transform.up * 0.05f;
            else if(timer >=2.5f && timer < 5)
            transform.position -= transform.up * 0.05f;
            else if(timer>=5)
            timer = 0;
        }  
    }
}
