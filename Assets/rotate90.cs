using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate90 : MonoBehaviour
{
    public GameObject cam;

    public void perp()
    {
        var rot = cam.transform.rotation.eulerAngles;
        if (rot.y > 270)
        {
            rot.y = rot.y - 90;
        }
        else
        {
            rot.y = rot.y + 90;
        }
        cam.transform.rotation = Quaternion.Euler(rot);
    }
}
