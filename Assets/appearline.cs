using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appearline : MonoBehaviour
{
    public GameObject line;
    public GameObject cam;
    //NEW
    public GameObject sphere;

    private void Start()
    {
        line.gameObject.SetActive(false);
    }

    public void DrawLine(Vector3 pos)
    {
        line.gameObject.SetActive(true);
        var rot = cam.gameObject.transform.rotation.eulerAngles;
        rot.x = 90;
        line.gameObject.transform.rotation = Quaternion.Euler(rot);
        line.gameObject.transform.position = pos;

    }
    /*
    public void Update()
    {
        new WaitForSeconds(1);
        var follow = sphere.gameObject.transform.position;
        //Mirar a ver si al final esto es mejor que no ponerlo
        follow.y = 0;
        cam.gameObject.transform.position = follow;

    }
    */
}
