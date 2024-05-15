using UnityEngine;
using System.Collections.Generic;
using System;

/// <summary>
/// 인게임 몬스터 생성 및 배치 (보관은 Game_Mgr));
/// </summary>
public class InGame_Monster : MonoBehaviour
{
    [SerializeField] Transform me;
    Dictionary<MONSTER_KIND, Transform> dic_parent;

    private void Awake()
    {
       
    }
    public void Init()
    {
        dic_parent = new Dictionary<MONSTER_KIND, Transform>();
        for (int i = 0; i < (int)MONSTER_KIND.END; ++i)
        {
            GameObject obj = new GameObject(((MONSTER_KIND)i).ToString());
            obj.transform.SetParent(me);

            dic_parent.Add((MONSTER_KIND)i, obj.transform);
        }

        for(int i =0; i < 5; ++i)
        {
            CreateMonster(MONSTER_KIND.SLIME_RED, new Vector2(i, i));

        }

    }

    private void CreateMonster(MONSTER_KIND _kind, Vector2 _vPos)
    {
        if (dic_parent.TryGetValue(_kind, out Transform _result))
        {
            GameObject monster = Object_Mgr.Instance.CreateMonster(_kind, _vPos);
            monster.transform.SetParent(_result, false);
            Game_Mgr.Instance.MonsterAdd(monster.GetComponent<Monster>());
        }

    }



}

