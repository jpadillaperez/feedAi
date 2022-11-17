using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixCamera : MonoBehaviour
{
    private Vector3 fixpos;
    public GameObject MainCamera;
    private Quaternion fixrot;

    public void Fix()
    {
        fixpos = MainCamera.transform.position;
        fixrot = MainCamera.transform.rotation;
    }
    private void Update()
    {
        MainCamera.transform.position = fixpos;
        MainCamera.transform.rotation = fixrot;
    }
}
