using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public static class SwitchCinemaScene 
{
    static List<CinemachineVirtualCamera> camers = new List<CinemachineVirtualCamera>();
    
    static CinemachineVirtualCamera ActiveCamera;
    public static bool isActiveCamera(CinemachineVirtualCamera cam)
    {
        return cam == ActiveCamera;        
    }
    
    public static void switchCamera(CinemachineVirtualCamera camera)
    {
        camera.Priority = 10;
        ActiveCamera = camera;
        foreach(CinemachineVirtualCamera cam in camers)
        {
            if (cam != camera)
            {
                cam.Priority = 0;
            }
        }

    }
    public static void Register(CinemachineVirtualCamera camera)
    {
        camers.Add(camera);
        
    }

    public static void UnRegister(CinemachineVirtualCamera camera)
    {
        camers.Remove(camera);
        
    }
}
