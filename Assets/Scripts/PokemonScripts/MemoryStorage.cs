using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class MemoryStorage : MonoBehaviour
{
    public static MemoryStorage instance;

    private void Awake()
    {
        instance = this;
    }
    public List<ARTrackedImage> markerStorage = new List<ARTrackedImage>();
}
