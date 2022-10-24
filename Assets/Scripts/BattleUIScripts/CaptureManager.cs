using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using TMPro;

public class CaptureManager : MonoBehaviour
{
    public bool playerCapture = true;
    public GameObject[] canvasUI;
    public TextMeshProUGUI playerSelectText;

    public MultiMarker multiMarker;

    public List<ARTrackedImage> imageList = new List<ARTrackedImage>();
    public List<ARTrackedImage> playerImageList = new List<ARTrackedImage>();
    public List<ARTrackedImage> enemyImageList = new List<ARTrackedImage>();

    private void Start()
    {
        multiMarker = GetComponent<MultiMarker>();
        canvasUI[0].SetActive(true);
    }

    public void PlayerCaptureEnd(bool selected)
    {
        if (selected)
            playerCapture = true;
        else
            playerCapture = false;
        multiMarker.canCapture = true;
    }

    public void Capture(List<ARTrackedImage> imageList, ARTrackedImage marker)
    {
        imageList.Add(marker);
        if (playerCapture == true) playerImageList.Add(imageList[0]);
        else enemyImageList.Add(imageList[0]);
        imageList.Clear();
    }

    public void CaptureUIActive(bool selected)
    {
        canvasUI[0].SetActive(selected);
    }

    public void UIActive(bool selected)
    {
        canvasUI[1].SetActive(selected);

        if (playerCapture == true)
            playerSelectText.text = "Do you want another capturing PokeSeal??";
        else if (playerCapture == false && enemyImageList.Count != 0) 
        {
            playerSelectText.text = "";
            canvasUI[1].SetActive(false);
            BattleSelectUIActive();
        }
    }
    
    private void BattleSelectUIActive()
    {
        canvasUI[2].SetActive(true);
    }
    
}
