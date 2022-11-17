using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class back : MonoBehaviour
{
    public void StartApp()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
