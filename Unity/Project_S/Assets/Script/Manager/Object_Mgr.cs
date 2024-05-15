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


    public Player playerPrefab;
    public Monster[] monsterPrefabs;

    private void Awake()
    {
        instance = this;
    }

    public GameObject CreatePlayer(Vector2 _vPos)
    {
        if (playerPrefab == null)
            return null;

        GameObject player = Instantiate(playerPrefab.gameObject);
        player.transform.position = _vPos;
        return player;
    }

    public GameObject CreateMonster(MONSTER_KIND _kind, Vector2 _vPos)
    {
        GameObject monster = Instantiate(monsterPrefabs[(int)_kind].gameObject);
        monster.transform.position = _vPos;
        return monster;
    }

    
}

