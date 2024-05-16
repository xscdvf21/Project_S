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

        CreateMonster(5, MONSTER_KIND.SLIME_RED);
    }



    private void CreateMonster(int _count, MONSTER_KIND _kind)
    {
        if (dic_parent.TryGetValue(_kind, out Transform _result))
        {

            for (int i = 0; i < _count; ++i)
            {
                int iIndex = i;
                Object_Mgr.Instance.monster_Mgr.CreateMonster(_result, _kind, new Vector2(UnityEngine.Random.Range(-100f, 100f), UnityEngine.Random.Range(-100f, 100f)));
            }
        }

    }



}

