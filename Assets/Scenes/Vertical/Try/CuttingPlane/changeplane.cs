using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeplane : MonoBehaviour
{
    int numberofplane;
    public GameObject[] planes = new GameObject[5];

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject now in planes)
        {
            now.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateplane(float newvalue)
    {
        numberofplane = (int)newvalue;
        

        foreach (GameObject now in planes)
        {
            now.SetActive(false);
            Debug.Log(newvalue);
        }

        planes[numberofplane].SetActive(true);

    }
}
