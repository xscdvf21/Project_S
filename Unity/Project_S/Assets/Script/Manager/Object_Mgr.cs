using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

/// <summary>
/// 각종 오브젝트 관리(플레이어, 몬스터 등등)
/// </summary>
public class Object_Mgr : MonoBehaviour
{
    private static Object_Mgr instance = null;

    public static Object_Mgr Instance
    {
        get
        {
            return instance;
        }
    }


    public Player_CharacterA mainPlayer;

    private void Awake()
    {
        instance = this;
    }
}

