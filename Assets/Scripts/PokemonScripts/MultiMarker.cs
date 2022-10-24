using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

// ARTrackedImageManager ���� �̹����� �����Ǿ����� ������ �ް��ʹ�.
// ������ ��Ŀ�� ���� �˰��ִ� ��Ͽ� �ִ� �༮�̶��
// �� ��Ŀ�� �ش��ϴ� ������Ʈ�� �� ��ġ�� ��ġ�ϰ��ʹ�.
public class MultiMarker : MonoBehaviour
{
    public bool canCapture = true;

    public CaptureManager captureManager;
    ARTrackedImageManager aRTrackedImageManager;
    void Awake()
    {
        aRTrackedImageManager = GetComponent<ARTrackedImageManager>();
        captureManager = GetComponent<CaptureManager>();
    }

    private void OnEnable()
    {
        aRTrackedImageManager.trackedImagesChanged += OnTrackedImagesChanged;
    }
    private void OnDisable()
    {
        aRTrackedImageManager.trackedImagesChanged -= OnTrackedImagesChanged;
    }

    [Serializable]
    public class MarkerInfo
    {
        public string name;
    }
    
    public MarkerInfo[] infos;


    //마커가 카메라 범위 안에 들어왔을 때, 기억하고, 상대편 띠부띠부씰도 기억한 후에 선택하고 게임 창 열어서 배틀 시작한다.


    private bool MarkerTransformChecker(ARTrackedImage marker)
    {
        if (marker.transform.position.x <= (Camera.main.transform.position.x + 10) && marker.transform.position.x >= (Camera.main.transform.position.x - 10) &&
            marker.transform.position.y <= (Camera.main.transform.position.y + 10) && marker.transform.position.y >= (Camera.main.transform.position.y - 10))
        {
            return true;
        }
        else
            return false;
    }

    private void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs args)
    {
        var list = args.added;
        for (int i = 0; i < list.Count; i++)
        {
            ARTrackedImage marker = list[i];
            for (int j = 0; j < infos.Length; j++)
            {
                if (marker.referenceImage.name == infos[j].name && MarkerTransformChecker(marker) && canCapture)
                {
                    captureManager.Capture(captureManager.imageList, marker);
                    captureManager.CaptureUIActive(false);
                    captureManager.UIActive(true);
                    canCapture = false;
                }
            }
        }
    }

}
