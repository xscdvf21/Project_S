using UnityEngine;
using System.Collections.Generic;
using System;
public class InGame_Player : MonoBehaviour
{

    public void Init()
    {
        CreatePlayer(Vector2.zero);
    }
    private void CreatePlayer(Vector2 _vPos)
    {
        if (!Object_Mgr.Instance)
            return;

        Object_Mgr.Instance.player_Mgr.CreatePlayer(transform, _vPos);
    }

}

