﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkDevices : MonoBehaviour
{
    WebCamTexture webCamTexture;

    // Start is called before the first frame update
    void Start()
    {
        WebCamDevice[] devices = WebCamTexture.devices;
        for (int i = 0; i < devices.Length; i++)
            Debug.Log(devices[i].name);
    }
}
