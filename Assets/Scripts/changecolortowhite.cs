using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class changecolortowhite : MonoBehaviour
{
    public TextMeshProUGUI tmpObj;
    // Start is called before the first frame update
    void Awake()
    {
        tmpObj.color = new Color32(200, 200, 200, 255);
    }
}