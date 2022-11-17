using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class UserG
{
    public string userName;
    public string localId;

    public UserG()
    {
        userName = GoogleSignInDemo.username;
        localId = GoogleSignInDemo.localId;
    }
}
