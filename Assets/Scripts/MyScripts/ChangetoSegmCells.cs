using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangetoSegmCells : MonoBehaviour
{
    public void StartApp()
    {
        SceneManager.LoadScene("SegmentationCellsVert");
    }
}