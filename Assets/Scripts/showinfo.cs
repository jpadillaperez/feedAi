using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class showinfo : MonoBehaviour
{
    public RectTransform infomenu;
    // Start is called before the first frame update
    private void Start()
    {
        infomenu.DOAnchorPos(new Vector2(-200, 0), 0.25f);
    }
    public void Appear()
    {
    }

}
