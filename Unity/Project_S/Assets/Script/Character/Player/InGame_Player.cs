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

        GameObject player = Object_Mgr.Instance.CreatePlayer(_vPos);
        player.transform.SetParent(this.transform, false);

        Game_Mgr.Instance.mainPlayer = player.GetComponent<Player>();
    }

}

