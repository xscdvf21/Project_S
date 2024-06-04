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

    //스테이지 현황
    [SerializeField] int stage;
    [SerializeField] int waveStep;

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

    public void StageCreate(int _stage, Vector2 _playerPos, MONSTER_TYPE _type, int _monsterCount)
    {
        if (!Object_Mgr.Instance)
            return;

        stage = _stage;
        waveStep = 1;

        //플레이어 위치 
        Object_Mgr.Instance.player_Mgr.Set_PlayerPos(InGame_Mgr.Instance.player.parent, _playerPos);

        //몬스터 
        var manager = Object_Mgr.Instance;
        Transform parent = InGame_Mgr.Instance.monster.GetParent(_type);
        if(parent != null)
        {
            for(int i = 0; i < _monsterCount; ++i)
            {
                manager.monster_Mgr.CreateMonster(parent, _type, new Vector2(UnityEngine.Random.Range(-100f, 100f), UnityEngine.Random.Range(-100f, 100f)));
            }
        }


    }
}
