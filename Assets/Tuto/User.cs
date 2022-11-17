using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class User
{
    public string userName;
    public string localId;

    public User()
    {
        userName = PlayerScores.playerName;
        localId = PlayerScores.localId;
    }
}
