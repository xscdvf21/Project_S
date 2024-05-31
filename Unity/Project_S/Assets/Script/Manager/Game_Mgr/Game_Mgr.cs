using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 게임 내 데이터를 보관할 객체
/// 옵션, 코어데이터 등등
/// </summary>
public class Game_Mgr : MonoBehaviour
{
    private static Game_Mgr instance = null;

    public static Game_Mgr Instance
    {
        get
        {
            return instance;
        }
    }


    bool isLogin = false;
    private void Awake()
    {
        instance = this;
    }

    public void SuccessLogin()
    {
        isLogin = true;

        LobbyPopup_Mgr.Instance.closeMsg.ShowMsg("Player Creating... Wait Plase");
        Object_Mgr.Instance.player_Mgr.CreatePlayer();

        Invoke("GameStart", 2f);

    }

    
    public void GameStart()
    {
        Loading_Mgr.Instance.NextScene("InGame");
    }
}
