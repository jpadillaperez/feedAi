using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartApp()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void ContactOpen()
    {
        Debug.Log("CONTACTO");
    }
    public void OptionsOpen()
    {
        SceneManager.LoadScene("OptionsMenu");
    }
}
