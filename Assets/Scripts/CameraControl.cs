using System;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;
    
    private void Start()
    {
        if (camera1 != null)
        {
            camera1.gameObject.SetActive(true);
        }

        if (camera2 != null)
        {
            camera2.gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
                CameraSwitch();
        }
    }

    public void CameraSwitch()
    {
            bool isCamera1Active = camera1.gameObject.activeSelf;

            camera1.gameObject.SetActive(!isCamera1Active);
            camera2.gameObject.SetActive(isCamera1Active);
            
        
    }
}
