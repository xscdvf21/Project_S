using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using System;
/// <summary>
/// 각종 프리팹  오브젝트 관리(플레이어, 몬스터 등등)
/// 오브젝트 풀이나, 이런것은 Game_Mgr 에서 할 예정
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


    [Header("플레이어 관리")]
    public Player_Mgr player_Mgr;

    [Header("몬스터 관리")]
    public Monster_Mgr monster_Mgr;

    [Header("아이템 목록")]
    public Item_Mgr item_Mgr;

    [Header("맵(스테이지) 관리")]
    public Map_Mgr map_Mgr;
    private void Awake()
    {
        instance = this;
    }




}

