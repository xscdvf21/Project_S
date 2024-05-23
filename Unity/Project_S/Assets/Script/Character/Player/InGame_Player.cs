using UnityEngine;
using System.Collections.Generic;
using System;
public class InGame_Player : MonoBehaviour
{
    public Player me;
    public void Init()
    {
        

        if (me == null)
            me = Object_Mgr.Instance.player_Mgr.Get_MainPlayer();

        me.GetComponent<PlayerControler>().SetCamera(Camera.main);
        Object_Mgr.Instance.player_Mgr.Set_PlayerPos(transform, Vector2.zero);       
    }


    

}

