using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Appear : MonoBehaviour
{
    public RectTransform avatarMove;
    // Start is called before the first frame update
    public void Move()
    {
        LeanTween.move(avatarMove, new Vector3(0f, 0f, 0f), 0.5f).setEase(LeanTweenType.easeSpring);
    }

}
