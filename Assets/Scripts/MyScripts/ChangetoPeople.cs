using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangetoPeople : MonoBehaviour
{
    public void StartApp()
    {
        SceneManager.LoadScene("SegmentationPeopleVert");
    }
}
