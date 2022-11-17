using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locate : MonoBehaviour
{
    public Camera Cam;
    Quaternion origin = new Quaternion(0, 0, 0, 1);
    public void Return()
    {
        Cam.transform.rotation = origin;
        Cam.orthographicSize = 4;
        Debug.Log(Cam.orthographicSize);
    }
}
