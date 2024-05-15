using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

/// <summary>
/// 인게임 플레이 관련 매니저
/// </summary>
public class InGame_Mgr : MonoBehaviour
{
    private static InGame_Mgr instance = null;

    public static InGame_Mgr Instance
    {
        get
        {
            return instance;
        }
    }

    public InGame_Map       map;
    public InGame_Player    player;
    public InGame_Monster   monster;
    private void Awake()
    {
        if(instance != null)
        {
            Destroy(this);
            return;
        }

        instance = this;
    }

    private void Start()
    {
        map.Init();
        player.Init();
        monster.Init();
    }



}

