using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class synchrotation : MonoBehaviour
{
    public GameObject cam;
    public GameObject subject;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        var rotationVector = cam.transform.rotation.eulerAngles;
        rotationVector = -rotationVector;
        subject.transform.rotation = Quaternion.Euler(rotationVector);
    }
}
