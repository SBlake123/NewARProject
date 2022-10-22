using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScreenManager : MonoBehaviour
{
    public AudioSource TitleMusic;
    public AudioSource ClickSound;

    public GameObject touchTheScreen;
    public Image blackScreen;
    float timer;
    float timer2;
    float audioTimer;
    bool isTimer = true;
    
    void Awake()
    {
        StartCoroutine(Fade(1,0,1.5f));
    }
    void Update()
    {
        timer += Time.deltaTime;
        if(isTimer)
        {
        if(timer >=0 && timer < 1.7f)
        touchTheScreen.SetActive(true);
        else if(timer >=1f && timer < 3.4f)
        touchTheScreen.SetActive(false);
        else if(timer>=3.4f)
        timer = 0;
        }

        if(isTimer == false)
        {
        if(timer >=0 && timer < 0.1f)
        touchTheScreen.SetActive(true);
        else if(timer >=0.1f && timer < 0.2f)
        touchTheScreen.SetActive(false);
        else if(timer>=0.2f)
        timer = 0;
        }
        
        if(Input.GetKey(KeyCode.Space))
        {
            isTimer = false;
            audioTimer += Time.deltaTime;
            StartCoroutine(Fade(0,1,2));
        }

        if(Input.touchCount > 0)
        {
            isTimer = false;
            Touch touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Began)
            {
                TitleMusic.volume = Mathf.Lerp(1,0,1);
                ClickSound.enabled = true;
                StartCoroutine(FadeOut(0,1,2));
            }
        }
    }



    IEnumerator Fade(float start, float end, float fadeTime)
    {
        float currentTime = 0.0f;
        float percent = 0.0f;

        while (percent < 1)
        {
            currentTime += Time.deltaTime;
            percent = currentTime / fadeTime;

            Color color = blackScreen.color;
            color.a = Mathf.Lerp(start,end,percent);
            blackScreen.color = color;

            yield return null;
        }
    }

    IEnumerator FadeOut(float start, float end, float fadeTime)
    {
        float currentTime = 0.0f;
        float percent = 0.0f;

        while (percent < 1)
        {
            currentTime += Time.deltaTime;
            percent = currentTime / fadeTime;

            Color color = blackScreen.color;
            color.a = Mathf.Lerp(start,end,percent);
            blackScreen.color = color;

            yield return null;
        }
        SceneManager.LoadScene("BattleScene");
    }
}
