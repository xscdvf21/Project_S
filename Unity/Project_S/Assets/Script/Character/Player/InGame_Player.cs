using UnityEngine;
using System.Collections.Generic;
using System;
public class InGame_Player : MonoBehaviour
{
    public Player me;
    public Transform parent;
    public void Init()
    {
        

        if (me == null)
            me = Object_Mgr.Instance.player_Mgr.Get_MainPlayer();

        parent = transform;
    }


    

}

