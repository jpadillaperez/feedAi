using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class justorthogonal : MonoBehaviour
{
    public GameObject cam;
    public GameObject[] plane;
    private float mindist = 1.5f;
    private float diff;
    private int counter;
    private int chosen;
    private int prev = 0;
    private float rot;
    
    void Update()
    {
        rot = cam.transform.rotation.eulerAngles.y;
        counter = -1;

        /*if (rot < 0 | rot > 180)
        {
            rot = rot - 180;
        }
        */
        foreach (GameObject obj in plane)
        {
            counter = counter + 1;
            diff = Mathf.Abs(rot - obj.transform.rotation.eulerAngles.y);
            if (diff < mindist) 
            {
                mindist = diff;
                chosen = counter;
            }
        }
        if (chosen != prev)
        {
            plane[chosen].gameObject.SetActive(true);
            plane[prev].gameObject.SetActive(false);
        }

        prev = chosen;
        mindist = 1.5f;
    }
}
